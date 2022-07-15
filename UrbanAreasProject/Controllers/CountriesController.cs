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
        /// Search country by wikiId
        /// </summary>
        /// <param name="nameCountryPrefix"></param>
        /// <returns>View with information about country</returns>
        [HttpGet("nameCountry")]
        [Route("/[controller]/CountryByName")]
        public async Task<IActionResult> GetCountry(string CountryWikiID)
        {
            var countries = await _cityClient.GetCountryAsync(CountryWikiID);
            return View("Country", countries);
        }
    }
}
