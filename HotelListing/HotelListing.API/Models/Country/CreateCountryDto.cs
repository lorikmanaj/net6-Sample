using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models.Country
{
    public class CreateCountryDto
    {
        [Required]
        public string CountryName { get; set; }
        public string ShortName { get; set; }
    }
}
