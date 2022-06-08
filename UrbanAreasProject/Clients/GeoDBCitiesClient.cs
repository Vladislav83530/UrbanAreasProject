using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using UrbanAreasProject.Constant;
using UrbanAreasProject.Models;

namespace UrbanAreasProject.Clients
{
    /// <summary>
    /// Client for GeoDB Cities (API)
    /// </summary>
    public class GeoDBCitiesClient
    {
        private readonly HttpClient _client;
        private static string _address;
        private static string _apikey;
        private readonly HttpRequestMessage _request;
        private readonly HttpRequestMessage _requestClone;
        public GeoDBCitiesClient()
        {
            _address = Constants.address;
            _apikey = Constants.apikey;
            _client = new HttpClient();
            _request = new HttpRequestMessage()
            {
                Headers = { { "X-RapidAPI-Key", _apikey }
              }
            };
            _requestClone = new HttpRequestMessage()
            {
                Headers = { { "X-RapidAPI-Key", _apikey }
               }
            };
        }

        /// <summary>
        /// Search country by country name
        /// </summary>
        /// <param name="nameCountryPrefix"></param>
        /// <returns>Information about countries</returns>
        public async Task<CountryDetails> GetCountryAsync(string nameCountryPrefix)
        {
            _request.RequestUri = new Uri(_address + $"/geo/countries?limit=100&namePrefix={nameCountryPrefix}");
            var response = await _client.SendAsync(_request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Country>(content);
            if (result.Data.Count != 0)
            {
                _requestClone.RequestUri = new Uri(_address + $"/geo/countries/{result.Data.FirstOrDefault().WikiDataId}");
                var response1 = await _client.SendAsync(_requestClone);
                response1.EnsureSuccessStatusCode();
                var content1 = await response1.Content.ReadAsStringAsync();
                var result1 = JsonConvert.DeserializeObject<CountryDetails>(content1);
                return result1;
            }
            return null;
        }

        /// <summary>
        /// Search city near city
        /// </summary>
        /// <param name="cityId"></param>
        /// <param name="radius"></param>
        /// <returns>Infornation about cities</returns>
        public async Task<City> GetCityNearCityAsync(string cityId, int radius)
        {
            _request.RequestUri = new Uri(_address + $"/geo/cities/{cityId}/nearbyCities?radius={radius}&limit=100&distanceUnit=KM&types=CITY");
            var response = await _client.SendAsync(_request);
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<City>(content);
            if (result.Data!= null)
                return result;
            return null;
        }

        /// <summary>
        /// Search city by city name
        /// </summary>
        /// <param name="namePrefix"></param>
        /// <returns>Information about cities</returns>
        public async Task<City> GetCityAsync(string namePrefix)
        {
            int limit = 10;
            _request.RequestUri = new Uri(_address + $"/geo/cities?limit={limit}&namePrefix={namePrefix}&types=CITY");
            var response = await _client.SendAsync(_request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<City>(content);
            return result;
        }

        /// <summary>
        /// Search city by city name and country wikiID
        /// </summary>
        /// <param name="namePrefix"></param>
        /// <param name="nameCountryPrefix"></param>
        /// <returns>Information about cities</returns>
        public async Task<City> GetCityUsedCountryAsync(string namePrefix, string nameCountryPrefix)
        {
            _request.RequestUri = new Uri(_address + $"/geo/countries?limit=100&namePrefix={nameCountryPrefix}");
            var response = await _client.SendAsync(_request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Country>(content);
            if (result.Data.Count != 0)
            {             
                _requestClone.RequestUri = new Uri(_address + $"/geo/cities?limit=100&countryIds={result.Data.FirstOrDefault().WikiDataId}&namePrefix={namePrefix}&types=CITY");
                var response1 = await _client.SendAsync(_requestClone);
                response1.EnsureSuccessStatusCode();
                var content1 = await response1.Content.ReadAsStringAsync();
                var result1 = JsonConvert.DeserializeObject<City>(content1);
                return result1;
            }
            return null;
        }

        /// <summary>
        /// Search city by location
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns>Information about city</returns>
        public async Task<City> GetCityByLocationAsync(string latitude, string longitude)
        {
            string location = $"+{latitude}+{longitude}";
            _request.RequestUri = new Uri(_address + $"/geo/locations/{location}/nearbyCities?radius=10&types=CITY");
            var response = await _client.SendAsync(_request);
            //response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<City>(content);
            if (result.Data!= null)
                return result;
            return null;
        }
    }
}
