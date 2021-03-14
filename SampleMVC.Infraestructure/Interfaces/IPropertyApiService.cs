using SampleMVC.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SampleMVC.Infraestructure.Interfaces
{
    public interface IPropertyApiService
    {
        Task<IList<Property>> GetPropertyListFromApiAsync();
    }
}
