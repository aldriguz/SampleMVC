using SmapleMVC.SharedKernel.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmapleMVC.SharedKernel.Interfaces
{
    public interface IRepository
    {
        Task<T> GetAll<T>() where T : BaseEntity;
        Task<T> AddAsync<T>(T entity) where T : BaseEntity;
    }
}
