using SmapleMVC.SharedKernel.Enities;
using SmapleMVC.SharedKernel.Interfaces;
using System.Threading.Tasks;

namespace SampleMVC.Infraestructure.Data
{
    public class EFRepository : IRepository
    {
        private readonly SampleMvcContext _dbContext;

        public EFRepository(SampleMvcContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<T> AddAsync<T>(T entity) where T : BaseEntity
        {
            _dbContext.Set<T>().Add(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }
    }
}
