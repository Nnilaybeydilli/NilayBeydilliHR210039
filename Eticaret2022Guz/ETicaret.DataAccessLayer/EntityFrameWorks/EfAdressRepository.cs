using Eticaret.Core.Models;
using Eticaret.Repositories;
using ETicaret.DataAccesLayer.Concretes.Contexts;
using ETicaret.DataAccesLayer.Repositories;

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.DataAccesLayer.EntityFrameWorks
{
    public class EfAdressRepository : EfRepositoyBase<Adress>, IAdressDal
    {
        public async Task<List<Adress>> Get3Adress()
        {

            using (ApplicationDbContext context = new ApplicationDbContext())
            {

                return await context.Set<Adress>().Take(3).ToListAsync();
            }
           
        }
    }

}
