using Ardalis.Result;
using SampleMVC.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMVC.Core.Interfaces
{
    interface IPropertyApiService
    {
        Task<Result<PropertyList>> GetPropertyFromApiAsync();
    }
}
