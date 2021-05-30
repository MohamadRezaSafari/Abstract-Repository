using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core3.Models.Repository
{
    public interface ICityCommand : IRepositoryBase<Cities>
    {
        void CreateCity(Cities owner);
        void UpdateCity(Cities owner);
        void DeleteCity(Cities owner);
    }
}
