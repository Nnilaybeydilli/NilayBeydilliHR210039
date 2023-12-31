﻿
using Eticaret.Core.Dtos.Response;
using Eticaret.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eticaret.Core.Services
{
    public interface IAdressService : IService<Adress>
    {

        Task<CustomResponseDto<List<Adress>>> Get3AdressAsync();
    }

}
