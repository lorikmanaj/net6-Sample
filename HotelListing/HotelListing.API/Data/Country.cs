﻿namespace HotelListing.API.Data
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string ShortName { get; set; }

        public virtual IList<Hotel> Hotels { get; set; }
    }
}
