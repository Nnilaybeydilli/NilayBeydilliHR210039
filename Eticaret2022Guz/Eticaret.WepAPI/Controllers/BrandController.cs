using Eticaret.Core.Models;
using Eticaret.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Eticaret.WepAPI.Controllers
{
    public class BrandController : CustomBaseController
    {

        private readonly IBrandService _IBrandService;

        public BrandController(IBrandService IBrandService)
        {
            _IBrandService = IBrandService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetList()
        {
            //var result = await _ICategoryService.GetListAsync(x => x.CategoryStatus == true); // CustomerResponseData<T>
            //if (result is not null)
            //    return Ok(result);
            return CreateActionResult(await _IBrandService.GetListAsync(x => x.BrandStatu == true));
        }

        [HttpGet]
        [Route("[action]/{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateActionResult(await _IBrandService.GetModelByIdAsync(id));

        }
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Add([FromBody] Brand brand)
        {
            return CreateActionResult(await _IBrandService.AddAsync(brand));
        }

        [HttpDelete]
        [Route("[action]/{id:int}")]

        public async Task<IActionResult> Delete(int id)
        {
            return CreateActionResult(await _IBrandService.DeleteByIdAsync(id));
        }


       

        [HttpPut]
        [Route("[action]")]

        public async Task<IActionResult> Update([FromBody] Brand brand)
        {
            return CreateActionResult(await _IBrandService.UpdateAsync(brand));
        }

    }
}
