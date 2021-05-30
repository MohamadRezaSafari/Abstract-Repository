using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Internal;

namespace Core3.Models.Repository
{
    public class CityQuery : RepositoryBase<Cities>, ICityQuery
    {
        private readonly ClinicContext _context;

        public CityQuery(ClinicContext repositoryContext)
            : base(repositoryContext)
        {
            _context = repositoryContext;
        }


        public async Task<IEnumerable<Cities>> GetCityWithFilterAsync(int stateId)
        {
            var query= await
                Filter(
                    i => i.StateId == stateId,
                    i => i.OrderByDescending(x => x.CityId)
                        .ThenBy(x => x.StateId)
                );
            //return query.Join(_context.Cities, )
            return query;
        }

        public async Task<IEnumerable<Cities>> GetAllCities()
        {
            return await GetAll();
        }

    }
}
