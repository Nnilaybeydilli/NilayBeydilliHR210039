using Eticaret.Core.Dtos.Response;
using Eticaret.Core.Models;
using Eticaret.Core.Services;
using Eticaret.Repositories;
using ETicaret.EntityLayer.Concretes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ETicaret.BussinessLayer.Concrete
{
    public class ShoppingCartService : Service<ShoppingCart>, IShoppingCartService
    {

        private readonly IShoppingCartDal _shoppingCartDal;

        public ShoppingCartService(IShoppingCartDal shoppingCartDal, IGenericDal<ShoppingCart> genericDal) : base(genericDal)
        {
            _shoppingCartDal = shoppingCartDal;
        }

        public async Task<CustomResponseDto<List<ShoppingCart>>> Get3ShoppingCartAsync()
        {
            var shoppingCarts = await _shoppingCartDal.Get3ShoppingCart();
            return CustomResponseDto<List<ShoppingCart>>.Succes(200, shoppingCarts);
        }




    }
}