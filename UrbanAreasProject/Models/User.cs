using Microsoft.AspNetCore.Identity;

namespace UrbanAreasProject.Models
{
    public class User : IdentityUser
    {     
        public string RatingCities { get; set; }
    }
}
