using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core3.Models.Repository
{
    public interface ICityQuery : IRepositoryBase<Cities>
    {
        Task<IEnumerable<Cities>> GetCityWithFilterAsync(int stateId);
        Task<IEnumerable<Cities>> GetAllCities();
    }
}
