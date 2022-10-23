﻿using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models.Country
{
    public abstract class BaseCountryDto
    {
        [Required]
        public string CountryName { get; set; }
        public string ShortName { get; set; }
    }
}
