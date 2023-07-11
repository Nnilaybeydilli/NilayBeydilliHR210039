using Eticaret.Core.Models;
using Eticaret.Core.Services;
using ETicaret.BussinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Eticaret.WepAPI.Controllers
{
    public class AdressController : CustomBaseController
    {
        private IAdressService _adressService;

        public AdressController(IAdressService adressService)
        {
            _adressService = adressService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetList()
        {
            //var result = await _employeeService.GetListAsync();
            //if (result is not null)
            //    return Ok(result);
            return CreateActionResult(await _adressService.GetListAsync(x => x.AdressStatus == true));
        }

        [HttpGet]
        [Route("[action]/{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateActionResult(await _adressService.GetModelByIdAsync(id));
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Add([FromBody] Adress employee)
        {
            return CreateActionResult(await _adressService.AddAsync(employee));
        }


        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> Update([FromBody] Adress employee)
        {
            return CreateActionResult(await _adressService.UpdateAsync(employee));
        }

        [HttpDelete]
        [Route("[action]/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            return CreateActionResult(await _adressService.DeleteByIdAsync(id));
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetLast3()
        {
            return this.CreateActionResult(await _adressService.Get3AdressAsync());

        }

    }
}