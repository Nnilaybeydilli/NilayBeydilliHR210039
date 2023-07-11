using Eticaret.Core.Models;
using Eticaret.Core.Services;
using ETicaret.BussinessLayer.Concrete;
using ETicaret.EntityLayer.Concretes;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Eticaret.WepAPI.Controllers
{
   
    public class ShoppingCartController : CustomBaseController
    {
        private IShoppingCartService _shoppingCartService;

        public ShoppingCartController(IShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetList()
        {
            //var result = await _employeeService.GetListAsync();
            //if (result is not null)
            //    return Ok(result);
            return CreateActionResult(await _shoppingCartService.GetListAsync(x => x.Status == true));
        }

        [HttpGet]
        [Route("[action]/{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateActionResult(await _shoppingCartService.GetModelByIdAsync(id));
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Add([FromBody] ShoppingCart shoppingCart)
        {
            return CreateActionResult(await _shoppingCartService.AddAsync(shoppingCart));
        }


        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> Update([FromBody] ShoppingCart shoppingCart)
        {
            return CreateActionResult(await _shoppingCartService.UpdateAsync(shoppingCart));
        }

        [HttpDelete]
        [Route("[action]/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            return CreateActionResult(await _shoppingCartService.DeleteByIdAsync(id));
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetLast3()
        {
            return this.CreateActionResult(await _shoppingCartService.Get3ShoppingCartAsync());

        }

    }
}