//using Ardalis.Result;
//using SampleMVC.Core.Entities;
using SampleMVC.Infraestructure.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SampleMVC.Infraestructure.Interfaces
{
    public interface IPropertyApiService
    {
        Task<IList<Property>> GetPropertyListFromApiAsync();
    }
}
