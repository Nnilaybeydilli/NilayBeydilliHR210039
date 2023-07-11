using Eticaret.Core.Dtos.Response;
using Eticaret.Core.Models;
using Eticaret.Core.Services;
using Eticaret.Web.Services;
using ETicaret.BussinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Eticaret.Web.Controllers
{
    public class BrandController : Controller
    {
        private readonly BrandApiService _brandApiService;


        //     private readonly ICategoryService _categoryService;

        public BrandController(BrandApiService brandApiService)
        {
            _brandApiService = brandApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            CustomResponseDto<List<Brand>> customResponseDto = await _brandApiService.GetListAsync();
            return View(customResponseDto.Data);
        }


        public async Task<IActionResult> Delete(int id)
        {
            bool sonuc = await _brandApiService.DeleteByIdAsync(id);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Add()
        {
            Brand brand = new Brand();

            return View(brand);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Brand addBrand)
        {
            addBrand.BrandStatu = true;

            if (ModelState.IsValid)
            {

                var sonuc = await _brandApiService.AddAsync(addBrand);
                if (sonuc.StatusCode == 200)
                {
                    return RedirectToAction(nameof(Index));
                }

            }

            return View(addBrand);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var sonuc = await _brandApiService.GetModelByIdAsync(id);
            //List<bool> bools = new List<bool>() { true, false };
            //ViewBag.Status = new SelectList(bools,)

            return View(sonuc.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Brand updateBrand)
        {
            var sonuc = await _brandApiService.UpdateAsync(updateBrand);
            return RedirectToAction(nameof(Index));
        }

    }



}
