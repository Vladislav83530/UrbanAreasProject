using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using UrbanAreasProject.Constant;
using UrbanAreasProject.Models;

namespace UrbanAreasProject.Clients
{
    /// <summary>
    /// Client for IP Geo Location (API)
    /// </summary>
    public class IPGeoLocationClient
    {
        private readonly HttpClient _client;
        private static string _address;
        private static string _apikey;
        private readonly HttpRequestMessage _request;

        public IPGeoLocationClient()
        {
            _address = Constants.addressIPGeolocation;
            _apikey = Constants.apikey;
            _client = new HttpClient();
            _request = new HttpRequestMessage()
            {
                Headers = { { "X-RapidAPI-Key", _apikey } }
            };
        }

        /// <summary>
        /// Search city by geolocation
        /// </summary>
        /// <returns>Information about city</returns>
        public async Task<CityGeoLocation> GetCityGeoLocationAsync()
        {
            _request.RequestUri = new Uri(_address + $"/ip/check?format=json&language=en");
            var response = await _client.SendAsync(_request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<CityGeoLocation>(content);
            return result;
        }
    }
}
