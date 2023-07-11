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
    public class EfBrandRepository : EfRepositoyBase<Brand>, IBrandDal
    {

        
    }

}
