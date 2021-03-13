using Ardalis.Result;
using SampleMVC.Core.Entities;
using SampleMVC.Core.Interfaces;
using SmapleMVC.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMVC.Core.Services
{
    public class PropertyApiService : IPropertyApiService
    {
        private readonly IRepository _repository;
        public PropertyApiService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<Result<PropertyList>> GetPropertyFromApiAsync()
        {
            var items = await _repository.GetAll<PropertyList>();

            return new Result<PropertyList>(items);
        }
    }
}
