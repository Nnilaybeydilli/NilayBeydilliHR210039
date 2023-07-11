using Eticaret.Core.Dtos.Response;
using Eticaret.Core.Models;
using Eticaret.Core.Services;
using Eticaret.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ETicaret.BussinessLayer.Concrete
{
    public class AdressService : Service<Adress>, IAdressService
    {

        private readonly IAdressDal _adressDal;

        public AdressService(IAdressDal adressDal, IGenericDal<Adress> genericDal) : base(genericDal)
        {
            _adressDal = adressDal;
        }
        public async Task<CustomResponseDto<List<Adress>>> Get3AdressAsync()
        {
            var adresses = await _adressDal.Get3Adress();
            return CustomResponseDto<List<Adress>>.Succes(200, adresses);
        }







    }
}
