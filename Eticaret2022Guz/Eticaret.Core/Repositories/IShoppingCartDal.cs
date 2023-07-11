
using Eticaret.Core.Models;
using ETicaret.EntityLayer.Concretes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eticaret.Repositories
{
    public interface IShoppingCartDal : IGenericDal<ShoppingCart>
    {
        Task<List<ShoppingCart>> Get3ShoppingCart();

    }

}
