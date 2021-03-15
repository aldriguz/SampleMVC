using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SampleMVC.Core.Entities;
using SampleMVC.Infraestructure.Interfaces;
using SampleMVC.WebApp.Dtos;
using SmapleMVC.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SampleMVC.WebApp.Controllers
{
    [Route("api/[controller]")]
    public class PropertyController : Controller
    {
        private readonly IPropertyApiService _propertyApiService;
        private readonly IRepository _repository;
        private readonly IMapper _mapper;
        public PropertyController(IPropertyApiService propertyApiService, IRepository repository, IMapper mapper)
        {
            _propertyApiService = propertyApiService;
            _repository = repository;
            _mapper = mapper;
        }       

        [HttpGet]
        [Route("/")]
        public async Task<IActionResult> Index()
        {
            var response = await _propertyApiService.GetPropertyListFromApiAsync();
            var viewData = _mapper.Map<List<PropertyDto>>(response);

            return View(viewData);
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddProperty([FromBody] PropertyDto item)
        {
            try
            {
                var property = new Property()
                {
                    Address = item.Address,
                    GrossYield = item.GrossYield,
                    ListPrice = item.ListPrice,
                    MonthlyRent = item.MonthlyRent,
                    YearBuilt = item.YearBuilt
                };

                await _repository.AddAsync(property);
                return Ok(property);
            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
            
        }
    }
}
