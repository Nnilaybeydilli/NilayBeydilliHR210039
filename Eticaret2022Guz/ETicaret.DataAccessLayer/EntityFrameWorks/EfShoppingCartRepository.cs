using Eticaret.Core.Models;
using Eticaret.Repositories;
using ETicaret.DataAccesLayer.Concretes.Contexts;
using ETicaret.DataAccesLayer.Repositories;
using ETicaret.EntityLayer.Concretes;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.DataAccesLayer.EntityFrameWorks
{
    public class EfShoppingCartRepository : EfRepositoyBase<ShoppingCart>, IShoppingCartDal
    {
        public async Task<List<ShoppingCart>> Get3ShoppingCart()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {

                return await context.Set<ShoppingCart>().Take(3).ToListAsync();
            }
        }
    }

}
