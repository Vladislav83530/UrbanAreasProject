using System.Collections.Generic;

namespace UrbanAreasProject.Models
{
    public class CountryDetails
    {
        public Data Data { get; set; }
    }
    public class Data
    {
        public string Capital { get; set; }
        public string Code { get; set; }
        public string CallingCode { get; set; }
        public string Name { get; set; }
        public int NumRegions { get; set; }
        public string WikiDataId { get; set; }
        public List<string> CurrencyCodes { get; set; }
    }
}
