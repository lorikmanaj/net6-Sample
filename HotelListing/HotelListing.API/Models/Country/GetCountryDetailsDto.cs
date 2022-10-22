using HotelListing.API.Models.Hotel;

namespace HotelListing.API.Models.Country
{
    public class GetCountryDetailsDto : BaseCountryDto
    {
        public int CountryId { get; set; }

        public List<GetHotelDto> Hotels { get; set; }
    }
}
