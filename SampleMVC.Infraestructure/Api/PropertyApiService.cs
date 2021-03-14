﻿using Newtonsoft.Json;
using RestSharp;
using SampleMVC.Infraestructure.Models;
using SampleMVC.Infraestructure.Interfaces;
using SampleMVC.Infraestructure.Models.Api;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMVC.Infraestructure.Api
{
    public class PropertyApiService : IPropertyApiService
    {
        //private readonly ILogger<PropertyApiService> _logger;
        private readonly RestClient _client = new RestClient("https://samplerspubcontent.blob.core.windows.net/public/properties.json");

        /*
        public PropertyApiService(ILogger<PropertyApiService> logger)
        {
            _logger = logger;
        }
        */

        public async Task<IList<Property>> GetPropertyListFromApiAsync()
        {
            var request = new RestRequest(Method.GET);

            var response = await _client.ExecuteAsync(request);

            ApiRoot apiRootCollection = JsonConvert.DeserializeObject<ApiRoot>(response.Content);

            var propertyList = apiRootCollection.properties.Select(item => new Property
            {
                Id = item.id,
                Address = item.address?.ToString(),
                GrossYield = item.financial?.netYield,
                ListPrice = item.financial?.listPrice,
                MonthlyRent = item.financial?.monthlyRent,
                YearBuilt = item.physical?.yearBuilt?.ToString(CultureInfo.InvariantCulture)
            }).ToList();

            //_logger.LogWarning("Finalize parsing collection data from api");

            return propertyList;

        }
    }
}