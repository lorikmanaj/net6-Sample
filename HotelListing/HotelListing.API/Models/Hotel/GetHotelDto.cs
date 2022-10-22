namespace HotelListing.API.Models.Hotel
{
    public class GetHotelDto
    {
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }
        public int CountryId { get; set; }
    }
}
