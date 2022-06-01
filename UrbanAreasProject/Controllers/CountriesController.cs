using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UrbanAreasProject.Clients;

namespace UrbanAreasProject.Controllers
{
    ///<summary>
    ///Get Countries from GeoDBCities (API) 
    ///</summary>
    [ApiController]
    public class CountriesController : Controller
    {
        private readonly GeoDBCitiesClient _cityClient;
        public CountriesController(GeoDBCitiesClient cityClient)
        {
            _cityClient = cityClient;
        }

        /// <summary>
        /// Search country by name
        /// </summary>
        /// <param name="nameCountryPrefix"></param>
        /// <returns>View with information about country</returns>
        [HttpGet("nameCountry")]
        [Route("/[controller]/CountryByName")]
        public async Task<IActionResult> GetCountry(string nameCountryPrefix)
        {
            var countries = await _cityClient.GetCountryAsync(nameCountryPrefix);
            return View("Country", countries);
        }
    }
}
