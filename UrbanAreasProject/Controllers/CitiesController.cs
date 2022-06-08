using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UrbanAreasProject.Clients;


namespace UrbanAreasProject.Controllers
{
    ///<summary>
    ///Get Cities from GeoDBCities and IP Geo Location (API) 
    ///</summary>
    [ApiController]
    [Route("/[controller]/Index")]
    public class CitiesController : Controller
    {
        private readonly GeoDBCitiesClient _cityClient;
        private readonly IPGeoLocationClient _geoLocationClient;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CitiesController(GeoDBCitiesClient cityClient, IPGeoLocationClient geoLocationClient, IHttpContextAccessor httpContextAccessor)
        {
            _cityClient = cityClient;
            _geoLocationClient = geoLocationClient;
            _httpContextAccessor = httpContextAccessor;
        }

        /// <summary>
        /// First Index page
        /// </summary>
        /// <returns>View with information about New York City</returns>
        [HttpGet]
        public async Task<IActionResult> IndexAsync()
        {
            var cities = await _cityClient.GetCityAsync("New York City");
            var result = cities.Data;
            return View("City", result);
        }

        /// <summary>
        /// Search city near city
        /// </summary>
        /// <param name="cityId"></param>
        /// <param name="radius"></param>
        /// <returns>View with information about cities near some city</returns>
        [HttpGet("citynearcity")]
        [Route("/[controller]/CityNearCity")]
        public async Task<IActionResult> GetCityNearCity(string cityId, int radius)
        {
            var cities = await _cityClient.GetCityNearCityAsync(cityId, radius);
            if (cities == null)
                return View("City");
            var result = cities.Data;
            return View("City", result); ;
        }

        /// <summary>
        /// Search city by country id and city name
        /// </summary>
        /// <param name="namePrefixCity"></param>
        /// <param name="nameCountryId"></param>
        /// <returns>View with information about cities</returns>
        [HttpGet("countryid")]
        [Route("/[controller]/CityByNameAndCountry")]
        public async Task<IActionResult> GetCityUsedCuntry(string namePrefixCity, string nameCountryPrefix)
        {
            var cities = await _cityClient.GetCityUsedCountryAsync(namePrefixCity, nameCountryPrefix);
            if (cities==null)
                return View("City");           
            var result = cities.Data;
            return View("City", result); ;
        }

        /// <summary>
        /// Search city by city name
        /// </summary>
        /// <param name="namePrefix"></param>
        /// <returns>View with information about cities</returns>
        [HttpGet("name")]
        [Route("/[controller]/CityByName")]
        public async Task<IActionResult> GetCity(string namePrefix)
        {
            var cities = await _cityClient.GetCityAsync(namePrefix);
            var result = cities.Data;
            return View("City", result);
        }

        /// <summary>
        /// Search city by location
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns>View with information about cities</returns>
        [HttpGet("location")]
        [Route("/[controller]/CityByLocation")]
        public async Task<IActionResult> GetCityByLocation(string latitude, string longitude)
        {
            var cities = await _cityClient.GetCityByLocationAsync(latitude, longitude);
            if (cities == null)
                return View("City");
            var result = cities.Data;
            return View("City", result);
        }

        /// <summary>
        /// Search city by geolocation
        /// </summary>
        /// <returns>View with information about city where user now</returns>
        [HttpGet("geolocation")]
        [Route("/[controller]/CityByGeoLocation")]
        public async Task<IActionResult> GetCityByGeoLocation()
        {
            string ip = _httpContextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();
            var cities = await _geoLocationClient.GetCityGeoLocationAsync(ip);
            if (cities == null)
                return View("City");
            return View("CityGeo", cities);
        }
    }
}
