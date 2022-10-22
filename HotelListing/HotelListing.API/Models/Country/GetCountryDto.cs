using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.Models.Country
{
    public class GetCountryDto
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
