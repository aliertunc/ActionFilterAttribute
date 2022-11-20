using ActionFilterAttribute.Model;
using System.Collections.Generic;

namespace ActionFilterAttribute.Services
{
    public class CountryService
    {
        public IEnumerable<Country> GetAllCountries()
        {
            return new List<Country>()
        {
            new Country(){ Name = "Turkey" },
            new Country(){ Name = "Belgium" },
            new Country(){ Name = "France" },
            new Country(){ Name = "Denmark" },
            new Country(){ Name = "Argentina" },
            new Country(){ Name = "Germany" },
            new Country(){ Name = "Cuba" },
            new Country(){ Name = "Hungary" }
        };
        }
    }
}
