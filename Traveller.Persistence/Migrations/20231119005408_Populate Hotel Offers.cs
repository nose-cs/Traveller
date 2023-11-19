using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Traveller.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class PopulateHotelOffers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Agencies",
                columns: new[] { "Id", "Address", "Email", "Fax", "Name" },
                values: new object[,]
                {
                    { 1, "123 Main Street, New York, NY 10001", "sunshine@travel.com", "+1-800-123-4567", "Sunshine Travel" },
                    { 2, "456 Park Avenue, Los Angeles, CA 90001", "dream@tours.com", "+1-888-987-6543", "Dream Tours" },
                    { 3, "789 Broadway, Chicago, IL 60601", "paradise@holidays.com", "+1-877-765-4321", "Paradise Holidays" },
                    { 4, "101 Market Street, San Francisco, CA 94101", "explorer@adventures.com", "+1-866-543-2109", "Explorer Adventures" },
                    { 5, "202 Main Street, Boston, MA 02101", "star@travel.com", "+1-855-321-0987", "Star Travel" },
                    { 6, "303 Park Avenue, Miami, FL 33101", "wonder@tours.com", "+1-844-210-9876", "Wonder Tours" },
                    { 7, "404 Broadway, Seattle, WA 98101", "bliss@holidays.com", "+1-833-098-7654", "Bliss Holidays" },
                    { 8, "505 Market Street, Denver, CO 80201", "adventure@zone.com", "+1-822-765-4320", "Adventure Zone" },
                    { 9, "606 Main Street, Houston, TX 77001", "sky@travel.com", "+1-811-432-1098", "Sky Travel" },
                    { 10, "707 Park Avenue, Atlanta, GA 30301", "magic@tours.com", "+1-800-109-8765", "Magic Tours" }
                });

            migrationBuilder.InsertData(
                table: "HotelOffers",
                columns: new[] { "Id", "AgencyId", "Capacity", "Description", "EndDate", "Price", "ProductId", "StartDate" },
                values: new object[,]
                {
                    { 1, 2, 6, "Experience the Luxury suite.  with a stunning view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2024, 11, 21, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9467), 1876.0, 2, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9419) },
                    { 2, 3, 4, "Experience the Deluxe room.  with a private balcony..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 8, 30, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9479), 190.0, 3, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9477) },
                    { 3, 4, 6, "Experience the Single room.  with a cozy atmosphere..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 8, 5, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9485), 675.0, 4, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9484) },
                    { 4, 5, 7, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 3, 20, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9522), 1569.0, 5, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9521) },
                    { 5, 6, 1, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 10, 31, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9529), 1299.0, 6, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9527) },
                    { 6, 7, 4, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2024, 2, 8, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9535), 1929.0, 7, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9534) },
                    { 7, 8, 3, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2023, 12, 5, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9541), 690.0, 8, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9540) },
                    { 8, 9, 7, "Experience the Deluxe room. . Perfect for a romantic weekend..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 1, 8, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9547), 316.0, 9, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9546) },
                    { 9, 10, 7, "Experience the Single room.  with a stunning view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 6, 22, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9554), 1206.0, 10, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9552) },
                    { 10, 1, 3, "Experience the Luxury suite.  with a private balcony..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 2, 6, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9560), 1585.0, 11, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9559) },
                    { 11, 2, 5, "Experience the Deluxe room.  with a cozy atmosphere..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2024, 5, 31, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9566), 1707.0, 12, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9564) },
                    { 12, 3, 3, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 1, 30, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9593), 1645.0, 13, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9592) },
                    { 13, 4, 7, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2024, 5, 1, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9599), 113.0, 14, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9598) },
                    { 14, 5, 8, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 5, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9605), 1066.0, 15, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9603) },
                    { 15, 6, 8, "Experience the Single room.  with a beautiful view and modern amenities..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 1, 15, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9610), 1611.0, 16, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9609) },
                    { 16, 7, 2, "Experience the Luxury suite. . Perfect for a romantic weekend..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 3, 10, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9616), 264.0, 17, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9614) },
                    { 17, 8, 6, "Experience the Deluxe room.  with a stunning view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 8, 2, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9621), 968.0, 18, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9620) },
                    { 18, 9, 3, "Experience the Single room.  with a private balcony..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 7, 2, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9627), 436.0, 19, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9625) },
                    { 19, 10, 9, "Experience the Luxury suite.  with a cozy atmosphere..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 7, 20, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9632), 786.0, 20, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9631) },
                    { 20, 1, 6, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2024, 2, 10, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9659), 1080.0, 21, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9658) },
                    { 21, 2, 4, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 2, 7, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9665), 1055.0, 22, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9664) },
                    { 22, 3, 7, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2024, 3, 9, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9671), 1380.0, 23, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9669) },
                    { 23, 4, 1, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2024, 5, 16, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9676), 1423.0, 24, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9675) },
                    { 24, 5, 7, "Experience the Single room. . Perfect for a romantic weekend..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 7, 31, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9682), 494.0, 25, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9680) },
                    { 25, 6, 4, "Experience the Luxury suite.  with a stunning view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 7, 3, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9687), 1984.0, 1, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9686) },
                    { 26, 7, 1, "Experience the Deluxe room.  with a private balcony..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2024, 9, 16, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9693), 691.0, 2, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9691) },
                    { 27, 8, 2, "Experience the Single room.  with a cozy atmosphere..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 3, 14, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9698), 1024.0, 3, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9697) },
                    { 28, 9, 7, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2024, 7, 6, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9726), 905.0, 4, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9725) },
                    { 29, 10, 3, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2024, 6, 25, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9732), 192.0, 5, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9731) },
                    { 30, 1, 6, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2024, 1, 3, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9738), 498.0, 6, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9736) },
                    { 31, 2, 9, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 2, 9, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9743), 1235.0, 7, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9741) },
                    { 32, 3, 7, "Experience the Deluxe room. . Perfect for a romantic weekend..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2024, 8, 6, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9748), 1457.0, 8, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9747) },
                    { 33, 4, 7, "Experience the Single room.  with a stunning view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 6, 4, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9754), 1705.0, 9, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9752) },
                    { 34, 5, 9, "Experience the Luxury suite.  with a private balcony..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 3, 4, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9759), 388.0, 10, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9758) },
                    { 35, 6, 6, "Experience the Deluxe room.  with a cozy atmosphere..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 8, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9765), 156.0, 11, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9763) },
                    { 36, 7, 7, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 7, 20, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9791), 1918.0, 12, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9790) },
                    { 37, 8, 9, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 2, 2, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9797), 1637.0, 13, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9795) },
                    { 38, 9, 9, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 9, 14, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9805), 881.0, 14, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9804) },
                    { 39, 10, 8, "Experience the Single room.  with a beautiful view and modern amenities..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 2, 23, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9811), 1071.0, 15, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9809) },
                    { 40, 1, 3, "Experience the Luxury suite. . Perfect for a romantic weekend..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 6, 8, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9817), 1067.0, 16, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9815) },
                    { 41, 2, 7, "Experience the Deluxe room.  with a stunning view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 10, 16, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9822), 147.0, 17, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9821) },
                    { 42, 3, 1, "Experience the Single room.  with a private balcony..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 2, 1, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9828), 141.0, 18, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9826) },
                    { 43, 4, 3, "Experience the Luxury suite.  with a cozy atmosphere..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 2, 17, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9833), 934.0, 19, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9832) },
                    { 44, 5, 3, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 9, 14, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9862), 1950.0, 20, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9861) },
                    { 45, 6, 2, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 10, 4, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9868), 1926.0, 21, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9866) },
                    { 46, 7, 6, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2024, 5, 4, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9873), 844.0, 22, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9872) },
                    { 47, 8, 1, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 8, 19, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9879), 1416.0, 23, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9877) },
                    { 48, 9, 6, "Experience the Single room. . Perfect for a romantic weekend..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2024, 4, 13, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9884), 968.0, 24, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9883) },
                    { 49, 10, 7, "Experience the Luxury suite.  with a stunning view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 3, 3, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9890), 448.0, 25, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9888) },
                    { 50, 1, 1, "Experience the Deluxe room.  with a private balcony..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 12, 23, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9895), 1571.0, 1, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9894) },
                    { 51, 2, 2, "Experience the Single room.  with a cozy atmosphere..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 6, 17, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9901), 722.0, 2, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9899) },
                    { 52, 3, 4, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 6, 11, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9928), 792.0, 3, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9926) },
                    { 53, 4, 7, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 9, 6, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9933), 1620.0, 4, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9932) },
                    { 54, 5, 4, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 1, 24, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9939), 1610.0, 5, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9937) },
                    { 55, 6, 3, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 2, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9944), 564.0, 6, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9943) },
                    { 56, 7, 8, "Experience the Deluxe room. . Perfect for a romantic weekend..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 8, 9, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9950), 157.0, 7, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9948) },
                    { 57, 8, 6, "Experience the Single room.  with a stunning view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2024, 10, 13, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9955), 775.0, 8, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9953) },
                    { 58, 9, 5, "Experience the Luxury suite.  with a private balcony..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2024, 5, 14, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9960), 1611.0, 9, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9959) },
                    { 59, 10, 6, "Experience the Deluxe room.  with a cozy atmosphere..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 3, 30, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9966), 1111.0, 10, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9965) },
                    { 60, 1, 8, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 6, 23, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9972), 917.0, 11, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9970) },
                    { 61, 2, 2, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 11, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(11), 1236.0, 12, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(9) },
                    { 62, 3, 5, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 8, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(17), 1998.0, 13, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(16) },
                    { 63, 4, 5, "Experience the Single room.  with a beautiful view and modern amenities..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 8, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(23), 1632.0, 14, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(21) },
                    { 64, 5, 3, "Experience the Luxury suite. . Perfect for a romantic weekend..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2024, 6, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(28), 776.0, 15, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(27) },
                    { 65, 6, 2, "Experience the Deluxe room.  with a stunning view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 3, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(34), 441.0, 16, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(32) },
                    { 66, 7, 4, "Experience the Single room.  with a private balcony..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 1, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(39), 558.0, 17, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(38) },
                    { 67, 8, 7, "Experience the Luxury suite.  with a cozy atmosphere..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 7, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(45), 1209.0, 18, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(44) },
                    { 68, 9, 6, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 6, 5, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(50), 1333.0, 19, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(49) },
                    { 69, 10, 7, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2024, 6, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(77), 545.0, 20, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(76) },
                    { 70, 1, 6, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 10, 2, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(83), 317.0, 21, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(82) },
                    { 71, 2, 7, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 4, 12, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(89), 1725.0, 22, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(87) },
                    { 72, 3, 4, "Experience the Single room. . Perfect for a romantic weekend..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 11, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(94), 1979.0, 23, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(93) },
                    { 73, 4, 3, "Experience the Luxury suite.  with a stunning view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 7, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(100), 316.0, 24, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(98) },
                    { 74, 5, 2, "Experience the Deluxe room.  with a private balcony..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 8, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(105), 1427.0, 25, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(104) },
                    { 75, 6, 9, "Experience the Single room.  with a cozy atmosphere..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 2, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(111), 1979.0, 1, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(109) },
                    { 76, 7, 7, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 8, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(116), 1501.0, 2, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(115) },
                    { 77, 8, 1, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 6, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(144), 473.0, 3, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(143) },
                    { 78, 9, 3, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 6, 5, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(150), 1162.0, 4, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(148) },
                    { 79, 10, 4, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 5, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(155), 1416.0, 5, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(154) },
                    { 80, 1, 2, "Experience the Deluxe room. . Perfect for a romantic weekend..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2024, 8, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(160), 976.0, 6, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(159) },
                    { 81, 2, 5, "Experience the Single room.  with a stunning view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 2, 12, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(166), 1601.0, 7, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(164) },
                    { 82, 3, 6, "Experience the Luxury suite.  with a private balcony..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 3, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(171), 471.0, 8, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(170) },
                    { 83, 4, 1, "Experience the Deluxe room.  with a cozy atmosphere..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 4, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(177), 1061.0, 9, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(175) },
                    { 84, 5, 6, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2024, 10, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(182), 1441.0, 10, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(181) },
                    { 85, 6, 1, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 3, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(209), 1834.0, 11, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(207) },
                    { 86, 7, 9, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 10, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(215), 1306.0, 12, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(213) },
                    { 87, 8, 9, "Experience the Single room.  with a beautiful view and modern amenities..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2024, 10, 14, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(220), 1405.0, 13, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(219) },
                    { 88, 9, 4, "Experience the Luxury suite. . Perfect for a romantic weekend..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 12, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(226), 195.0, 14, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(224) },
                    { 89, 10, 9, "Experience the Deluxe room.  with a stunning view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 10, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(231), 772.0, 15, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(230) },
                    { 90, 1, 1, "Experience the Single room.  with a private balcony..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 5, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(237), 114.0, 16, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(235) },
                    { 91, 2, 3, "Experience the Luxury suite.  with a cozy atmosphere..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2024, 10, 2, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(242), 282.0, 17, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(241) },
                    { 92, 3, 1, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 2, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(247), 145.0, 18, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(246) },
                    { 93, 4, 2, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 10, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(276), 349.0, 19, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(274) },
                    { 94, 5, 9, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2024, 12, 17, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(282), 1087.0, 20, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(280) },
                    { 95, 6, 3, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 11, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(287), 1585.0, 21, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(286) },
                    { 96, 7, 6, "Experience the Single room. . Perfect for a romantic weekend..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2024, 10, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(293), 1409.0, 22, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(291) },
                    { 97, 8, 3, "Experience the Luxury suite.  with a stunning view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 6, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(298), 1383.0, 23, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(297) },
                    { 98, 9, 7, "Experience the Deluxe room.  with a private balcony..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 9, 14, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(303), 881.0, 24, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(302) },
                    { 99, 10, 5, "Experience the Single room.  with a cozy atmosphere..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 4, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(309), 1484.0, 25, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(307) },
                    { 100, 1, 4, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 8, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(314), 1306.0, 1, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(313) },
                    { 101, 2, 3, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 6, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(320), 1336.0, 2, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(318) },
                    { 102, 3, 8, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 7, 24, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(347), 1077.0, 3, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(345) },
                    { 103, 4, 9, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 8, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(353), 1740.0, 4, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(351) },
                    { 104, 5, 1, "Experience the Deluxe room. . Perfect for a romantic weekend..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2024, 5, 17, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(358), 1518.0, 5, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(357) },
                    { 105, 6, 7, "Experience the Single room.  with a stunning view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2024, 11, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(363), 840.0, 6, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(362) },
                    { 106, 7, 4, "Experience the Luxury suite.  with a private balcony..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 7, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(369), 108.0, 7, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(367) },
                    { 107, 8, 7, "Experience the Deluxe room.  with a cozy atmosphere..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 9, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(374), 1979.0, 8, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(373) },
                    { 108, 9, 3, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 10, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(379), 1594.0, 9, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(378) },
                    { 109, 10, 9, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2024, 7, 17, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(408), 1977.0, 10, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(407) },
                    { 110, 1, 8, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 3, 13, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(414), 1522.0, 11, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(412) },
                    { 111, 2, 3, "Experience the Single room.  with a beautiful view and modern amenities..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 3, 4, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(419), 370.0, 12, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(418) },
                    { 112, 3, 1, "Experience the Luxury suite. . Perfect for a romantic weekend..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 12, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(425), 515.0, 13, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(423) },
                    { 113, 4, 7, "Experience the Deluxe room.  with a stunning view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 6, 4, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(430), 286.0, 14, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(429) },
                    { 114, 5, 3, "Experience the Single room.  with a private balcony..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2024, 11, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(436), 1636.0, 15, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(434) },
                    { 115, 6, 9, "Experience the Luxury suite.  with a cozy atmosphere..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 6, 17, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(441), 1693.0, 16, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(440) },
                    { 116, 7, 6, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2024, 4, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(447), 1155.0, 17, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(445) },
                    { 117, 8, 6, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2024, 11, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(452), 1738.0, 18, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(450) },
                    { 118, 9, 5, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 1, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(480), 1588.0, 19, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(478) },
                    { 119, 10, 7, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2024, 9, 4, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(485), 373.0, 20, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(484) },
                    { 120, 1, 4, "Experience the Single room. . Perfect for a romantic weekend..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 9, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(491), 964.0, 21, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(489) },
                    { 121, 2, 7, "Experience the Luxury suite.  with a stunning view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2024, 7, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(496), 291.0, 22, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(494) },
                    { 122, 3, 8, "Experience the Deluxe room.  with a private balcony..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2024, 8, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(501), 713.0, 23, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(500) },
                    { 123, 4, 8, "Experience the Single room.  with a cozy atmosphere..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 1, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(507), 1617.0, 24, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(505) },
                    { 124, 5, 5, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 10, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(512), 519.0, 25, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(511) },
                    { 125, 6, 1, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2024, 12, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(517), 528.0, 1, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(516) },
                    { 126, 7, 5, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 7, 12, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(554), 956.0, 2, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(553) },
                    { 127, 8, 4, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 10, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(560), 1670.0, 3, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(559) },
                    { 128, 9, 6, "Experience the Deluxe room. . Perfect for a romantic weekend..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 6, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(566), 1174.0, 4, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(564) },
                    { 129, 10, 4, "Experience the Single room.  with a stunning view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 12, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(571), 1412.0, 5, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(570) },
                    { 130, 1, 8, "Experience the Luxury suite.  with a private balcony..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 5, 31, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(576), 1069.0, 6, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(575) },
                    { 131, 2, 9, "Experience the Deluxe room.  with a cozy atmosphere..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 8, 13, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(582), 1542.0, 7, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(580) },
                    { 132, 3, 2, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 11, 24, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(587), 1196.0, 8, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(586) },
                    { 133, 4, 6, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 3, 12, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(593), 1367.0, 9, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(591) },
                    { 134, 5, 7, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2024, 7, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(620), 1058.0, 10, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(619) },
                    { 135, 6, 8, "Experience the Single room.  with a beautiful view and modern amenities..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2024, 8, 9, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(626), 757.0, 11, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(625) },
                    { 136, 7, 1, "Experience the Luxury suite. . Perfect for a romantic weekend..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 9, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(632), 281.0, 12, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(630) },
                    { 137, 8, 2, "Experience the Deluxe room.  with a stunning view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 7, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(637), 846.0, 13, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(635) },
                    { 138, 9, 1, "Experience the Single room.  with a private balcony..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2024, 7, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(642), 549.0, 14, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(641) },
                    { 139, 10, 2, "Experience the Luxury suite.  with a cozy atmosphere..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 5, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(648), 1281.0, 15, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(646) },
                    { 140, 1, 9, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 10, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(653), 1468.0, 16, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(652) },
                    { 141, 2, 9, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2024, 9, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(658), 1648.0, 17, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(657) },
                    { 142, 3, 8, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 8, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(690), 1325.0, 18, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(688) },
                    { 143, 4, 1, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 12, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(695), 1615.0, 19, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(694) },
                    { 144, 5, 6, "Experience the Single room. . Perfect for a romantic weekend..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2024, 9, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(700), 1301.0, 20, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(699) },
                    { 145, 6, 9, "Experience the Luxury suite.  with a stunning view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 5, 3, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(706), 1770.0, 21, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(704) },
                    { 146, 7, 1, "Experience the Deluxe room.  with a private balcony..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 12, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(711), 1694.0, 22, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(710) },
                    { 147, 8, 2, "Experience the Single room.  with a cozy atmosphere..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 7, 26, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(721), 999.0, 23, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(719) },
                    { 148, 9, 8, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2024, 10, 3, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(729), 133.0, 24, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(727) },
                    { 149, 10, 5, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2027, 1, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(737), 1165.0, 25, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(735) },
                    { 150, 1, 1, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 2, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(778), 265.0, 1, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(775) },
                    { 151, 2, 4, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 2, 17, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(786), 1869.0, 2, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(784) },
                    { 152, 3, 2, "Experience the Deluxe room. . Perfect for a romantic weekend..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 11, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(793), 168.0, 3, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(791) },
                    { 153, 4, 7, "Experience the Single room.  with a stunning view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 9, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(801), 991.0, 4, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(799) },
                    { 154, 5, 1, "Experience the Luxury suite.  with a private balcony..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 6, 20, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(809), 449.0, 5, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(807) },
                    { 155, 6, 1, "Experience the Deluxe room.  with a cozy atmosphere..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 11, 12, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(817), 737.0, 6, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(814) },
                    { 156, 7, 7, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 12, 20, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(825), 1036.0, 7, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(823) },
                    { 157, 8, 2, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 10, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(833), 593.0, 8, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(831) },
                    { 158, 9, 7, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 11, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(841), 1989.0, 9, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(839) },
                    { 159, 10, 5, "Experience the Single room.  with a beautiful view and modern amenities..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 6, 9, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(877), 1807.0, 10, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(875) },
                    { 160, 1, 3, "Experience the Luxury suite. . Perfect for a romantic weekend..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 5, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(885), 400.0, 11, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(883) },
                    { 161, 2, 1, "Experience the Deluxe room.  with a stunning view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 1, 31, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(893), 408.0, 12, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(891) },
                    { 162, 3, 1, "Experience the Single room.  with a private balcony..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2024, 7, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(900), 1452.0, 13, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(899) },
                    { 163, 4, 8, "Experience the Luxury suite.  with a cozy atmosphere..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 9, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(907), 1095.0, 14, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(905) },
                    { 164, 5, 4, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2024, 12, 3, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(914), 607.0, 15, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(912) },
                    { 165, 6, 5, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2024, 6, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(921), 1916.0, 16, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(919) },
                    { 166, 7, 7, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 4, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(927), 789.0, 17, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(925) },
                    { 167, 8, 9, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 3, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(961), 823.0, 18, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(959) },
                    { 168, 9, 7, "Experience the Single room. . Perfect for a romantic weekend..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 11, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(968), 1637.0, 19, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(966) },
                    { 169, 10, 7, "Experience the Luxury suite.  with a stunning view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 5, 12, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(975), 1178.0, 20, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(973) },
                    { 170, 1, 9, "Experience the Deluxe room.  with a private balcony..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 1, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(982), 1493.0, 21, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(980) },
                    { 171, 2, 6, "Experience the Single room.  with a cozy atmosphere..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 6, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(989), 844.0, 22, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(987) },
                    { 172, 3, 9, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 5, 12, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(994), 663.0, 23, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(993) },
                    { 173, 4, 5, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 4, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(999), 270.0, 24, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(998) },
                    { 174, 5, 8, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2024, 7, 3, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1005), 1483.0, 25, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1003) },
                    { 175, 6, 9, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 1, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1031), 343.0, 1, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1030) },
                    { 176, 7, 3, "Experience the Deluxe room. . Perfect for a romantic weekend..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 11, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1037), 1448.0, 2, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1035) },
                    { 177, 8, 4, "Experience the Single room.  with a stunning view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 11, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1042), 312.0, 3, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1040) },
                    { 178, 9, 5, "Experience the Luxury suite.  with a private balcony..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 4, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1047), 353.0, 4, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1046) },
                    { 179, 10, 6, "Experience the Deluxe room.  with a cozy atmosphere..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2024, 10, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1052), 1091.0, 5, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1051) },
                    { 180, 1, 8, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2027, 1, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1058), 1822.0, 6, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1056) },
                    { 181, 2, 2, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2024, 6, 2, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1063), 1475.0, 7, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1062) },
                    { 182, 3, 1, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 10, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1068), 1654.0, 8, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1067) },
                    { 183, 4, 5, "Experience the Single room.  with a beautiful view and modern amenities..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2024, 9, 19, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1095), 965.0, 9, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1094) },
                    { 184, 5, 9, "Experience the Luxury suite. . Perfect for a romantic weekend..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 10, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1101), 1466.0, 10, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1100) },
                    { 185, 6, 8, "Experience the Deluxe room.  with a stunning view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 10, 2, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1107), 875.0, 11, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1105) },
                    { 186, 7, 8, "Experience the Single room.  with a private balcony..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 5, 4, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1112), 559.0, 12, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1111) },
                    { 187, 8, 3, "Experience the Luxury suite.  with a cozy atmosphere..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2024, 9, 5, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1117), 1764.0, 13, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1116) },
                    { 188, 9, 3, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 3, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1123), 1078.0, 14, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1121) },
                    { 189, 10, 2, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 8, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1128), 1694.0, 15, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1126) },
                    { 190, 1, 9, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2024, 11, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1133), 329.0, 16, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1132) },
                    { 191, 2, 2, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 4, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1203), 703.0, 17, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1202) },
                    { 192, 3, 1, "Experience the Single room. . Perfect for a romantic weekend..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 11, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1209), 1360.0, 18, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1208) },
                    { 193, 4, 7, "Experience the Luxury suite.  with a stunning view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2024, 10, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1214), 863.0, 19, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1213) },
                    { 194, 5, 8, "Experience the Deluxe room.  with a private balcony..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2024, 10, 19, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1220), 1091.0, 20, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1218) },
                    { 195, 6, 7, "Experience the Single room.  with a cozy atmosphere..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 1, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1225), 822.0, 21, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1224) },
                    { 196, 7, 4, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 7, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1231), 1304.0, 22, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1229) },
                    { 197, 8, 3, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2027, 2, 17, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1236), 542.0, 23, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1235) },
                    { 198, 9, 7, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 7, 9, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1242), 925.0, 24, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1240) },
                    { 199, 10, 8, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 1, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1279), 421.0, 25, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1278) },
                    { 200, 1, 5, "Experience the Deluxe room. . Perfect for a romantic weekend..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 12, 31, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1285), 201.0, 1, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1284) },
                    { 201, 2, 1, "Experience the Single room.  with a stunning view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 9, 3, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1290), 1511.0, 2, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1289) },
                    { 202, 3, 8, "Experience the Luxury suite.  with a private balcony..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 5, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1296), 1034.0, 3, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1294) },
                    { 203, 4, 8, "Experience the Deluxe room.  with a cozy atmosphere..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 10, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1301), 144.0, 4, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1300) },
                    { 204, 5, 9, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2024, 11, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1306), 1059.0, 5, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1305) },
                    { 205, 6, 9, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 3, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1312), 891.0, 6, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1310) },
                    { 206, 7, 9, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2024, 9, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1317), 880.0, 7, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1316) },
                    { 207, 8, 4, "Experience the Single room.  with a beautiful view and modern amenities..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 7, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1349), 1157.0, 8, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1347) },
                    { 208, 9, 9, "Experience the Luxury suite. . Perfect for a romantic weekend..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 12, 20, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1354), 1782.0, 9, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1353) },
                    { 209, 10, 3, "Experience the Deluxe room.  with a stunning view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2027, 2, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1359), 1025.0, 10, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1358) },
                    { 210, 1, 6, "Experience the Single room.  with a private balcony..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 8, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1365), 1640.0, 11, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1363) },
                    { 211, 2, 8, "Experience the Luxury suite.  with a cozy atmosphere..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 10, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1370), 574.0, 12, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1369) },
                    { 212, 3, 7, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 2, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1375), 1665.0, 13, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1374) },
                    { 213, 4, 1, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2024, 11, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1381), 1111.0, 14, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1379) },
                    { 214, 5, 8, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 12, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1386), 1434.0, 15, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1385) },
                    { 215, 6, 7, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2024, 7, 17, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1412), 486.0, 16, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1411) },
                    { 216, 7, 1, "Experience the Single room. . Perfect for a romantic weekend..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 10, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1418), 1377.0, 17, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1416) },
                    { 217, 8, 9, "Experience the Luxury suite.  with a stunning view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 8, 3, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1423), 1874.0, 18, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1421) },
                    { 218, 9, 7, "Experience the Deluxe room.  with a private balcony..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2024, 7, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1428), 181.0, 19, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1427) },
                    { 219, 10, 2, "Experience the Single room.  with a cozy atmosphere..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 5, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1433), 1450.0, 20, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1432) },
                    { 220, 1, 5, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 12, 9, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1439), 676.0, 21, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1437) },
                    { 221, 2, 1, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 11, 2, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1444), 472.0, 22, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1442) },
                    { 222, 3, 8, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 9, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1449), 1307.0, 23, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1448) },
                    { 223, 4, 7, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2027, 1, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1475), 1097.0, 24, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1474) },
                    { 224, 5, 7, "Experience the Deluxe room. . Perfect for a romantic weekend..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 7, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1481), 126.0, 25, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1480) },
                    { 225, 6, 9, "Experience the Single room.  with a stunning view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 5, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1486), 543.0, 1, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1485) },
                    { 226, 7, 1, "Experience the Luxury suite.  with a private balcony..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 3, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1491), 1988.0, 2, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1490) },
                    { 227, 8, 7, "Experience the Deluxe room.  with a cozy atmosphere..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 1, 9, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1497), 576.0, 3, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1495) },
                    { 228, 9, 8, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 4, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1502), 1949.0, 4, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1501) },
                    { 229, 10, 5, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 4, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1507), 746.0, 5, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1506) },
                    { 230, 1, 2, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 10, 24, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1513), 353.0, 6, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1511) },
                    { 231, 2, 4, "Experience the Single room.  with a beautiful view and modern amenities..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 11, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1542), 1050.0, 7, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1540) },
                    { 232, 3, 7, "Experience the Luxury suite. . Perfect for a romantic weekend..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 2, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1548), 1505.0, 8, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1546) },
                    { 233, 4, 6, "Experience the Deluxe room.  with a stunning view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 3, 24, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1553), 463.0, 9, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1551) },
                    { 234, 5, 7, "Experience the Single room.  with a private balcony..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 9, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1558), 1720.0, 10, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1557) },
                    { 235, 6, 6, "Experience the Luxury suite.  with a cozy atmosphere..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 3, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1564), 1361.0, 11, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1562) },
                    { 236, 7, 5, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2027, 3, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1569), 113.0, 12, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1568) },
                    { 237, 8, 9, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 8, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1574), 1106.0, 13, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1573) },
                    { 238, 9, 3, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 6, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1580), 1439.0, 14, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1578) },
                    { 239, 10, 4, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 3, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1609), 1658.0, 15, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1607) },
                    { 240, 1, 3, "Experience the Single room. . Perfect for a romantic weekend..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 1, 13, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1614), 1866.0, 16, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1613) },
                    { 241, 2, 2, "Experience the Luxury suite.  with a stunning view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 1, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1620), 1023.0, 17, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1618) },
                    { 242, 3, 7, "Experience the Deluxe room.  with a private balcony..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 6, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1625), 217.0, 18, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1623) },
                    { 243, 4, 9, "Experience the Single room.  with a cozy atmosphere..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 8, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1630), 338.0, 19, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1628) },
                    { 244, 5, 5, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 7, 4, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1635), 264.0, 20, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1634) },
                    { 245, 6, 7, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2027, 4, 5, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1641), 1728.0, 21, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1639) },
                    { 246, 7, 2, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2024, 8, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1646), 1616.0, 22, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1645) },
                    { 247, 8, 7, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 7, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1651), 1167.0, 23, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1650) },
                    { 248, 9, 4, "Experience the Deluxe room. . Perfect for a romantic weekend..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 7, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1681), 370.0, 24, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1679) },
                    { 249, 10, 9, "Experience the Single room.  with a stunning view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 7, 24, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1687), 1556.0, 25, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1685) },
                    { 250, 1, 5, "Experience the Luxury suite.  with a private balcony..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 1, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1692), 269.0, 1, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1691) },
                    { 251, 2, 7, "Experience the Deluxe room.  with a cozy atmosphere..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 10, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1697), 1998.0, 2, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1696) },
                    { 252, 3, 7, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 12, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1703), 114.0, 3, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1701) },
                    { 253, 4, 6, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 5, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1708), 697.0, 4, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1706) },
                    { 254, 5, 6, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 12, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1713), 352.0, 5, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1712) },
                    { 255, 6, 1, "Experience the Single room.  with a beautiful view and modern amenities..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 6, 19, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1718), 1820.0, 6, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1717) },
                    { 256, 7, 3, "Experience the Luxury suite. . Perfect for a romantic weekend..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 3, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1749), 1362.0, 7, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1748) },
                    { 257, 8, 7, "Experience the Deluxe room.  with a stunning view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 9, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1755), 718.0, 8, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1753) },
                    { 258, 9, 7, "Experience the Single room.  with a private balcony..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 5, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1760), 1619.0, 9, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1758) },
                    { 259, 10, 9, "Experience the Luxury suite.  with a cozy atmosphere..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 9, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1765), 238.0, 10, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1764) },
                    { 260, 1, 6, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 8, 2, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1770), 1916.0, 11, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1769) },
                    { 261, 2, 1, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 5, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1776), 1771.0, 12, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1774) },
                    { 262, 3, 8, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2024, 8, 19, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1781), 1106.0, 13, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1780) },
                    { 263, 4, 3, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 1, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1786), 1032.0, 14, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1785) },
                    { 264, 5, 2, "Experience the Single room. . Perfect for a romantic weekend..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 4, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1823), 928.0, 15, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1821) },
                    { 265, 6, 8, "Experience the Luxury suite.  with a stunning view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2027, 3, 26, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1828), 1170.0, 16, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1827) },
                    { 266, 7, 6, "Experience the Deluxe room.  with a private balcony..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 7, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1833), 1931.0, 17, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1832) },
                    { 267, 8, 3, "Experience the Single room.  with a cozy atmosphere..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2024, 9, 5, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1839), 294.0, 18, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1837) },
                    { 268, 9, 3, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 5, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1844), 937.0, 19, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1842) },
                    { 269, 10, 9, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2027, 3, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1849), 950.0, 20, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1848) },
                    { 270, 1, 9, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2027, 3, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1855), 1713.0, 21, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1853) },
                    { 271, 2, 3, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 1, 24, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1860), 1793.0, 22, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1859) },
                    { 272, 3, 2, "Experience the Deluxe room. . Perfect for a romantic weekend..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 4, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1890), 277.0, 23, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1888) },
                    { 273, 4, 1, "Experience the Single room.  with a stunning view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 7, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1895), 917.0, 24, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1894) },
                    { 274, 5, 8, "Experience the Luxury suite.  with a private balcony..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2024, 12, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1901), 939.0, 25, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1899) },
                    { 275, 6, 1, "Experience the Deluxe room.  with a cozy atmosphere..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 12, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1906), 980.0, 1, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1904) },
                    { 276, 7, 9, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 1, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1911), 982.0, 2, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1910) },
                    { 277, 8, 2, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2024, 10, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1916), 1553.0, 3, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1915) },
                    { 278, 9, 7, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 10, 26, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1921), 1392.0, 4, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1920) },
                    { 279, 10, 3, "Experience the Single room.  with a beautiful view and modern amenities..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 7, 9, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1927), 1756.0, 5, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1925) },
                    { 280, 1, 6, "Experience the Luxury suite. . Perfect for a romantic weekend..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 12, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1953), 453.0, 6, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1952) },
                    { 281, 2, 2, "Experience the Deluxe room.  with a stunning view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 1, 19, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1959), 711.0, 7, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1958) },
                    { 282, 3, 7, "Experience the Single room.  with a private balcony..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2027, 5, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1965), 130.0, 8, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1963) },
                    { 283, 4, 9, "Experience the Luxury suite.  with a cozy atmosphere..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 10, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1970), 1470.0, 9, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1969) },
                    { 284, 5, 6, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 11, 20, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1975), 333.0, 10, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1974) },
                    { 285, 6, 1, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 3, 4, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1981), 1174.0, 11, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1979) },
                    { 286, 7, 8, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2024, 11, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1986), 776.0, 12, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1984) },
                    { 287, 8, 6, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 11, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1991), 515.0, 13, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1990) },
                    { 288, 9, 9, "Experience the Single room. . Perfect for a romantic weekend..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 7, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1997), 1555.0, 14, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1995) },
                    { 289, 10, 6, "Experience the Luxury suite.  with a stunning view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 12, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2022), 431.0, 15, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2021) },
                    { 290, 1, 3, "Experience the Deluxe room.  with a private balcony..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 2, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2028), 190.0, 16, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2026) },
                    { 291, 2, 1, "Experience the Single room.  with a cozy atmosphere..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 7, 24, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2033), 1341.0, 17, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2032) },
                    { 292, 3, 7, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2024, 12, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2038), 479.0, 18, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2037) },
                    { 293, 4, 1, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 8, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2044), 853.0, 19, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2042) },
                    { 294, 5, 7, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2027, 5, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2049), 1373.0, 20, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2048) },
                    { 295, 6, 4, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 7, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2054), 1555.0, 21, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2053) },
                    { 296, 7, 7, "Experience the Deluxe room. . Perfect for a romantic weekend..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2027, 1, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2081), 1095.0, 22, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2079) },
                    { 297, 8, 8, "Experience the Single room.  with a stunning view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 3, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2086), 306.0, 23, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2085) },
                    { 298, 9, 8, "Experience the Luxury suite.  with a private balcony..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 12, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2091), 941.0, 24, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2090) },
                    { 299, 10, 4, "Experience the Deluxe room.  with a cozy atmosphere..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 1, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2097), 1165.0, 25, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2095) },
                    { 300, 1, 9, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 10, 20, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2102), 1485.0, 1, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2100) },
                    { 301, 2, 2, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2024, 12, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2107), 731.0, 2, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2106) },
                    { 302, 3, 7, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 7, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2112), 739.0, 3, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2111) },
                    { 303, 4, 9, "Experience the Single room.  with a beautiful view and modern amenities..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 8, 14, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2118), 392.0, 4, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2116) },
                    { 304, 5, 2, "Experience the Luxury suite. . Perfect for a romantic weekend..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2027, 2, 19, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2123), 976.0, 5, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2122) },
                    { 305, 6, 6, "Experience the Deluxe room.  with a stunning view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 9, 12, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2151), 374.0, 6, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2149) },
                    { 306, 7, 9, "Experience the Single room.  with a private balcony..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 4, 5, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2156), 928.0, 7, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2155) },
                    { 307, 8, 6, "Experience the Luxury suite.  with a cozy atmosphere..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 4, 24, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2161), 1454.0, 8, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2160) },
                    { 308, 9, 3, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 10, 14, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2167), 484.0, 9, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2165) },
                    { 309, 10, 2, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 2, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2172), 573.0, 10, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2170) },
                    { 310, 1, 4, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 4, 24, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2177), 800.0, 11, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2176) },
                    { 311, 2, 5, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 7, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2182), 712.0, 12, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2181) },
                    { 312, 3, 1, "Experience the Single room. . Perfect for a romantic weekend..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2027, 4, 19, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2188), 1681.0, 13, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2186) },
                    { 313, 4, 6, "Experience the Luxury suite.  with a stunning view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 1, 3, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2219), 595.0, 14, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2217) },
                    { 314, 5, 7, "Experience the Deluxe room.  with a private balcony..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 4, 13, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2224), 450.0, 15, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2223) },
                    { 315, 6, 1, "Experience the Single room.  with a cozy atmosphere..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 5, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2230), 774.0, 16, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2228) },
                    { 316, 7, 3, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2027, 4, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2235), 1882.0, 17, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2233) },
                    { 317, 8, 1, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 5, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2240), 1448.0, 18, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2239) },
                    { 318, 9, 4, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 3, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2245), 133.0, 19, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2244) },
                    { 319, 10, 6, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2027, 1, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2251), 893.0, 20, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2249) },
                    { 320, 1, 2, "Experience the Deluxe room. . Perfect for a romantic weekend..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2027, 6, 17, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2256), 255.0, 21, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2254) },
                    { 321, 2, 8, "Experience the Single room.  with a stunning view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 4, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2287), 1410.0, 22, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2285) },
                    { 322, 3, 8, "Experience the Luxury suite.  with a private balcony..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 7, 20, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2292), 241.0, 23, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2291) },
                    { 323, 4, 5, "Experience the Deluxe room.  with a cozy atmosphere..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 4, 5, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2297), 1907.0, 24, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2296) },
                    { 324, 5, 5, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2027, 6, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2303), 811.0, 25, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2301) },
                    { 325, 6, 3, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 7, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2308), 399.0, 1, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2307) },
                    { 326, 7, 5, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 8, 26, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2313), 682.0, 2, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2312) },
                    { 327, 8, 7, "Experience the Single room.  with a beautiful view and modern amenities..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 9, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2319), 836.0, 3, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2317) },
                    { 328, 9, 1, "Experience the Luxury suite. . Perfect for a romantic weekend..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 1, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2324), 783.0, 4, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2323) },
                    { 329, 10, 8, "Experience the Deluxe room.  with a stunning view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 8, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2357), 1582.0, 5, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2355) },
                    { 330, 1, 6, "Experience the Single room.  with a private balcony..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 5, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2362), 361.0, 6, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2361) },
                    { 331, 2, 8, "Experience the Luxury suite.  with a cozy atmosphere..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 9, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2368), 1183.0, 7, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2366) },
                    { 332, 3, 4, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 10, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2373), 819.0, 8, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2371) },
                    { 333, 4, 5, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 2, 2, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2378), 308.0, 9, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2377) },
                    { 334, 5, 6, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 3, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2383), 1214.0, 10, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2382) },
                    { 335, 6, 3, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 11, 17, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2389), 588.0, 11, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2388) },
                    { 336, 7, 9, "Experience the Single room. . Perfect for a romantic weekend..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 10, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2394), 1039.0, 12, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2393) },
                    { 337, 8, 7, "Experience the Luxury suite.  with a stunning view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2027, 3, 3, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2421), 1375.0, 13, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2420) },
                    { 338, 9, 6, "Experience the Deluxe room.  with a private balcony..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2024, 12, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2427), 1991.0, 14, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2425) },
                    { 339, 10, 2, "Experience the Single room.  with a cozy atmosphere..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 3, 4, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2432), 1552.0, 15, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2431) },
                    { 340, 1, 8, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 1, 14, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2438), 1481.0, 16, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2436) },
                    { 341, 2, 5, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 4, 19, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2443), 1899.0, 17, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2441) },
                    { 342, 3, 2, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 8, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2448), 442.0, 18, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2447) },
                    { 343, 4, 7, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2024, 11, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2453), 735.0, 19, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2452) },
                    { 344, 5, 3, "Experience the Deluxe room. . Perfect for a romantic weekend..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 1, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2458), 1481.0, 20, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2457) },
                    { 345, 6, 6, "Experience the Single room.  with a stunning view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 3, 9, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2464), 1590.0, 21, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2462) },
                    { 346, 7, 4, "Experience the Luxury suite.  with a private balcony..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2027, 2, 13, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2490), 668.0, 22, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2488) },
                    { 347, 8, 7, "Experience the Deluxe room.  with a cozy atmosphere..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 2, 19, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2495), 453.0, 23, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2494) },
                    { 348, 9, 1, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 4, 13, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2501), 293.0, 24, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2499) },
                    { 349, 10, 8, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 4, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2506), 485.0, 25, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2504) },
                    { 350, 1, 6, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 7, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2511), 1262.0, 1, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2510) },
                    { 351, 2, 8, "Experience the Single room.  with a beautiful view and modern amenities..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 3, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2516), 950.0, 2, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2515) },
                    { 352, 3, 9, "Experience the Luxury suite. . Perfect for a romantic weekend..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 1, 19, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2522), 443.0, 3, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2521) },
                    { 353, 4, 1, "Experience the Deluxe room.  with a stunning view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 3, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2527), 380.0, 4, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2526) },
                    { 354, 5, 6, "Experience the Single room.  with a private balcony..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 2, 4, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2556), 1993.0, 5, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2555) },
                    { 355, 6, 2, "Experience the Luxury suite.  with a cozy atmosphere..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 6, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2562), 1355.0, 6, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2560) },
                    { 356, 7, 5, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2027, 3, 31, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2567), 1512.0, 7, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2566) },
                    { 357, 8, 1, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 7, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2573), 1191.0, 8, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2571) },
                    { 358, 9, 6, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 3, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2578), 649.0, 9, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2576) },
                    { 359, 10, 1, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 8, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2583), 136.0, 10, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2582) },
                    { 360, 1, 2, "Experience the Single room. . Perfect for a romantic weekend..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 7, 24, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2589), 1046.0, 11, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2587) },
                    { 361, 2, 3, "Experience the Luxury suite.  with a stunning view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 8, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2594), 1717.0, 12, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2593) },
                    { 362, 3, 8, "Experience the Deluxe room.  with a private balcony..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 7, 31, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2620), 571.0, 13, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2619) },
                    { 363, 4, 7, "Experience the Single room.  with a cozy atmosphere..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 3, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2625), 1171.0, 14, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2624) },
                    { 364, 5, 1, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 12, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2631), 1728.0, 15, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2629) },
                    { 365, 6, 6, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 5, 31, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2636), 1256.0, 16, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2635) },
                    { 366, 7, 2, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2027, 5, 5, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2641), 707.0, 17, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2640) },
                    { 367, 8, 8, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 10, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2647), 499.0, 18, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2645) },
                    { 368, 9, 1, "Experience the Deluxe room. . Perfect for a romantic weekend..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 3, 4, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2652), 1001.0, 19, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2650) },
                    { 369, 10, 5, "Experience the Single room.  with a stunning view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2027, 1, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2657), 1421.0, 20, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2656) },
                    { 370, 1, 8, "Experience the Luxury suite.  with a private balcony..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 8, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2685), 1258.0, 21, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2683) },
                    { 371, 2, 5, "Experience the Deluxe room.  with a cozy atmosphere..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 5, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2690), 1250.0, 22, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2689) },
                    { 372, 3, 4, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 7, 19, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2696), 845.0, 23, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2694) },
                    { 373, 4, 9, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2027, 6, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2701), 431.0, 24, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2700) },
                    { 374, 5, 6, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 2, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2706), 148.0, 25, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2705) },
                    { 375, 6, 8, "Experience the Single room.  with a beautiful view and modern amenities..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 4, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2711), 366.0, 1, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2710) },
                    { 376, 7, 6, "Experience the Luxury suite. . Perfect for a romantic weekend..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 1, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2717), 1538.0, 2, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2715) },
                    { 377, 8, 7, "Experience the Deluxe room.  with a stunning view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 2, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2722), 1141.0, 3, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2721) },
                    { 378, 9, 7, "Experience the Single room.  with a private balcony..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 9, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2749), 147.0, 4, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2747) },
                    { 379, 10, 9, "Experience the Luxury suite.  with a cozy atmosphere..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2027, 5, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2754), 471.0, 5, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2753) },
                    { 380, 1, 4, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 1, 26, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2760), 1421.0, 6, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2758) },
                    { 381, 2, 2, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 2, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2765), 1226.0, 7, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2764) },
                    { 382, 3, 7, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 4, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2770), 208.0, 8, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2769) },
                    { 383, 4, 7, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2027, 5, 13, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2775), 1746.0, 9, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2774) },
                    { 384, 5, 6, "Experience the Single room. . Perfect for a romantic weekend..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2027, 2, 20, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2781), 637.0, 10, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2779) },
                    { 385, 6, 5, "Experience the Luxury suite.  with a stunning view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2027, 6, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2786), 484.0, 11, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2784) },
                    { 386, 7, 5, "Experience the Deluxe room.  with a private balcony..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 4, 9, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2812), 1347.0, 12, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2810) },
                    { 387, 8, 5, "Experience the Single room.  with a cozy atmosphere..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 2, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2818), 1339.0, 13, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2816) },
                    { 388, 9, 2, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 8, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2823), 953.0, 14, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2821) },
                    { 389, 10, 7, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 11, 9, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2828), 1773.0, 15, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2827) },
                    { 390, 1, 9, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 10, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2833), 1749.0, 16, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2832) },
                    { 391, 2, 4, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 7, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2839), 1208.0, 17, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2837) },
                    { 392, 3, 3, "Experience the Deluxe room. . Perfect for a romantic weekend..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 9, 14, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2844), 1075.0, 18, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2843) },
                    { 393, 4, 6, "Experience the Single room.  with a stunning view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2027, 3, 26, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2850), 163.0, 19, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2848) },
                    { 394, 5, 6, "Experience the Luxury suite.  with a private balcony..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 10, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2882), 1648.0, 20, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2881) },
                    { 395, 6, 9, "Experience the Deluxe room.  with a cozy atmosphere..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 5, 4, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2888), 1629.0, 21, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2887) },
                    { 396, 7, 6, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 7, 14, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2893), 736.0, 22, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2892) },
                    { 397, 8, 6, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 1, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2899), 689.0, 23, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2897) },
                    { 398, 9, 6, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 12, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2904), 738.0, 24, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2903) },
                    { 399, 10, 9, "Experience the Single room.  with a beautiful view and modern amenities..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2027, 5, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2909), 1196.0, 25, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2908) },
                    { 400, 1, 9, "Experience the Luxury suite. . Perfect for a romantic weekend..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2027, 3, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2915), 287.0, 1, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2913) },
                    { 401, 2, 2, "Experience the Deluxe room.  with a stunning view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 9, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2920), 1309.0, 2, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2919) },
                    { 402, 3, 4, "Experience the Single room.  with a private balcony..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 3, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2925), 443.0, 3, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2924) },
                    { 403, 4, 6, "Experience the Luxury suite.  with a cozy atmosphere..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 4, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2954), 1707.0, 4, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2952) },
                    { 404, 5, 8, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 8, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2959), 1874.0, 5, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2958) },
                    { 405, 6, 2, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 2, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2965), 1286.0, 6, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2963) },
                    { 406, 7, 7, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 7, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2970), 722.0, 7, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2969) },
                    { 407, 8, 3, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 11, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2975), 974.0, 8, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2974) },
                    { 408, 9, 3, "Experience the Single room. . Perfect for a romantic weekend..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 5, 9, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2980), 1115.0, 9, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2979) },
                    { 409, 10, 5, "Experience the Luxury suite.  with a stunning view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 8, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2986), 811.0, 10, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2984) },
                    { 410, 1, 2, "Experience the Deluxe room.  with a private balcony..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 9, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2991), 485.0, 11, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2990) },
                    { 411, 2, 7, "Experience the Single room.  with a cozy atmosphere..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 8, 5, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3019), 1035.0, 12, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3017) },
                    { 412, 3, 6, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2027, 7, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3024), 1866.0, 13, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3023) },
                    { 413, 4, 7, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2027, 7, 12, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3029), 817.0, 14, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3028) },
                    { 414, 5, 3, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2027, 1, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3035), 1649.0, 15, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3033) },
                    { 415, 6, 6, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2027, 7, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3040), 1024.0, 16, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3039) },
                    { 416, 7, 2, "Experience the Deluxe room. . Perfect for a romantic weekend..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 3, 5, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3045), 632.0, 17, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3044) },
                    { 417, 8, 9, "Experience the Single room.  with a stunning view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 1, 14, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3051), 648.0, 18, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3049) },
                    { 418, 9, 8, "Experience the Luxury suite.  with a private balcony..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 11, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3056), 605.0, 19, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3054) },
                    { 419, 10, 9, "Experience the Deluxe room.  with a cozy atmosphere..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 1, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3085), 1919.0, 20, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3084) },
                    { 420, 1, 3, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 9, 24, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3091), 255.0, 21, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3089) },
                    { 421, 2, 8, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 7, 26, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3096), 1388.0, 22, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3095) },
                    { 422, 3, 3, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 6, 19, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3101), 458.0, 23, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3100) },
                    { 423, 4, 8, "Experience the Single room.  with a beautiful view and modern amenities..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2027, 3, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3107), 962.0, 24, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3105) },
                    { 424, 5, 1, "Experience the Luxury suite. . Perfect for a romantic weekend..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2027, 6, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3112), 411.0, 25, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3111) },
                    { 425, 6, 4, "Experience the Deluxe room.  with a stunning view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2027, 4, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3117), 1056.0, 1, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3116) },
                    { 426, 7, 8, "Experience the Single room.  with a private balcony..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 1, 2, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3123), 612.0, 2, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3121) },
                    { 427, 8, 2, "Experience the Luxury suite.  with a cozy atmosphere..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 9, 17, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3153), 1001.0, 3, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3151) },
                    { 428, 9, 3, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 7, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3158), 875.0, 4, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3157) },
                    { 429, 10, 9, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 7, 2, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3164), 1831.0, 5, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3162) },
                    { 430, 1, 1, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 6, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3169), 1925.0, 6, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3167) },
                    { 431, 2, 7, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 5, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3174), 1848.0, 7, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3173) },
                    { 432, 3, 6, "Experience the Single room. . Perfect for a romantic weekend..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 7, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3179), 1101.0, 8, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3178) },
                    { 433, 4, 2, "Experience the Luxury suite.  with a stunning view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2027, 1, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3185), 1705.0, 9, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3183) },
                    { 434, 5, 1, "Experience the Deluxe room.  with a private balcony..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2027, 3, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3190), 1356.0, 10, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3188) },
                    { 435, 6, 8, "Experience the Single room.  with a cozy atmosphere..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2027, 4, 26, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3226), 1241.0, 11, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3224) },
                    { 436, 7, 2, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 1, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3231), 1489.0, 12, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3230) },
                    { 437, 8, 5, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2027, 2, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3237), 164.0, 13, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3235) },
                    { 438, 9, 4, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 11, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3242), 145.0, 14, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3241) },
                    { 439, 10, 9, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 10, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3247), 1923.0, 15, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3246) },
                    { 440, 1, 6, "Experience the Deluxe room. . Perfect for a romantic weekend..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 4, 20, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3252), 1966.0, 16, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3251) },
                    { 441, 2, 2, "Experience the Single room.  with a stunning view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 10, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3258), 1024.0, 17, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3256) },
                    { 442, 3, 9, "Experience the Luxury suite.  with a private balcony..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2027, 9, 12, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3263), 1439.0, 18, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3261) },
                    { 443, 4, 7, "Experience the Deluxe room.  with a cozy atmosphere..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 4, 20, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3268), 1986.0, 19, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3267) },
                    { 444, 5, 1, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 7, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3295), 1835.0, 20, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3293) },
                    { 445, 6, 9, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 1, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3300), 1827.0, 21, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3299) },
                    { 446, 7, 9, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 2, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3306), 1939.0, 22, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3304) },
                    { 447, 8, 4, "Experience the Single room.  with a beautiful view and modern amenities..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2027, 3, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3311), 845.0, 23, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3310) },
                    { 448, 9, 3, "Experience the Luxury suite. . Perfect for a romantic weekend..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 9, 13, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3316), 629.0, 24, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3315) },
                    { 449, 10, 5, "Experience the Deluxe room.  with a stunning view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3322), 965.0, 25, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3320) },
                    { 450, 1, 5, "Experience the Single room.  with a private balcony..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2027, 6, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3327), 1888.0, 1, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3326) },
                    { 451, 2, 2, "Experience the Luxury suite.  with a cozy atmosphere..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2027, 10, 17, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3332), 729.0, 2, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3331) },
                    { 452, 3, 8, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 2, 17, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3360), 844.0, 3, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3359) },
                    { 453, 4, 9, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 12, 14, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3365), 1152.0, 4, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3364) },
                    { 454, 5, 9, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 10, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3371), 1652.0, 5, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3369) },
                    { 455, 6, 4, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2027, 5, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3376), 573.0, 6, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3375) },
                    { 456, 7, 2, "Experience the Single room. . Perfect for a romantic weekend..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 4, 2, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3381), 1171.0, 7, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3380) },
                    { 457, 8, 3, "Experience the Luxury suite.  with a stunning view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 8, 3, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3387), 1347.0, 8, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3386) },
                    { 458, 9, 9, "Experience the Deluxe room.  with a private balcony..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2027, 10, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3392), 1404.0, 9, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3391) },
                    { 459, 10, 1, "Experience the Single room.  with a cozy atmosphere..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2027, 2, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3398), 1414.0, 10, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3396) },
                    { 460, 1, 8, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 6, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3430), 1844.0, 11, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3429) },
                    { 461, 2, 3, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 5, 13, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3436), 1914.0, 12, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3435) },
                    { 462, 3, 4, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 11, 5, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3441), 820.0, 13, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3440) },
                    { 463, 4, 6, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 4, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3446), 190.0, 14, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3445) },
                    { 464, 5, 4, "Experience the Deluxe room. . Perfect for a romantic weekend..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 8, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3452), 1961.0, 15, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3450) },
                    { 465, 6, 4, "Experience the Single room.  with a stunning view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2027, 9, 14, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3457), 1312.0, 16, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3455) },
                    { 466, 7, 7, "Experience the Luxury suite.  with a private balcony..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 6, 26, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3462), 806.0, 17, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3461) },
                    { 467, 8, 7, "Experience the Deluxe room.  with a cozy atmosphere..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 4, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3467), 1227.0, 18, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3466) },
                    { 468, 9, 5, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2027, 3, 24, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3494), 1048.0, 19, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3492) },
                    { 469, 10, 8, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2027, 9, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3499), 635.0, 20, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3498) },
                    { 470, 1, 1, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2027, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3505), 1635.0, 21, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3503) },
                    { 471, 2, 1, "Experience the Single room.  with a beautiful view and modern amenities..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 4, 20, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3510), 1730.0, 22, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3508) },
                    { 472, 3, 2, "Experience the Luxury suite. . Perfect for a romantic weekend..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 9, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3515), 731.0, 23, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3514) },
                    { 473, 4, 3, "Experience the Deluxe room.  with a stunning view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 11, 14, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3520), 1265.0, 24, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3519) },
                    { 474, 5, 5, "Experience the Single room.  with a private balcony..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2027, 6, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3526), 1943.0, 25, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3524) },
                    { 475, 6, 5, "Experience the Luxury suite.  with a cozy atmosphere..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2027, 6, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3531), 1581.0, 1, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3529) },
                    { 476, 7, 5, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 6, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3559), 866.0, 2, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3557) },
                    { 477, 8, 5, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 1, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3564), 1423.0, 3, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3563) },
                    { 478, 9, 1, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 6, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3570), 957.0, 4, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3568) },
                    { 479, 10, 5, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 10, 24, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3575), 1778.0, 5, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3574) },
                    { 480, 1, 3, "Experience the Single room. . Perfect for a romantic weekend..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2027, 12, 5, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3580), 911.0, 6, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3579) },
                    { 481, 2, 7, "Experience the Luxury suite.  with a stunning view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2027, 3, 26, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3586), 519.0, 7, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3584) },
                    { 482, 3, 1, "Experience the Deluxe room.  with a private balcony..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 3, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3591), 1884.0, 8, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3589) },
                    { 483, 4, 5, "Experience the Single room.  with a cozy atmosphere..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 6, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3596), 977.0, 9, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3595) },
                    { 484, 5, 3, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 12, 4, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3624), 377.0, 10, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3622) },
                    { 485, 6, 6, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2027, 6, 17, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3629), 1808.0, 11, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3628) },
                    { 486, 7, 5, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 11, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3634), 1877.0, 12, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3633) },
                    { 487, 8, 8, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2027, 3, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3640), 1461.0, 13, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3638) },
                    { 488, 9, 9, "Experience the Deluxe room. . Perfect for a romantic weekend..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 5, 20, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3645), 1743.0, 14, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3644) },
                    { 489, 10, 2, "Experience the Single room.  with a stunning view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 3, 4, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3650), 616.0, 15, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3649) },
                    { 490, 1, 1, "Experience the Luxury suite.  with a private balcony..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2027, 9, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3655), 629.0, 16, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3654) },
                    { 491, 2, 5, "Experience the Deluxe room.  with a cozy atmosphere..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 7, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3661), 1691.0, 17, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3659) },
                    { 492, 3, 1, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 11, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3688), 1212.0, 18, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3686) },
                    { 493, 4, 6, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 11, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3693), 113.0, 19, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3692) },
                    { 494, 5, 5, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 11, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3698), 719.0, 20, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3697) },
                    { 495, 6, 9, "Experience the Single room.  with a beautiful view and modern amenities..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 11, 3, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3704), 1894.0, 21, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3702) },
                    { 496, 7, 9, "Experience the Luxury suite. . Perfect for a romantic weekend..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 11, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3709), 135.0, 22, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3707) },
                    { 497, 8, 3, "Experience the Deluxe room.  with a stunning view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2027, 9, 3, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3714), 1881.0, 23, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3713) },
                    { 498, 9, 2, "Experience the Single room.  with a private balcony..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 10, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3719), 629.0, 24, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3718) },
                    { 499, 10, 8, "Experience the Luxury suite.  with a cozy atmosphere..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 4, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3725), 369.0, 25, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3723) },
                    { 500, 1, 1, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 8, 12, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3730), 1348.0, 1, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3729) },
                    { 501, 2, 1, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2027, 1, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3758), 164.0, 2, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3756) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
