using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            //builder.ToTable("");
            builder.HasData(
                new Hotel
                {
                    HotelId = 1,
                    Name = "Hotel 1",
                    Address = "H1 Add",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    HotelId = 2,
                    Name = "Hotel 2",
                    Address = "H2 Add",
                    CountryId = 2,
                    Rating = 3
                },
                new Hotel
                {
                    HotelId = 3,
                    Name = "Hotel 3",
                    Address = "H3 Add",
                    CountryId = 3,
                    Rating = 5
                }
            );
        }
    }
}
