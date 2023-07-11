using Eticaret.Core.Dtos.Response;
using Eticaret.Core.Models;
using Eticaret.Core.Services;
using Eticaret.Web.Services;
using ETicaret.BussinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Eticaret.Web.Controllers
{
    public class AdressController : Controller
    {
        private readonly AdressApiService _adressApiService;


        

        public AdressController(AdressApiService adressApiService)
        {
            _adressApiService = adressApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            CustomResponseDto<List<Adress>> customResponseDto = await _adressApiService.GetListAsync();
            return View(customResponseDto.Data);
        }


        public async Task<IActionResult> Delete(int id)
        {
            bool sonuc = await _adressApiService.DeleteByIdAsync(id);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Add()
        {
            Adress adress = new Adress();

            return View(adress);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Adress addAdress)
        {
            addAdress.AdressStatus = true;

            if (ModelState.IsValid)
            {

                var sonuc = await _adressApiService.AddAsync(addAdress);
                if (sonuc.StatusCode == 200)
                {
                    return RedirectToAction(nameof(Index));
                }

            }

            return View(addAdress);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var sonuc = await _adressApiService.GetModelByIdAsync(id);
            //List<bool> bools = new List<bool>() { true, false };
            //ViewBag.Status = new SelectList(bools,)

            return View(sonuc.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Adress updateAdress)
        {
            var sonuc = await _adressApiService.UpdateAsync(updateAdress);
            return RedirectToAction(nameof(Index));
        }

    }



}
