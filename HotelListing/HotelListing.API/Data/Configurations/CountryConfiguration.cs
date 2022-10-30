using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            //builder.ToTable("");
            builder.HasData(
                new Country
                {
                    CountryId = 1,
                    CountryName = "Kosovo",
                    ShortName = "XK"
                },
                new Country
                {
                    CountryId = 2,
                    CountryName = "United Kingdom",
                    ShortName = "UK"
                },
                new Country
                {
                    CountryId = 3,
                    CountryName = "Germany",
                    ShortName = "GR"
                }
            );
        }
    }
}
