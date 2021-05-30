using System;
using System.Threading.Tasks;
using Core3.Models;
using Core3.Models.Repository;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ClinicContext _repoContext;
        private ICityQuery _city;

        public ICityQuery cityRepository
        {
            get
            {
                if (_city == null)
                {
                    _city = new CityRepository(_repoContext);
                }

                return _city;
            }
        }
        
        public RepositoryWrapper(ClinicContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _repoContext.Dispose();
            }
        }
    }
}