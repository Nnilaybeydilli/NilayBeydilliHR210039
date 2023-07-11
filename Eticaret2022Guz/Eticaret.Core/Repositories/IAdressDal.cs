
using Eticaret.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eticaret.Repositories
{
    public interface IAdressDal : IGenericDal<Adress>
    {
        Task<List<Adress>> Get3Adress();
    }

}
