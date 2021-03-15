using SmapleMVC.Core.Enities;
using System.Threading.Tasks;

namespace SmapleMVC.Core.Interfaces
{
    public interface IRepository
    {
        //Task<T> GetAll<T>();
        Task<T> AddAsync<T>(T entity) where T : BaseEntity;
    }
}
