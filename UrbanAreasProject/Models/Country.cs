using System.Collections.Generic;

namespace UrbanAreasProject.Models
{
    public class Country
    {
        public List<DataCountry> Data { get; set; }
    }
    public class DataCountry
    {
        public string WikiDataId { get; set; }
    }
}
