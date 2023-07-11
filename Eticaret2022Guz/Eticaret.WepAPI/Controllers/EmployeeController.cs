using Eticaret.Core.Models;
using Eticaret.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Eticaret.WepAPI.Controllers
{
    public class EmployeeController : CustomBaseController
    {

        private readonly IEmployeeService _IEmployeeService;

        public EmployeeController(IEmployeeService IEmployeeService)
        {
            _IEmployeeService = IEmployeeService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetList()
        {
            //var result = await _ICategoryService.GetListAsync(x => x.CategoryStatus == true); // CustomerResponseData<T>
            //if (result is not null)
            //    return Ok(result);
            return CreateActionResult(await _IEmployeeService.GetListAsync(x => x.EmployeeStatu == true));
        }

        [HttpGet]
        [Route("[action]/{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateActionResult(await _IEmployeeService.GetModelByIdAsync(id));

        }
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Add([FromBody] Employee employee)
        {
            return CreateActionResult(await _IEmployeeService.AddAsync(employee));
        }

        [HttpDelete]
        [Route("[action]/{id:int}")]

        public async Task<IActionResult> Delete(int id)
        {
            return CreateActionResult(await _IEmployeeService.DeleteByIdAsync(id));
        }




        [HttpPut]
        [Route("[action]")]

        public async Task<IActionResult> Update([FromBody] Employee employee)
        {
            return CreateActionResult(await _IEmployeeService.UpdateAsync(employee));
        }

    }
}
