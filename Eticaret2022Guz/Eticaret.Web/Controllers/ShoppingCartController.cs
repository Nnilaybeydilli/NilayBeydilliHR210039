using Eticaret.Core.Dtos.Response;
using Eticaret.Core.Models;
using Eticaret.Core.Services;
using Eticaret.Web.Services;
using ETicaret.BussinessLayer.Concrete;
using ETicaret.EntityLayer.Concretes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Eticaret.Web.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ShoppingCartApiService _shoppingcartApiService;


        //     private readonly ICategoryService _categoryService;

        public ShoppingCartController(ShoppingCartApiService ShoppingCartApiService)
        {
            _shoppingcartApiService = ShoppingCartApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            CustomResponseDto<List<ShoppingCart>> customResponseDto = await _shoppingcartApiService.GetListAsync();
            return View(customResponseDto.Data);
        }


        public async Task<IActionResult> Delete(int id)
        {
            bool sonuc = await _shoppingcartApiService.DeleteByIdAsync(id);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Add()
        {
            ShoppingCart shoppingCart = new ShoppingCart();

            return View(shoppingCart);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ShoppingCart addShoppingCart)
        {
            addShoppingCart.Status = true;

            if (ModelState.IsValid)
            {

                var sonuc = await _shoppingcartApiService.AddAsync(addShoppingCart);
                if (sonuc.StatusCode == 200)
                {
                    return RedirectToAction(nameof(Index));
                }

            }

            return View(addShoppingCart);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var sonuc = await _shoppingcartApiService.GetModelByIdAsync(id);
            //List<bool> bools = new List<bool>() { true, false };
            //ViewBag.Status = new SelectList(bools,)

            return View(sonuc.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ShoppingCart updateShoppingCart)
        {
            var sonuc = await _shoppingcartApiService.UpdateAsync(updateShoppingCart);
            return RedirectToAction(nameof(Index));
        }

    }



}
