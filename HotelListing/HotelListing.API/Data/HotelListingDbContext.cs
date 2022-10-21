using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasData(
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

            modelBuilder.Entity<Hotel>().HasData(
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
