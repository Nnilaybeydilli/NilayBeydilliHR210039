using Eticaret.Core.Dtos.Response;
using Eticaret.Core.Models;
using Eticaret.Core.Services;
using Eticaret.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ETicaret.BussinessLayer.Concrete
{
    public class BrandService : Service<Brand>, IBrandService
    {

        private readonly IBrandDal _brandDal;

        public BrandService(IBrandDal brandDal, IGenericDal<Brand> genericDal) : base(genericDal)
        {
            _brandDal = brandDal;
        }

       

       

       
    }
}
