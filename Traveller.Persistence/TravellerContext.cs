using Microsoft.EntityFrameworkCore;
using Traveller.Domain.Models;

namespace Traveller.Persistence;

public class TravellerContext : DbContext
{
    public TravellerContext(DbContextOptions<TravellerContext> options) : base(options)
    {
    }

    public DbSet<Agency> Agencies { get; set; } = null!;

    public DbSet<Flight> Flights { get; set; } = null!;
    public DbSet<FlightOffer> FlightOffers { get; set; } = null!;
    public DbSet<FlightReservation> FlightReservations { get; set; } = null!;
    public DbSet<Hotel> Hotels { get; set; } = null!;
    public DbSet<HotelOffer> HotelOffers { get; set; } = null!;
    public DbSet<HotelReservation> HotelReservations { get; set; } = null!;
    public DbSet<Tour> Tours { get; set; } = null!;
    public DbSet<TourOffer> TourOffers { get; set; } = null!;
    public DbSet<TourReservation> TourReservation { get; set; } = null!;
    public DbSet<Package> Packages { get; set; } = null!;
    public DbSet<PackageOffer> PackageOffers { get; set; } = null!;
    public DbSet<Facility> Facilities { get; set; } = null!;
    public DbSet<PackageFacility> PackageFacility { get; set; } = null!;

    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Tourist> Tourists { get; set; } = null!;
    public DbSet<AgencyUser> AgencyUsers { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var hotels = GenerateHotels();
        var hotelOffers = GenerateHotelOffers();

        modelBuilder.Entity<Hotel>().HasData(hotels);
        modelBuilder.Entity<HotelOffer>().HasData(hotelOffers);

        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TravellerContext).Assembly);
    }

    private static Hotel[] GenerateHotels()
    {
        return new[]
        {
            new Hotel
            {
                Id = 1,
                Name = "The Grand Hotel",
                Address = "123 Main Street, New York, NY",
                Category = Category.FourStars
            },
            new Hotel
            {
                Id = 2,
                Name = "The Ritz Carlton",
                Address = "456 Broadway, Los Angeles, CA",
                Category = Category.ThreeStars
            },
            new Hotel
            {
                Id = 3,
                Name = "The Plaza Hotel",
                Address = "789 Fifth Avenue, New York, NY",
                Category = Category.FiveStars
            },
            new Hotel
            {
                Id = 4,
                Name = "The Waldorf Astoria",
                Address = "321 Park Avenue, New York, NY",
                Category = Category.ThreeStars
            },
            new Hotel
            {
                Id = 5,
                Name = "The Four Seasons",
                Address = "654 Broadway, New York, NY",
                Category = Category.TwoStars
            },
            new Hotel
            {
                Id = 6,
                Name = "The Beverly Wilshire",
                Address = "987 Wilshire Boulevard, Los Angeles, CA",
                Category = Category.FourStars
            },
            new Hotel
            {
                Id = 7,
                Name = "The Ritz-Carlton, Delaire",
                Address = "111 Del Mar Drive, Delaire, DE",
                Category = Category.FiveStars
            },
            new Hotel
            {
                Id = 8,
                Name = "The Ritz-Carlton, Cancun",
                Address = "222 Cancun Drive, Cancun, MX",
                Category = Category.FourStars
            },
            new Hotel
            {
                Id = 9,
                Name = "The Ritz-Carlton, Bangkok",
                Address = "333 Silom Road, Bangkok, TH",
                Category = Category.FiveStars
            },
            new Hotel
            {
                Id = 10,
                Name = "The Ritz-Carlton, St. Thomas",
                Address = "444 St. Thomas Drive, St. Thomas, VI",
                Category = Category.OneStar
            },
            new Hotel
            {
                Id = 11,
                Name = "The Ritz-Carlton, Paris",
                Address = "555 Champs-Elysées, Paris, FR",
                Category = Category.FiveStars
            },
            new Hotel
            {
                Id = 12,
                Name = "The Ritz-Carlton, Rome",
                Address = "666 Via Veneto, Rome, IT",
                Category = Category.FourStars
            },
            new Hotel
            {
                Id = 13,
                Name = "The Ritz-Carlton, Geneva",
                Address = "777 Rue du Rhône, Geneva, CH",
                Category = Category.FiveStars
            },
            new Hotel
            {
                Id = 14,
                Name = "The Ritz-Carlton, San Francisco",
                Address = "888 Union Square, San Francisco, CA",
                Category = Category.FiveStars
            },
            new Hotel
            {
                Id = 15,
                Name = "The Ritz-Carlton, Boston",
                Address = "999 Commonwealth Avenue, Boston, MA",
                Category = Category.ThreeStars
            },
            new Hotel
            {
                Id = 16,
                Name = "The Ritz-Carlton, San Diego",
                Address = "1111 Horton Plaza, San Diego, CA",
                Category = Category.FourStars
            },
            new Hotel
            {
                Id = 17,
                Name = "The Ritz-Carlton, Chicago",
                Address = "2222 Michigan Avenue, Chicago, IL",
                Category = Category.ThreeStars
            },
            new Hotel
            {
                Id = 18,
                Name = "The Ritz-Carlton, Miami",
                Address = "3333 Collins Avenue, Miami, FL",
                Category = Category.OneStar
            },
            new Hotel
            {
                Id = 19,
                Name = "The Ritz-Carlton, Honolulu",
                Address = "4444 Kalakaua Avenue, Honolulu, HI",
                Category = Category.TwoStars
            },
            new Hotel
            {
                Id = 20,
                Name = "The Ritz-Carlton, Orlando",
                Address = "5555 International Drive, Orlando, FL",
                Category = Category.ThreeStars
            },
            new Hotel
            {
                Id = 21,
                Name = "The Ritz-Carlton, Las Vegas",
                Address = "6666 Las Vegas Boulevard South, Las Vegas, NV",
                Category = Category.FourStars
            },
            new Hotel
            {
                Id = 22,
                Name = "The Ritz-Carlton, San Antonio",
                Address = "7777 Commerce Street, San Antonio, TX",
                Category = Category.FiveStars
            },
            new Hotel
            {
                Id = 23,
                Name = "The Ritz-Carlton, Dallas",
                Address = "8888 Market Center Drive, Dallas, TX",
                Category = Category.TwoStars
            },
            new Hotel
            {
                Id = 24,
                Name = "The Ritz-Carlton, Atlanta",
                Address = "9999 Peachtree Street, Atlanta, GA",
                Category = Category.FourStars
            },
            new Hotel
            {
                Id = 25,
                Name = "The Ritz-Carlton, Seattle",
                Address = "11111 University Street, Seattle, WA",
                Category = Category.ThreeStars
            }
        };
    }

    private static readonly List<string> Phrases = new()
    {
        ". Perfect for a romantic weekend.",
        " with a stunning view.",
        " with a private balcony.",
        " with a cozy atmosphere.",
        ". Spacious room with a breathtaking view of the city.",
        " with a cozy atmosphere and a beautiful view.",
        " with a comfortable atmosphere and a stunning view.",
        " with a beautiful view and modern amenities."
    };

    private static readonly List<string> Words = new()
    {
        "Single room",
        "Luxury suite",
        "Deluxe room"
    };

    private static readonly List<string> Phrases2 = new()
    {
        "Enjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.",
        "Experience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.",
        "Our hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.",
        "Welcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.",
        "Discover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.",
        "Our hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.",
        "If you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.",
        "Our hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.",
        "Our hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.",
        "Our hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.",
        "Our hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel."
    };

    private static string GenerateSequentialDescription(int index)
    {
        var word = Words[index % Words.Count];
        var phrase = Phrases[index % Phrases.Count];
        var phrase2 = Phrases2[index % Phrases2.Count];
        return $"Experience the {word}. {phrase}.\n{phrase2}";
    }

    private static readonly Random Random = new();

    private static HotelOffer[] GenerateHotelOffers()
    {
        return Enumerable.Range(1, 500).Select(i => new HotelOffer
        {
            Description = GenerateSequentialDescription(i),
            Price = Random.Next(100, 2000),
            Capacity = Random.Next(1, 10),
            StartDate = DateTime.Now.AddDays(i),
            EndDate = DateTime.Now.AddDays(i + Random.Next(10, 1000)),
            AgencyId = i % 10 + 1,
            ProductId = i % 25 + 1
        }).ToArray();
    }
}