
using Eticaret.Core.Dtos.Response;
using Eticaret.Core.Models;
using ETicaret.EntityLayer.Concretes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eticaret.Core.Services
{
    public interface IShoppingCartService : IService<ShoppingCart>
    {

        Task<CustomResponseDto<List<ShoppingCart>>> Get3ShoppingCartAsync();

    }

}
