using System;
using System.Threading.Tasks;

namespace Core3.Models.Repository
{
    public interface IRepositoryWrapper : IDisposable
    {
        ICityQuery cityRepository { get; }
        void Save();
    }
}
