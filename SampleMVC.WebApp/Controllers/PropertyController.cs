using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SampleMVC.Core.Entities;
using SampleMVC.Infraestructure.Interfaces;
using SampleMVC.WebApp.Dtos;
using SmapleMVC.SharedKernel.Interfaces;
using System.Collections.Generic;
//using SampleMVC.Infraestructure.Models;
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

        // GET: ApiMicrosoftController
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/")]
        public async Task<IActionResult> GetAllProperties()
        {
            var response = await _propertyApiService.GetPropertyListFromApiAsync();
            var viewData = _mapper.Map<List<PropertyDto>>(response);

            return View(viewData);
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddProperty([FromBody] PropertyDto item)
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
    }
}
