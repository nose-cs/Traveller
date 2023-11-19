using Traveller.Domain.Models;

namespace Traveller.Tools;

public partial class Program
{
    private static readonly Random Random = new();

    private static IEnumerable<HotelOffer> _hotelsOffers = null!;
    private const int HotelOfferCount = 500;

    private static async Task AddHotelOffersAsync()
    {
        _hotelsOffers = GenerateHotelOffers();

        foreach (var hotelOffer in _hotelsOffers)
        {
            await _appDbContext.AddAsync(hotelOffer);
        }
    }

    private static IEnumerable<HotelOffer> GenerateHotelOffers()
    {
        var date = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);

        return Enumerable.Range(1, HotelOfferCount).Select(i =>
        {
            var (title, description) = GenerateSequentialTitleDescription(i);
            return new HotelOffer
            {
                Title = title,
                Description = description,
                Price = Random.Next(100, 2000),
                Capacity = Random.Next(1, 10),
                StartDate = date.AddDays(Random.Next(1, 10)),
                EndDate = date.AddDays(i + Random.Next(10, 1000)),
                AgencyId = i % AgenciesCount + 1,
                ProductId = i % HotelCount + 1
            };
        });
    }

    private static readonly List<string> Title = new()
    {
        "",
        "with a stunning view",
        "with a private balcony",
        "with a cozy atmosphere",
        "with a breathtaking view of the city",
        "with a beautiful view and modern amenities"
    };

    private static readonly List<string> Rooms = new()
    {
        "Single room",
        "Luxury suite",
        "Deluxe room",
        "Standard room",
        "Family room",
        "Junior suite",
        "Executive room",
        "Superior room",
        "Presidential suite",
        "Penthouse suite",
        "Studio suite",
        "Double room",
        "Twin room",
        "Triple room",
        "King room",
        "Queen room"
    };

    private static readonly List<string> Phrases = new()
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
        "Our hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.",
        "Our hotel is a pet-friendly hotel that offers a comfortable and convenient stay. Our rooms are spacious and clean, with plenty of space for your furry friend. Our hotel also has a dog park, a pet spa, and a pet store, where you can pamper your pet. Our hotel is also near many pet-friendly attractions, such as dog parks, pet stores, and pet-friendly restaurants. Book your room now and bring your pet along for the ride.",
        "Our hotel is a romantic hotel that offers a cozy and intimate stay. Our rooms are spacious and elegant, with soft lighting and plush bedding. Our hotel also has a spa, a restaurant, and a bar, where you can enjoy a romantic dinner and drinks. Our hotel is also near many romantic attractions, such as parks, gardens, and beaches. Book your room now and spend a romantic weekend at our hotel.",
        "Our hotel is a luxury hotel that offers a lavish and indulgent stay. Our rooms are spacious and elegant, with plush bedding and soft lighting. Our hotel also has a spa, a restaurant, and a bar, where you can enjoy a gourmet meal and a glass of wine. Our hotel is also near many luxury attractions, such as museums, theaters, and shopping malls. Book your room now and treat yourself to a luxurious stay at our hotel.",
        "Our hotel is a budget hotel that offers a comfortable and affordable stay. Our rooms are clean and cozy, with all the essentials you need. Our hotel also has a restaurant, a bar, and a lounge, where you can enjoy a delicious meal and a refreshing drink. Our hotel is also near many budget attractions, such as parks, museums, and shopping malls. Book your room now and save money on your next trip.",
        "Our hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.",
    };

    private static readonly List<string> Verb = new()
    {
        "Experience a",
        "Enjoy a",
        "Discover a",
        "Relax in a",
        "Escape to a"
    };

    private static (string Title, string Description) GenerateSequentialTitleDescription(int index)
    {
        var phrase = Phrases[index % Phrases.Count];
        var verb = Verb[index % Verb.Count];

        var title = $"{Rooms[index % Rooms.Count]} {Title[index % Title.Count]}";
        var description = $"{verb} {title}.\n{phrase}";

        return (title, description);
    }
}