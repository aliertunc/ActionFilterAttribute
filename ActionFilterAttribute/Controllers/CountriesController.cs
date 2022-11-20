using ActionFilterAttribute.ActionFilters;
using ActionFilterAttribute.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActionFilterAttribute.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AdvangeLogging]
    public class CountriesController : ControllerBase
    {
        private readonly CountryService countryService;
        public CountriesController(CountryService countryService)
        {
            this.countryService = countryService;
        }

        [HttpGet]
        public ActionResult GetCountries()
        {
            var countries = countryService.GetAllCountries();
            return Ok(countries);
        }
    }
}
