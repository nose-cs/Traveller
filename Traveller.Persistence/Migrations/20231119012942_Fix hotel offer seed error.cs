using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Traveller.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Fixhotelofferseederror : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Luxury suite with a stunning view.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2024, 4, 6, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1193.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Deluxe room with a private balcony.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 4, 30, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 551.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Standard room with a cozy atmosphere.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 7, 16, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1023.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Family room. Spacious room with a breathtaking view of the city.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 5, 16, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1064.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2024, 1, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1835.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Executive room with a comfortable atmosphere and a stunning view.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2024, 8, 9, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1845.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Superior room with a beautiful view and modern amenities.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2024, 5, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 748.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Presidential suite. Perfect for a romantic weekend.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 4, 16, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1498.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Penthouse suite with a stunning view.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 12, 12, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1380.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Studio suite with a private balcony.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 1, 15, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1459.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Double room with a cozy atmosphere.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 6, 29, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1742.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Twin room. Spacious room with a breathtaking view of the city.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2024, 9, 11, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 807.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Triple room with a cozy atmosphere and a beautiful view.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 3, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 146.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the King room with a comfortable atmosphere and a stunning view.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2024, 9, 18, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 424.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Queen room with a beautiful view and modern amenities.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2024, 7, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1280.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Single room. Perfect for a romantic weekend.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2024, 6, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 536.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Luxury suite with a stunning view.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 2, 3, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1019.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Deluxe room with a private balcony.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 7, 12, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 407.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Standard room with a cozy atmosphere.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 7, 18, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1232.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Family room. Spacious room with a breathtaking view of the city.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2024, 9, 5, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 558.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2024, 11, 30, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 328.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Executive room with a comfortable atmosphere and a stunning view.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2024, 8, 1, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 920.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Superior room with a beautiful view and modern amenities.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 7, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 835.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Presidential suite. Perfect for a romantic weekend.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 4, 6, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 526.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Penthouse suite with a stunning view.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 1, 30, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1295.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Studio suite with a private balcony.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 8, 31, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1685.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Double room with a cozy atmosphere.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2024, 9, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1636.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Twin room. Spacious room with a breathtaking view of the city.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2024, 12, 30, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1541.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Triple room with a cozy atmosphere and a beautiful view.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 9, 29, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1075.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the King room with a comfortable atmosphere and a stunning view.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2024, 11, 6, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1844.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Queen room with a beautiful view and modern amenities.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2024, 5, 6, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 817.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Single room. Perfect for a romantic weekend.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 2, 13, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 366.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Luxury suite with a stunning view.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 2, 3, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1851.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room with a private balcony.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 2, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 744.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Standard room with a cozy atmosphere.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2024, 11, 18, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1771.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Family room. Spacious room with a breathtaking view of the city.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 8, 31, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1952.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2024, 4, 5, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1553.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Executive room with a comfortable atmosphere and a stunning view.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 4, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1929.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Superior room with a beautiful view and modern amenities.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 5, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 112.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Presidential suite. Perfect for a romantic weekend.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 2, 7, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1185.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Penthouse suite with a stunning view.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 3, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 886.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Studio suite with a private balcony.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2024, 5, 2, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1671.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Double room with a cozy atmosphere.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 3, 15, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 346.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Twin room. Spacious room with a breathtaking view of the city.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 7, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1152.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Triple room with a cozy atmosphere and a beautiful view.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2024, 8, 7, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 168.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the King room with a comfortable atmosphere and a stunning view.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2024, 9, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 505.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Queen room with a beautiful view and modern amenities.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 5, 10, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 641.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Single room. Perfect for a romantic weekend.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2024, 10, 1, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 406.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Luxury suite with a stunning view.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2024, 5, 30, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 724.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Deluxe room with a private balcony.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 2, 10, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1932.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Standard room with a cozy atmosphere.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2024, 11, 2, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1469.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Family room. Spacious room with a breathtaking view of the city.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2024, 5, 30, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 987.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2024, 4, 28, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 188.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Executive room with a comfortable atmosphere and a stunning view.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 7, 12, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 238.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Superior room with a beautiful view and modern amenities.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 4, 30, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 803.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Presidential suite. Perfect for a romantic weekend.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 4, 1, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 259.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Penthouse suite with a stunning view.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2024, 6, 5, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1193.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Studio suite with a private balcony.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 8, 18, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1612.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Double room with a cozy atmosphere.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2024, 9, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1938.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Twin room. Spacious room with a breathtaking view of the city.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2024, 12, 5, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 416.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Triple room with a cozy atmosphere and a beautiful view.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 9, 8, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1427.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the King room with a comfortable atmosphere and a stunning view.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 3, 4, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 566.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Queen room with a beautiful view and modern amenities.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 2, 2, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 198.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Single room. Perfect for a romantic weekend.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 6, 28, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 874.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Luxury suite with a stunning view.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 5, 13, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1547.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room with a private balcony.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1283.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Standard room with a cozy atmosphere.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 9, 13, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1184.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Family room. Spacious room with a breathtaking view of the city.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 6, 15, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1399.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2024, 11, 7, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1100.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Executive room with a comfortable atmosphere and a stunning view.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 8, 1, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 747.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Superior room with a beautiful view and modern amenities.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2024, 3, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 124.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Presidential suite. Perfect for a romantic weekend.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 3, 2, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 444.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Penthouse suite with a stunning view.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2024, 3, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1443.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Studio suite with a private balcony.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 10, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1048.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Double room with a cozy atmosphere.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 1, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 532.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Twin room. Spacious room with a breathtaking view of the city.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 10, 9, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1537.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Triple room with a cozy atmosphere and a beautiful view.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2024, 2, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1632.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the King room with a comfortable atmosphere and a stunning view.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 2, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1057.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Queen room with a beautiful view and modern amenities.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 2, 13, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1480.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Single room. Perfect for a romantic weekend.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 7, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 360.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Luxury suite with a stunning view.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 6, 7, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1740.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Deluxe room with a private balcony.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 1, 2, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 355.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Standard room with a cozy atmosphere.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2024, 10, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 461.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Family room. Spacious room with a breathtaking view of the city.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 1, 7, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1435.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 5, 16, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1048.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Executive room with a comfortable atmosphere and a stunning view.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2024, 4, 10, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1365.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Superior room with a beautiful view and modern amenities.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 1, 13, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 359.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Presidential suite. Perfect for a romantic weekend.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 3, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 212.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Penthouse suite with a stunning view.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 9, 12, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1287.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Studio suite with a private balcony.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 4, 6, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 906.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Double room with a cozy atmosphere.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 2, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 610.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Twin room. Spacious room with a breathtaking view of the city.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 12, 28, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 318.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Triple room with a cozy atmosphere and a beautiful view.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2024, 7, 31, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 584.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the King room with a comfortable atmosphere and a stunning view.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 2, 16, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 724.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Queen room with a beautiful view and modern amenities.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 7, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 362.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Single room. Perfect for a romantic weekend.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 3, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1664.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite with a stunning view.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 6, 7, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1857.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Deluxe room with a private balcony.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 9, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 598.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Standard room with a cozy atmosphere.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 4, 28, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1578.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Family room. Spacious room with a breathtaking view of the city.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 8, 29, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 538.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 10, 2, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1690.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Executive room with a comfortable atmosphere and a stunning view.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2024, 12, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 866.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Superior room with a beautiful view and modern amenities.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 8, 10, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 166.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Presidential suite. Perfect for a romantic weekend.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 3, 17, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 630.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Penthouse suite with a stunning view.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 9, 8, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 361.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Studio suite with a private balcony.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 3, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 261.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Double room with a cozy atmosphere.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 12, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 428.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Twin room. Spacious room with a breathtaking view of the city.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 3, 9, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 827.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Triple room with a cozy atmosphere and a beautiful view.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 1, 1, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 308.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the King room with a comfortable atmosphere and a stunning view.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 9, 1, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1678.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Queen room with a beautiful view and modern amenities.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2024, 9, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1656.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Single room. Perfect for a romantic weekend.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2024, 5, 16, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1310.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Luxury suite with a stunning view.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 8, 7, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1981.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Deluxe room with a private balcony.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2024, 6, 13, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 607.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Standard room with a cozy atmosphere.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2024, 11, 11, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1811.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Family room. Spacious room with a breathtaking view of the city.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 1, 4, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1879.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 11, 30, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1359.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Executive room with a comfortable atmosphere and a stunning view.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2024, 12, 9, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 302.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Superior room with a beautiful view and modern amenities.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 8, 30, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 184.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Presidential suite. Perfect for a romantic weekend.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 6, 11, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 743.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Penthouse suite with a stunning view.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 1, 16, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1209.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Studio suite with a private balcony.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 9, 6, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 673.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Double room with a cozy atmosphere.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 4, 3, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 947.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Twin room. Spacious room with a breathtaking view of the city.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 4, 10, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1184.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Triple room with a cozy atmosphere and a beautiful view.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 8, 12, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1027.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the King room with a comfortable atmosphere and a stunning view.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 11, 30, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1851.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Queen room with a beautiful view and modern amenities.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 10, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1382.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Single room. Perfect for a romantic weekend.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2024, 9, 29, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 560.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Luxury suite with a stunning view.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 8, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1341.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Deluxe room with a private balcony.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 11, 6, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1730.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Standard room with a cozy atmosphere.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 5, 8, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 132.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Family room. Spacious room with a breathtaking view of the city.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 3, 14, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 149.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 10, 31, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1673.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Executive room with a comfortable atmosphere and a stunning view.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 1, 4, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 966.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Superior room with a beautiful view and modern amenities.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 5, 29, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 774.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Presidential suite. Perfect for a romantic weekend.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2024, 12, 12, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1505.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Penthouse suite with a stunning view.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 12, 6, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1599.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Studio suite with a private balcony.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 7, 12, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1155.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Double room with a cozy atmosphere.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 12, 17, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1398.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Twin room. Spacious room with a breathtaking view of the city.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 8, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 548.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Triple room with a cozy atmosphere and a beautiful view.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 1, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 182.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the King room with a comfortable atmosphere and a stunning view.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2024, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 831.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Queen room with a beautiful view and modern amenities.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 10, 28, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1484.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Single room. Perfect for a romantic weekend.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 5, 11, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 233.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Luxury suite with a stunning view.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 7, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 994.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Deluxe room with a private balcony.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2024, 7, 1, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1682.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Standard room with a cozy atmosphere.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 10, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 933.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Family room. Spacious room with a breathtaking view of the city.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 3, 2, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1160.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1528.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Executive room with a comfortable atmosphere and a stunning view.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 5, 13, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1744.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Superior room with a beautiful view and modern amenities.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2027, 1, 8, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 226.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Presidential suite. Perfect for a romantic weekend.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 7, 3, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1518.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Penthouse suite with a stunning view.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 12, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1737.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Studio suite with a private balcony.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 5, 18, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1440.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Double room with a cozy atmosphere.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 6, 1, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1955.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Twin room. Spacious room with a breathtaking view of the city.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 11, 4, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1246.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Triple room with a cozy atmosphere and a beautiful view.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 12, 18, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 749.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the King room with a comfortable atmosphere and a stunning view.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 9, 6, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1321.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Queen room with a beautiful view and modern amenities.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 7, 4, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 745.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Single room. Perfect for a romantic weekend.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 1, 16, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 734.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite with a stunning view.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2024, 8, 3, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1900.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room with a private balcony.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 7, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1408.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Standard room with a cozy atmosphere.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2024, 11, 18, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1737.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Family room. Spacious room with a breathtaking view of the city.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 4, 12, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1892.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 7, 9, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 217.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Executive room with a comfortable atmosphere and a stunning view.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 7, 8, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1290.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Superior room with a beautiful view and modern amenities.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 8, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1256.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Presidential suite. Perfect for a romantic weekend.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 9, 2, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1475.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Penthouse suite with a stunning view.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2024, 7, 4, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1653.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Studio suite with a private balcony.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 1, 29, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1315.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Double room with a cozy atmosphere.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 1, 30, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 312.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Twin room. Spacious room with a breathtaking view of the city.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 12, 5, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 949.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Triple room with a cozy atmosphere and a beautiful view.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 10, 30, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1968.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the King room with a comfortable atmosphere and a stunning view.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 5, 29, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 102.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Queen room with a beautiful view and modern amenities.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 11, 29, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 559.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Single room. Perfect for a romantic weekend.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 2, 14, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1527.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Luxury suite with a stunning view.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 2, 18, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1995.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Deluxe room with a private balcony.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 3, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 440.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Standard room with a cozy atmosphere.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 1, 18, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1997.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Family room. Spacious room with a breathtaking view of the city.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 873.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 5, 29, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1948.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Executive room with a comfortable atmosphere and a stunning view.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 6, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 914.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Superior room with a beautiful view and modern amenities.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 10, 14, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 110.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Presidential suite. Perfect for a romantic weekend.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 1, 16, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1301.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Penthouse suite with a stunning view.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 8, 5, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 870.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Studio suite with a private balcony.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2024, 6, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 222.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Double room with a cozy atmosphere.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 5, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 352.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Twin room. Spacious room with a breathtaking view of the city.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 3, 5, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1714.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Triple room with a cozy atmosphere and a beautiful view.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 12, 11, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 507.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the King room with a comfortable atmosphere and a stunning view.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 12, 14, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1484.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Queen room with a beautiful view and modern amenities.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 2, 14, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 942.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Single room. Perfect for a romantic weekend.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 10, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1625.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Luxury suite with a stunning view.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 3, 3, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 670.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Deluxe room with a private balcony.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 2, 28, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1319.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Standard room with a cozy atmosphere.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 3, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 531.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Family room. Spacious room with a breathtaking view of the city.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 4, 29, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 359.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 7, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 918.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Executive room with a comfortable atmosphere and a stunning view.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2024, 7, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 668.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Superior room with a beautiful view and modern amenities.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2024, 10, 9, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 606.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Presidential suite. Perfect for a romantic weekend.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2024, 10, 17, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 959.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Penthouse suite with a stunning view.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 4, 13, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 618.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Studio suite with a private balcony.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 1, 10, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 290.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Double room with a cozy atmosphere.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 7, 18, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1262.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Twin room. Spacious room with a breathtaking view of the city.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 2, 15, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1684.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Triple room with a cozy atmosphere and a beautiful view.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 6, 16, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1963.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the King room with a comfortable atmosphere and a stunning view.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 4, 2, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1871.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Queen room with a beautiful view and modern amenities.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 6, 5, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 669.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Single room. Perfect for a romantic weekend.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 8, 10, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1164.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Luxury suite with a stunning view.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 10, 5, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1010.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Deluxe room with a private balcony.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 6, 8, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 440.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Standard room with a cozy atmosphere.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 8, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 335.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Family room. Spacious room with a breathtaking view of the city.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 12, 15, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1131.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2027, 1, 12, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 642.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Executive room with a comfortable atmosphere and a stunning view.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 11, 7, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1002.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Superior room with a beautiful view and modern amenities.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 4, 2, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1366.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Presidential suite. Perfect for a romantic weekend.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 2, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1295.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Penthouse suite with a stunning view.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 7, 29, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1890.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Studio suite with a private balcony.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 1, 9, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 340.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Double room with a cozy atmosphere.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 2, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 366.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Twin room. Spacious room with a breathtaking view of the city.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 10, 13, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1202.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Triple room with a cozy atmosphere and a beautiful view.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 6, 13, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1159.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the King room with a comfortable atmosphere and a stunning view.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2024, 12, 15, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 628.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Queen room with a beautiful view and modern amenities.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 3, 9, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 605.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Single room. Perfect for a romantic weekend.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2024, 8, 14, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1362.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Luxury suite with a stunning view.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 6, 3, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1949.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room with a private balcony.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2024, 8, 30, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 824.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Standard room with a cozy atmosphere.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 5, 5, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1844.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Family room. Spacious room with a breathtaking view of the city.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 8, 16, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1586.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2027, 2, 7, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 397.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Executive room with a comfortable atmosphere and a stunning view.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2024, 10, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 492.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Superior room with a beautiful view and modern amenities.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2024, 8, 5, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1111.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Presidential suite. Perfect for a romantic weekend.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 4, 30, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1458.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Penthouse suite with a stunning view.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2024, 8, 8, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1119.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Studio suite with a private balcony.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 12, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1898.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Double room with a cozy atmosphere.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 2, 16, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1825.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Twin room. Spacious room with a breathtaking view of the city.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 2, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1624.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Triple room with a cozy atmosphere and a beautiful view.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 3, 30, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 668.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the King room with a comfortable atmosphere and a stunning view.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 4, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1923.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Queen room with a beautiful view and modern amenities.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 12, 9, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1207.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Single room. Perfect for a romantic weekend.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 5, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 944.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Luxury suite with a stunning view.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 10, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 455.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Deluxe room with a private balcony.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2024, 10, 28, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1151.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Standard room with a cozy atmosphere.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2024, 12, 5, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 515.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Family room. Spacious room with a breathtaking view of the city.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 10, 31, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1936.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2024, 11, 18, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1557.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Executive room with a comfortable atmosphere and a stunning view.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 6, 15, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 276.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Superior room with a beautiful view and modern amenities.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1325.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Presidential suite. Perfect for a romantic weekend.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 5, 1, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1852.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Penthouse suite with a stunning view.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 7, 14, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1515.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Studio suite with a private balcony.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 2, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 895.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Double room with a cozy atmosphere.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 12, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1731.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Twin room. Spacious room with a breathtaking view of the city.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2024, 9, 10, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 992.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Triple room with a cozy atmosphere and a beautiful view.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 3, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1846.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the King room with a comfortable atmosphere and a stunning view.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 12, 16, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 596.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Queen room with a beautiful view and modern amenities.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 9, 30, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1510.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Single room. Perfect for a romantic weekend.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2024, 9, 5, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 278.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite with a stunning view.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 12, 2, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 746.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room with a private balcony.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 11, 2, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 909.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Standard room with a cozy atmosphere.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 9, 15, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1954.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Family room. Spacious room with a breathtaking view of the city.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 11, 13, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 562.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 7, 13, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1739.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Executive room with a comfortable atmosphere and a stunning view.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2024, 12, 16, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1632.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Superior room with a beautiful view and modern amenities.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 350.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Presidential suite. Perfect for a romantic weekend.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 9, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1951.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Penthouse suite with a stunning view.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2024, 10, 31, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 498.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Studio suite with a private balcony.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 4, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1223.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Double room with a cozy atmosphere.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 422.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Twin room. Spacious room with a breathtaking view of the city.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2024, 12, 31, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 322.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Triple room with a cozy atmosphere and a beautiful view.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 4, 7, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1743.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the King room with a comfortable atmosphere and a stunning view.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 4, 7, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 999.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Queen room with a beautiful view and modern amenities.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 8, 11, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 932.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Single room. Perfect for a romantic weekend.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 5, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1833.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Luxury suite with a stunning view.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2024, 9, 2, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1938.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room with a private balcony.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2024, 10, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 584.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Standard room with a cozy atmosphere.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2027, 3, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 871.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Family room. Spacious room with a breathtaking view of the city.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2024, 12, 3, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1781.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2024, 9, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1309.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Executive room with a comfortable atmosphere and a stunning view.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 1, 5, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 568.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Superior room with a beautiful view and modern amenities.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 8, 14, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 723.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Presidential suite. Perfect for a romantic weekend.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 4, 16, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 525.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Penthouse suite with a stunning view.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 3, 16, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 964.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Studio suite with a private balcony.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 12, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1625.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Double room with a cozy atmosphere.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 4, 15, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1918.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Twin room. Spacious room with a breathtaking view of the city.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 12, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 910.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Triple room with a cozy atmosphere and a beautiful view.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2024, 10, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1356.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the King room with a comfortable atmosphere and a stunning view.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2027, 4, 16, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 438.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Queen room with a beautiful view and modern amenities.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2027, 4, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 969.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Single room. Perfect for a romantic weekend.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 936.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Luxury suite with a stunning view.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 9, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 394.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Deluxe room with a private balcony.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 6, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1843.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Standard room with a cozy atmosphere.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 8, 17, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1021.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Family room. Spacious room with a breathtaking view of the city.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2027, 3, 18, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1332.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2027, 5, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 381.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Executive room with a comfortable atmosphere and a stunning view.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2027, 6, 3, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 994.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Superior room with a beautiful view and modern amenities.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 9, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 979.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Presidential suite. Perfect for a romantic weekend.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 7, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 683.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Penthouse suite with a stunning view.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 9, 17, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 524.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Studio suite with a private balcony.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 6, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1599.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Double room with a cozy atmosphere.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 11, 6, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1776.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Twin room. Spacious room with a breathtaking view of the city.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 5, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1588.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Triple room with a cozy atmosphere and a beautiful view.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2024, 10, 13, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 323.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the King room with a comfortable atmosphere and a stunning view.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 4, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 301.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Queen room with a beautiful view and modern amenities.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 2, 6, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1705.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Single room. Perfect for a romantic weekend.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 7, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1772.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Luxury suite with a stunning view.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 2, 3, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1166.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Deluxe room with a private balcony.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 1, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 257.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Standard room with a cozy atmosphere.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 4, 7, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 507.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Family room. Spacious room with a breathtaking view of the city.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 3, 11, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1089.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 11, 15, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1113.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Executive room with a comfortable atmosphere and a stunning view.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2027, 5, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1960.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Superior room with a beautiful view and modern amenities.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 8, 9, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 357.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Presidential suite. Perfect for a romantic weekend.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2027, 2, 6, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 536.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Penthouse suite with a stunning view.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 3, 9, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1295.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Studio suite with a private balcony.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 7, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 176.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Double room with a cozy atmosphere.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 8, 13, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 513.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Twin room. Spacious room with a breathtaking view of the city.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 10, 17, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 423.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Triple room with a cozy atmosphere and a beautiful view.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 9, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1573.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the King room with a comfortable atmosphere and a stunning view.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 11, 16, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1408.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Queen room with a beautiful view and modern amenities.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2024, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1806.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Single room. Perfect for a romantic weekend.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2027, 4, 3, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 566.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite with a stunning view.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 8, 28, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1243.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room with a private balcony.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2027, 4, 2, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 960.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Standard room with a cozy atmosphere.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 8, 28, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1629.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Family room. Spacious room with a breathtaking view of the city.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 5, 9, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 206.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 7, 10, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 999.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Executive room with a comfortable atmosphere and a stunning view.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 8, 11, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1648.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Superior room with a beautiful view and modern amenities.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2027, 5, 12, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1613.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Presidential suite. Perfect for a romantic weekend.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 3, 8, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1944.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Penthouse suite with a stunning view.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 12, 7, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 219.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Studio suite with a private balcony.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 3, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 219.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Double room with a cozy atmosphere.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2024, 11, 6, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1655.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Twin room. Spacious room with a breathtaking view of the city.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 4, 28, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 919.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Triple room with a cozy atmosphere and a beautiful view.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 8, 17, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 264.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the King room with a comfortable atmosphere and a stunning view.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2027, 1, 7, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1367.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Queen room with a beautiful view and modern amenities.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 3, 31, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1057.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Single room. Perfect for a romantic weekend.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 12, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 629.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Luxury suite with a stunning view.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2027, 3, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1598.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Deluxe room with a private balcony.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 6, 2, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1130.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Standard room with a cozy atmosphere.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 3, 31, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1880.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Family room. Spacious room with a breathtaking view of the city.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 1, 2, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1218.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2027, 7, 16, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 375.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Executive room with a comfortable atmosphere and a stunning view.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 12, 10, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 266.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Superior room with a beautiful view and modern amenities.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 9, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1069.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Presidential suite. Perfect for a romantic weekend.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 8, 30, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1993.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Penthouse suite with a stunning view.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2027, 7, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1852.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Studio suite with a private balcony.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 1, 14, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 326.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Double room with a cozy atmosphere.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 5, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 860.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Twin room. Spacious room with a breathtaking view of the city.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 11, 30, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 995.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Triple room with a cozy atmosphere and a beautiful view.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2027, 4, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1207.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the King room with a comfortable atmosphere and a stunning view.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2027, 2, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1496.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Queen room with a beautiful view and modern amenities.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 9, 7, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 657.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Single room. Perfect for a romantic weekend.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 10, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 648.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Luxury suite with a stunning view.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 7, 8, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1923.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Deluxe room with a private balcony.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 9, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 673.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Standard room with a cozy atmosphere.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2027, 6, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 833.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Family room. Spacious room with a breathtaking view of the city.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 1, 12, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 697.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2027, 3, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1129.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Executive room with a comfortable atmosphere and a stunning view.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2027, 1, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 512.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Superior room with a beautiful view and modern amenities.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2024, 12, 16, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1708.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Presidential suite. Perfect for a romantic weekend.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 10, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1853.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Penthouse suite with a stunning view.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 4, 6, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1179.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Studio suite with a private balcony.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2027, 6, 9, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1571.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Double room with a cozy atmosphere.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 5, 10, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1906.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Twin room. Spacious room with a breathtaking view of the city.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 7, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1980.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Triple room with a cozy atmosphere and a beautiful view.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2027, 2, 7, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1209.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the King room with a comfortable atmosphere and a stunning view.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2024, 12, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1039.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Queen room with a beautiful view and modern amenities.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2027, 2, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 337.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Single room. Perfect for a romantic weekend.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2027, 8, 6, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 459.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Luxury suite with a stunning view.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 6, 14, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1975.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Deluxe room with a private balcony.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 5, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1351.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Standard room with a cozy atmosphere.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 10, 28, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 775.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Family room. Spacious room with a breathtaking view of the city.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 7, 28, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1925.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 9, 12, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1196.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Executive room with a comfortable atmosphere and a stunning view.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2027, 8, 4, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1483.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Superior room with a beautiful view and modern amenities.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 12, 31, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1522.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Presidential suite. Perfect for a romantic weekend.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2027, 5, 31, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1614.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Penthouse suite with a stunning view.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 11, 6, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1588.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Studio suite with a private balcony.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 9, 5, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1870.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Double room with a cozy atmosphere.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 2, 8, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1617.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Twin room. Spacious room with a breathtaking view of the city.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 6, 16, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 318.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Triple room with a cozy atmosphere and a beautiful view.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2027, 7, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 708.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the King room with a comfortable atmosphere and a stunning view.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 3, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1117.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Queen room with a beautiful view and modern amenities.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2027, 3, 10, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1072.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Single room. Perfect for a romantic weekend.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 4, 18, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1075.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Luxury suite with a stunning view.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 3, 12, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 835.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Deluxe room with a private balcony.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 9, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 606.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Standard room with a cozy atmosphere.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 1, 6, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1531.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Family room. Spacious room with a breathtaking view of the city.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 12, 31, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1916.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2027, 2, 11, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 904.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Executive room with a comfortable atmosphere and a stunning view.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2027, 9, 1, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1038.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Superior room with a beautiful view and modern amenities.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 3, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1800.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Presidential suite. Perfect for a romantic weekend.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2027, 2, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1974.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Penthouse suite with a stunning view.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 1, 8, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 735.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Studio suite with a private balcony.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 2, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1762.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Double room with a cozy atmosphere.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 2, 9, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1728.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Twin room. Spacious room with a breathtaking view of the city.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 2, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1293.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Triple room with a cozy atmosphere and a beautiful view.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 10, 3, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1586.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the King room with a comfortable atmosphere and a stunning view.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 11, 6, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 671.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Queen room with a beautiful view and modern amenities.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 1, 4, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1348.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Single room. Perfect for a romantic weekend.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2027, 8, 10, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1204.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Luxury suite with a stunning view.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 10, 9, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 506.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room with a private balcony.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 6, 2, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 855.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Standard room with a cozy atmosphere.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2027, 6, 9, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 213.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Family room. Spacious room with a breathtaking view of the city.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 1, 18, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1034.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 5, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1162.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Executive room with a comfortable atmosphere and a stunning view.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 12, 18, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 615.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Superior room with a beautiful view and modern amenities.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 9, 30, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1045.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Presidential suite. Perfect for a romantic weekend.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 7, 29, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 272.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Penthouse suite with a stunning view.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 6, 3, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1636.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Studio suite with a private balcony.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 12, 7, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 730.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Double room with a cozy atmosphere.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2027, 3, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 422.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Twin room. Spacious room with a breathtaking view of the city.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 7, 10, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1877.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Triple room with a cozy atmosphere and a beautiful view.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 1, 28, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 612.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the King room with a comfortable atmosphere and a stunning view.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2027, 9, 15, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1709.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Queen room with a beautiful view and modern amenities.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 4, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 744.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Single room. Perfect for a romantic weekend.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2027, 9, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1816.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Luxury suite with a stunning view.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 4, 7, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 818.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Deluxe room with a private balcony.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 12, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 128.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Standard room with a cozy atmosphere.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 4, 7, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1458.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Family room. Spacious room with a breathtaking view of the city.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 9, 18, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1306.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2027, 7, 11, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1414.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Executive room with a comfortable atmosphere and a stunning view.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 7, 28, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 758.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Superior room with a beautiful view and modern amenities.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2027, 10, 10, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 116.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Presidential suite. Perfect for a romantic weekend.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 9, 3, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1759.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Penthouse suite with a stunning view.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2027, 6, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 618.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Studio suite with a private balcony.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2027, 7, 31, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1685.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Double room with a cozy atmosphere.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 11, 18, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 728.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Twin room. Spacious room with a breathtaking view of the city.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 6, 6, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1892.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Triple room with a cozy atmosphere and a beautiful view.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 8, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 316.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the King room with a comfortable atmosphere and a stunning view.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 4, 4, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1502.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Queen room with a beautiful view and modern amenities.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 1, 6, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 230.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Single room. Perfect for a romantic weekend.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 4, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1688.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Luxury suite with a stunning view.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 2, 28, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1698.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room with a private balcony.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 12, 28, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 146.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Standard room with a cozy atmosphere.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 4, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1328.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Family room. Spacious room with a breathtaking view of the city.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 12, 10, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1324.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 11, 16, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1024.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Executive room with a comfortable atmosphere and a stunning view.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 2, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 413.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Superior room with a beautiful view and modern amenities.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 3, 16, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 258.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Presidential suite. Perfect for a romantic weekend.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 4, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1884.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Penthouse suite with a stunning view.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 2, 17, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 705.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Studio suite with a private balcony.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 6, 6, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1576.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Double room with a cozy atmosphere.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2027, 1, 2, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 821.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Twin room. Spacious room with a breathtaking view of the city.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 4, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 244.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Triple room with a cozy atmosphere and a beautiful view.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 7, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 175.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the King room with a comfortable atmosphere and a stunning view.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 10, 8, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 340.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Queen room with a beautiful view and modern amenities.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2027, 8, 18, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1178.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Single room. Perfect for a romantic weekend.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 2, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1377.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Luxury suite with a stunning view.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 4, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1176.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Deluxe room with a private balcony.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 3, 4, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 849.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Standard room with a cozy atmosphere.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2027, 7, 11, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 670.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Family room. Spacious room with a breathtaking view of the city.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 10, 2, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1719.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2027, 6, 9, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1179.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Executive room with a comfortable atmosphere and a stunning view.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 8, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 447.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Superior room with a beautiful view and modern amenities.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2027, 4, 1, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 374.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Presidential suite. Perfect for a romantic weekend.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 2, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 881.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Penthouse suite with a stunning view.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2027, 10, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 192.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Studio suite with a private balcony.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 9, 30, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 942.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Double room with a cozy atmosphere.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 8, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1683.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Twin room. Spacious room with a breathtaking view of the city.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 3, 31, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 109.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Triple room with a cozy atmosphere and a beautiful view.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2027, 9, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1378.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the King room with a comfortable atmosphere and a stunning view.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 9, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1620.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Queen room with a beautiful view and modern amenities.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 10, 17, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1681.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Single room. Perfect for a romantic weekend.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2027, 5, 17, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1463.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Luxury suite with a stunning view.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2027, 10, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 819.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Deluxe room with a private balcony.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2027, 4, 29, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 563.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Standard room with a cozy atmosphere.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 3, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 288.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Family room. Spacious room with a breathtaking view of the city.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 4, 5, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 976.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2027, 7, 16, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 287.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Executive room with a comfortable atmosphere and a stunning view.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 5, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 413.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Superior room with a beautiful view and modern amenities.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1118.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Presidential suite. Perfect for a romantic weekend.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 11, 14, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1339.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Penthouse suite with a stunning view.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 10, 29, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1093.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Studio suite with a private balcony.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2027, 1, 3, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1222.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Double room with a cozy atmosphere.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 7, 6, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 350.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Twin room. Spacious room with a breathtaking view of the city.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2027, 6, 12, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1143.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Triple room with a cozy atmosphere and a beautiful view.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 12, 4, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1481.0, new DateTime(2023, 11, 25, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the King room with a comfortable atmosphere and a stunning view.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2027, 7, 16, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1072.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Queen room with a beautiful view and modern amenities.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 9, 8, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 508.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Single room. Perfect for a romantic weekend.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 6, 9, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 670.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite with a stunning view.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 5, 15, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 722.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Deluxe room with a private balcony.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2027, 8, 4, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 817.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Standard room with a cozy atmosphere.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2027, 7, 10, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 175.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Family room. Spacious room with a breathtaking view of the city.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 1, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 969.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Junior suite with a cozy atmosphere and a beautiful view.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 1, 13, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 667.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Executive room with a comfortable atmosphere and a stunning view.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 12, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1514.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Superior room with a beautiful view and modern amenities.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 5, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1891.0, new DateTime(2023, 11, 27, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Presidential suite. Perfect for a romantic weekend.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2027, 5, 3, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 133.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Penthouse suite with a stunning view.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 6, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1086.0, new DateTime(2023, 11, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Studio suite with a private balcony.\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 7, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 547.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Double room with a cozy atmosphere.\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 4, 28, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 272.0, new DateTime(2023, 11, 26, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Twin room. Spacious room with a breathtaking view of the city.\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 8, 6, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 117.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Triple room with a cozy atmosphere and a beautiful view.\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 12, 18, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 625.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the King room with a comfortable atmosphere and a stunning view.\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2027, 12, 16, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1264.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Queen room with a beautiful view and modern amenities.\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2027, 5, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 745.0, new DateTime(2023, 11, 20, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Single room. Perfect for a romantic weekend.\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 11, 30, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1712.0, new DateTime(2023, 11, 21, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Luxury suite with a stunning view.\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 11, 18, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1712.0, new DateTime(2023, 11, 19, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Deluxe room with a private balcony.\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 2, 15, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 656.0, new DateTime(2023, 11, 24, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Standard room with a cozy atmosphere.\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 9, 8, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 505.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Family room. Spacious room with a breathtaking view of the city.\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 7, 22, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394), 1989.0, new DateTime(2023, 11, 23, 20, 29, 41, 655, DateTimeKind.Utc).AddTicks(4394) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Luxury suite.  with a stunning view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2024, 11, 21, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9467), 1876.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Deluxe room.  with a private balcony..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 8, 30, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9479), 190.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Single room.  with a cozy atmosphere..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 8, 5, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9485), 675.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 3, 20, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9522), 1569.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 10, 31, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9529), 1299.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2024, 2, 8, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9535), 1929.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9534) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2023, 12, 5, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9541), 690.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room. . Perfect for a romantic weekend..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 1, 8, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9547), 316.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9546) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Single room.  with a stunning view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 6, 22, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9554), 1206.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9552) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Luxury suite.  with a private balcony..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 2, 6, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9560), 1585.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Deluxe room.  with a cozy atmosphere..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2024, 5, 31, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9566), 1707.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 1, 30, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9593), 1645.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2024, 5, 1, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9599), 113.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 5, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9605), 1066.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Single room.  with a beautiful view and modern amenities..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 1, 15, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9610), 1611.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9609) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Luxury suite. . Perfect for a romantic weekend..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 3, 10, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9616), 264.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Deluxe room.  with a stunning view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 8, 2, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9621), 968.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Single room.  with a private balcony..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 7, 2, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9627), 436.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite.  with a cozy atmosphere..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 7, 20, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9632), 786.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9631) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2024, 2, 10, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9659), 1080.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9658) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 2, 7, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9665), 1055.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2024, 3, 9, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9671), 1380.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2024, 5, 16, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9676), 1423.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Single room. . Perfect for a romantic weekend..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 7, 31, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9682), 494.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Luxury suite.  with a stunning view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 7, 3, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9687), 1984.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room.  with a private balcony..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2024, 9, 16, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9693), 691.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Single room.  with a cozy atmosphere..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 3, 14, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9698), 1024.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2024, 7, 6, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9726), 905.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9725) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2024, 6, 25, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9732), 192.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9731) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2024, 1, 3, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9738), 498.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9736) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 2, 9, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9743), 1235.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9741) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room. . Perfect for a romantic weekend..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2024, 8, 6, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9748), 1457.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Single room.  with a stunning view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 6, 4, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9754), 1705.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9752) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite.  with a private balcony..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 3, 4, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9759), 388.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9758) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Deluxe room.  with a cozy atmosphere..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 8, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9765), 156.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9763) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 7, 20, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9791), 1918.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 2, 2, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9797), 1637.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 9, 14, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9805), 881.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Single room.  with a beautiful view and modern amenities..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 2, 23, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9811), 1071.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Luxury suite. . Perfect for a romantic weekend..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 6, 8, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9817), 1067.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9815) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room.  with a stunning view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 10, 16, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9822), 147.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9821) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Single room.  with a private balcony..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 2, 1, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9828), 141.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9826) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Luxury suite.  with a cozy atmosphere..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 2, 17, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9833), 934.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 9, 14, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9862), 1950.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 10, 4, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9868), 1926.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2024, 5, 4, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9873), 844.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 8, 19, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9879), 1416.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Single room. . Perfect for a romantic weekend..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2024, 4, 13, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9884), 968.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Luxury suite.  with a stunning view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 3, 3, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9890), 448.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room.  with a private balcony..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 12, 23, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9895), 1571.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Single room.  with a cozy atmosphere..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 6, 17, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9901), 722.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 6, 11, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9928), 792.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 9, 6, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9933), 1620.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 1, 24, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9939), 1610.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 2, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9944), 564.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Deluxe room. . Perfect for a romantic weekend..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 8, 9, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9950), 157.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Single room.  with a stunning view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2024, 10, 13, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9955), 775.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Luxury suite.  with a private balcony..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2024, 5, 14, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9960), 1611.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Deluxe room.  with a cozy atmosphere..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 3, 30, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9966), 1111.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 6, 23, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9972), 917.0, new DateTime(2023, 11, 18, 19, 54, 8, 483, DateTimeKind.Utc).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 11, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(11), 1236.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 8, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(17), 1998.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Single room.  with a beautiful view and modern amenities..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 8, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(23), 1632.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Luxury suite. . Perfect for a romantic weekend..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2024, 6, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(28), 776.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Deluxe room.  with a stunning view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 3, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(34), 441.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(32) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Single room.  with a private balcony..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 1, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(39), 558.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(38) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Luxury suite.  with a cozy atmosphere..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 7, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(45), 1209.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 6, 5, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(50), 1333.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(49) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2024, 6, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(77), 545.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 10, 2, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(83), 317.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 4, 12, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(89), 1725.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Single room. . Perfect for a romantic weekend..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 11, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(94), 1979.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(93) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Luxury suite.  with a stunning view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 7, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(100), 316.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Deluxe room.  with a private balcony..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 8, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(105), 1427.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(104) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Single room.  with a cozy atmosphere..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 2, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(111), 1979.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 8, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(116), 1501.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(115) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 6, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(144), 473.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(143) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 6, 5, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(150), 1162.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(148) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 5, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(155), 1416.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Deluxe room. . Perfect for a romantic weekend..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2024, 8, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(160), 976.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Single room.  with a stunning view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 2, 12, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(166), 1601.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Luxury suite.  with a private balcony..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 3, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(171), 471.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room.  with a cozy atmosphere..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 4, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(177), 1061.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(175) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2024, 10, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(182), 1441.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 3, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(209), 1834.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 10, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(215), 1306.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Single room.  with a beautiful view and modern amenities..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2024, 10, 14, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(220), 1405.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Luxury suite. . Perfect for a romantic weekend..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 12, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(226), 195.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Deluxe room.  with a stunning view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 10, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(231), 772.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Single room.  with a private balcony..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 5, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(237), 114.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Luxury suite.  with a cozy atmosphere..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2024, 10, 2, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(242), 282.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 2, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(247), 145.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 10, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(276), 349.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2024, 12, 17, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(282), 1087.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 11, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(287), 1585.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Single room. . Perfect for a romantic weekend..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2024, 10, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(293), 1409.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Luxury suite.  with a stunning view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 6, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(298), 1383.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Deluxe room.  with a private balcony..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 9, 14, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(303), 881.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(302) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Single room.  with a cozy atmosphere..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 4, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(309), 1484.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 8, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(314), 1306.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 6, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(320), 1336.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 7, 24, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(347), 1077.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(345) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 8, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(353), 1740.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room. . Perfect for a romantic weekend..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2024, 5, 17, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(358), 1518.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(357) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Single room.  with a stunning view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2024, 11, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(363), 840.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Luxury suite.  with a private balcony..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 7, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(369), 108.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(367) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room.  with a cozy atmosphere..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 9, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(374), 1979.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(373) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 10, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(379), 1594.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2024, 7, 17, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(408), 1977.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 3, 13, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(414), 1522.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Single room.  with a beautiful view and modern amenities..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 3, 4, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(419), 370.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Luxury suite. . Perfect for a romantic weekend..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 12, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(425), 515.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room.  with a stunning view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 6, 4, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(430), 286.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Single room.  with a private balcony..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2024, 11, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(436), 1636.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(434) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite.  with a cozy atmosphere..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 6, 17, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(441), 1693.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2024, 4, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(447), 1155.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2024, 11, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(452), 1738.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 1, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(480), 1588.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2024, 9, 4, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(485), 373.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Single room. . Perfect for a romantic weekend..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 9, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(491), 964.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Luxury suite.  with a stunning view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2024, 7, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(496), 291.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Deluxe room.  with a private balcony..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2024, 8, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(501), 713.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Single room.  with a cozy atmosphere..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 1, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(507), 1617.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 10, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(512), 519.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2024, 12, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(517), 528.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 7, 12, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(554), 956.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 10, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(560), 1670.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Deluxe room. . Perfect for a romantic weekend..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 6, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(566), 1174.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(564) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Single room.  with a stunning view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 12, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(571), 1412.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(570) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Luxury suite.  with a private balcony..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 5, 31, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(576), 1069.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Deluxe room.  with a cozy atmosphere..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 8, 13, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(582), 1542.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 11, 24, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(587), 1196.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(586) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 3, 12, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(593), 1367.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2024, 7, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(620), 1058.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Single room.  with a beautiful view and modern amenities..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2024, 8, 9, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(626), 757.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(625) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Luxury suite. . Perfect for a romantic weekend..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 9, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(632), 281.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Deluxe room.  with a stunning view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 7, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(637), 846.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(635) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Single room.  with a private balcony..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2024, 7, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(642), 549.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(641) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Luxury suite.  with a cozy atmosphere..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 5, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(648), 1281.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 10, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(653), 1468.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2024, 9, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(658), 1648.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 8, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(690), 1325.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 12, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(695), 1615.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Single room. . Perfect for a romantic weekend..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2024, 9, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(700), 1301.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(699) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite.  with a stunning view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 5, 3, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(706), 1770.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(704) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room.  with a private balcony..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 12, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(711), 1694.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Single room.  with a cozy atmosphere..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 7, 26, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(721), 999.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(719) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2024, 10, 3, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(729), 133.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2027, 1, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(737), 1165.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(735) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 2, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(778), 265.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 2, 17, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(786), 1869.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Deluxe room. . Perfect for a romantic weekend..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 11, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(793), 168.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(791) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Single room.  with a stunning view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 9, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(801), 991.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(799) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Luxury suite.  with a private balcony..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 6, 20, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(809), 449.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(807) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room.  with a cozy atmosphere..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 11, 12, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(817), 737.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 12, 20, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(825), 1036.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 10, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(833), 593.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 11, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(841), 1989.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Single room.  with a beautiful view and modern amenities..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 6, 9, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(877), 1807.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(875) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Luxury suite. . Perfect for a romantic weekend..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 5, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(885), 400.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room.  with a stunning view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 1, 31, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(893), 408.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Single room.  with a private balcony..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2024, 7, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(900), 1452.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(899) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Luxury suite.  with a cozy atmosphere..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 9, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(907), 1095.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2024, 12, 3, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(914), 607.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(912) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2024, 6, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(921), 1916.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 4, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(927), 789.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(925) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 3, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(961), 823.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Single room. . Perfect for a romantic weekend..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 11, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(968), 1637.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(966) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Luxury suite.  with a stunning view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 5, 12, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(975), 1178.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(973) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Deluxe room.  with a private balcony..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 1, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(982), 1493.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Single room.  with a cozy atmosphere..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 6, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(989), 844.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 5, 12, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(994), 663.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(993) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 4, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(999), 270.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(998) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2024, 7, 3, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1005), 1483.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 1, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1031), 343.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Deluxe room. . Perfect for a romantic weekend..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 11, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1037), 1448.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1035) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Single room.  with a stunning view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 11, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1042), 312.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Luxury suite.  with a private balcony..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 4, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1047), 353.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Deluxe room.  with a cozy atmosphere..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2024, 10, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1052), 1091.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1051) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2027, 1, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1058), 1822.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2024, 6, 2, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1063), 1475.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 10, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1068), 1654.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Single room.  with a beautiful view and modern amenities..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2024, 9, 19, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1095), 965.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1094) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite. . Perfect for a romantic weekend..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 10, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1101), 1466.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Deluxe room.  with a stunning view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 10, 2, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1107), 875.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Single room.  with a private balcony..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 5, 4, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1112), 559.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Luxury suite.  with a cozy atmosphere..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2024, 9, 5, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1117), 1764.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1116) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 3, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1123), 1078.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 8, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1128), 1694.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1126) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2024, 11, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1133), 329.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 4, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1203), 703.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1202) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Single room. . Perfect for a romantic weekend..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 11, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1209), 1360.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1208) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Luxury suite.  with a stunning view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2024, 10, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1214), 863.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1213) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Deluxe room.  with a private balcony..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2024, 10, 19, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1220), 1091.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1218) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Single room.  with a cozy atmosphere..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 1, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1225), 822.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1224) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 7, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1231), 1304.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1229) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2027, 2, 17, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1236), 542.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 7, 9, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1242), 925.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 1, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1279), 421.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1278) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Deluxe room. . Perfect for a romantic weekend..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 12, 31, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1285), 201.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1284) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Single room.  with a stunning view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 9, 3, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1290), 1511.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1289) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Luxury suite.  with a private balcony..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 5, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1296), 1034.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1294) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Deluxe room.  with a cozy atmosphere..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 10, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1301), 144.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2024, 11, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1306), 1059.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 3, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1312), 891.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2024, 9, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1317), 880.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1316) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Single room.  with a beautiful view and modern amenities..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 7, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1349), 1157.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1347) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite. . Perfect for a romantic weekend..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 12, 20, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1354), 1782.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1353) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Deluxe room.  with a stunning view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2027, 2, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1359), 1025.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1358) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Single room.  with a private balcony..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 8, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1365), 1640.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Luxury suite.  with a cozy atmosphere..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 10, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1370), 574.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1369) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 2, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1375), 1665.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2024, 11, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1381), 1111.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1379) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 12, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1386), 1434.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2024, 7, 17, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1412), 486.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1411) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Single room. . Perfect for a romantic weekend..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 10, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1418), 1377.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1416) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite.  with a stunning view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 8, 3, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1423), 1874.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1421) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room.  with a private balcony..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2024, 7, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1428), 181.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1427) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Single room.  with a cozy atmosphere..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 5, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1433), 1450.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1432) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 12, 9, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1439), 676.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1437) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 11, 2, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1444), 472.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 9, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1449), 1307.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1448) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2027, 1, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1475), 1097.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1474) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room. . Perfect for a romantic weekend..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 7, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1481), 126.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1480) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Single room.  with a stunning view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 5, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1486), 543.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1485) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Luxury suite.  with a private balcony..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 3, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1491), 1988.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room.  with a cozy atmosphere..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 1, 9, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1497), 576.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 4, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1502), 1949.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1501) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 4, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1507), 746.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1506) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 10, 24, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1513), 353.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1511) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Single room.  with a beautiful view and modern amenities..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 11, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1542), 1050.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Luxury suite. . Perfect for a romantic weekend..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 2, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1548), 1505.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Deluxe room.  with a stunning view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 3, 24, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1553), 463.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Single room.  with a private balcony..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 9, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1558), 1720.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Luxury suite.  with a cozy atmosphere..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 3, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1564), 1361.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2027, 3, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1569), 113.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1568) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 8, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1574), 1106.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 6, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1580), 1439.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Deluxe room.  with a beautiful view and modern amenities..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 3, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1609), 1658.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Single room. . Perfect for a romantic weekend..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 1, 13, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1614), 1866.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Luxury suite.  with a stunning view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 1, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1620), 1023.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room.  with a private balcony..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 6, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1625), 217.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Single room.  with a cozy atmosphere..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 8, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1630), 338.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 7, 4, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1635), 264.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2027, 4, 5, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1641), 1728.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2024, 8, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1646), 1616.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 7, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1651), 1167.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Deluxe room. . Perfect for a romantic weekend..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 7, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1681), 370.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Single room.  with a stunning view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 7, 24, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1687), 1556.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1685) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Luxury suite.  with a private balcony..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 1, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1692), 269.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room.  with a cozy atmosphere..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 10, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1697), 1998.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 12, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1703), 114.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 5, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1708), 697.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 12, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1713), 352.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Single room.  with a beautiful view and modern amenities..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 6, 19, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1718), 1820.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Luxury suite. . Perfect for a romantic weekend..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 3, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1749), 1362.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room.  with a stunning view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 9, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1755), 718.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Single room.  with a private balcony..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 5, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1760), 1619.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1758) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite.  with a cozy atmosphere..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 9, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1765), 238.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 8, 2, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1770), 1916.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1769) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 5, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1776), 1771.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2024, 8, 19, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1781), 1106.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1780) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 1, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1786), 1032.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Single room. . Perfect for a romantic weekend..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 4, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1823), 928.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Luxury suite.  with a stunning view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2027, 3, 26, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1828), 1170.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Deluxe room.  with a private balcony..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 7, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1833), 1931.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Single room.  with a cozy atmosphere..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2024, 9, 5, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1839), 294.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 5, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1844), 937.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2027, 3, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1849), 950.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1848) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2027, 3, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1855), 1713.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 1, 24, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1860), 1793.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1859) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Deluxe room. . Perfect for a romantic weekend..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 4, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1890), 277.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1888) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Single room.  with a stunning view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 7, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1895), 917.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Luxury suite.  with a private balcony..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2024, 12, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1901), 939.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room.  with a cozy atmosphere..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 12, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1906), 980.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1904) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 1, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1911), 982.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2024, 10, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1916), 1553.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 10, 26, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1921), 1392.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Single room.  with a beautiful view and modern amenities..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 7, 9, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1927), 1756.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1925) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Luxury suite. . Perfect for a romantic weekend..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 12, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1953), 453.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Deluxe room.  with a stunning view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 1, 19, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1959), 711.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Single room.  with a private balcony..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2027, 5, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1965), 130.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite.  with a cozy atmosphere..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 10, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1970), 1470.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 11, 20, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1975), 333.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1974) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 3, 4, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1981), 1174.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1979) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2024, 11, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1986), 776.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1984) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 11, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1991), 515.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Single room. . Perfect for a romantic weekend..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 7, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1997), 1555.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Luxury suite.  with a stunning view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 12, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2022), 431.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2021) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Deluxe room.  with a private balcony..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 2, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2028), 190.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2026) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Single room.  with a cozy atmosphere..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 7, 24, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2033), 1341.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2024, 12, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2038), 479.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 8, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2044), 853.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2042) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2027, 5, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2049), 1373.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 7, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2054), 1555.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room. . Perfect for a romantic weekend..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2027, 1, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2081), 1095.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Single room.  with a stunning view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 3, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2086), 306.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Luxury suite.  with a private balcony..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 12, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2091), 941.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Deluxe room.  with a cozy atmosphere..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 1, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2097), 1165.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2095) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 10, 20, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2102), 1485.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2024, 12, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2107), 731.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 7, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2112), 739.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Single room.  with a beautiful view and modern amenities..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 8, 14, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2118), 392.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2116) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Luxury suite. . Perfect for a romantic weekend..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2027, 2, 19, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2123), 976.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Deluxe room.  with a stunning view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 9, 12, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2151), 374.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Single room.  with a private balcony..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 4, 5, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2156), 928.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Luxury suite.  with a cozy atmosphere..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 4, 24, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2161), 1454.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 10, 14, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2167), 484.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2165) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 2, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2172), 573.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2170) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 4, 24, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2177), 800.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 7, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2182), 712.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Single room. . Perfect for a romantic weekend..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2027, 4, 19, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2188), 1681.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Luxury suite.  with a stunning view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 1, 3, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2219), 595.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room.  with a private balcony..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 4, 13, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2224), 450.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Single room.  with a cozy atmosphere..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 5, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2230), 774.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2027, 4, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2235), 1882.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 5, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2240), 1448.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 3, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2245), 133.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2027, 1, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2251), 893.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2249) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Deluxe room. . Perfect for a romantic weekend..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2027, 6, 17, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2256), 255.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Single room.  with a stunning view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 4, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2287), 1410.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Luxury suite.  with a private balcony..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 7, 20, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2292), 241.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Deluxe room.  with a cozy atmosphere..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 4, 5, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2297), 1907.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2027, 6, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2303), 811.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 7, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2308), 399.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2307) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 8, 26, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2313), 682.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2312) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Single room.  with a beautiful view and modern amenities..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 9, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2319), 836.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Luxury suite. . Perfect for a romantic weekend..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 1, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2324), 783.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Deluxe room.  with a stunning view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 8, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2357), 1582.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2355) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Single room.  with a private balcony..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 5, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2362), 361.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Luxury suite.  with a cozy atmosphere..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 9, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2368), 1183.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 10, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2373), 819.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 2, 2, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2378), 308.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2377) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 3, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2383), 1214.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Deluxe room.  with a beautiful view and modern amenities..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 11, 17, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2389), 588.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2388) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Single room. . Perfect for a romantic weekend..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 10, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2394), 1039.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Luxury suite.  with a stunning view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2027, 3, 3, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2421), 1375.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Deluxe room.  with a private balcony..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2024, 12, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2427), 1991.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2425) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Single room.  with a cozy atmosphere..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 3, 4, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2432), 1552.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2431) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 1, 14, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2438), 1481.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2436) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 4, 19, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2443), 1899.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2441) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 8, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2448), 442.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2024, 11, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2453), 735.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2452) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Deluxe room. . Perfect for a romantic weekend..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 1, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2458), 1481.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2457) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Single room.  with a stunning view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 3, 9, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2464), 1590.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2462) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Luxury suite.  with a private balcony..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2027, 2, 13, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2490), 668.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room.  with a cozy atmosphere..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 2, 19, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2495), 453.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2494) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 4, 13, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2501), 293.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 4, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2506), 485.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2504) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 7, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2511), 1262.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Single room.  with a beautiful view and modern amenities..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 3, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2516), 950.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite. . Perfect for a romantic weekend..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 1, 19, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2522), 443.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2521) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room.  with a stunning view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 3, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2527), 380.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Single room.  with a private balcony..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 2, 4, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2556), 1993.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2555) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Luxury suite.  with a cozy atmosphere..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 6, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2562), 1355.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2027, 3, 31, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2567), 1512.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 7, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2573), 1191.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 3, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2578), 649.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 8, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2583), 136.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Single room. . Perfect for a romantic weekend..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 7, 24, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2589), 1046.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2587) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Luxury suite.  with a stunning view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 8, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2594), 1717.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Deluxe room.  with a private balcony..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 7, 31, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2620), 571.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Single room.  with a cozy atmosphere..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 3, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2625), 1171.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 12, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2631), 1728.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2629) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 5, 31, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2636), 1256.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2027, 5, 5, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2641), 707.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 10, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2647), 499.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2645) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room. . Perfect for a romantic weekend..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 3, 4, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2652), 1001.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Single room.  with a stunning view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2027, 1, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2657), 1421.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Luxury suite.  with a private balcony..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 8, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2685), 1258.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2683) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Deluxe room.  with a cozy atmosphere..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 5, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2690), 1250.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2689) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 7, 19, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2696), 845.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2027, 6, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2701), 431.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 2, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2706), 148.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Single room.  with a beautiful view and modern amenities..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 4, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2711), 366.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Luxury suite. . Perfect for a romantic weekend..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 1, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2717), 1538.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room.  with a stunning view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 2, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2722), 1141.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2721) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Single room.  with a private balcony..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 9, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2749), 147.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite.  with a cozy atmosphere..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2027, 5, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2754), 471.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 1, 26, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2760), 1421.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 2, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2765), 1226.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 4, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2770), 208.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Deluxe room.  with a beautiful view and modern amenities..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2027, 5, 13, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2775), 1746.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Single room. . Perfect for a romantic weekend..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2027, 2, 20, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2781), 637.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2779) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Luxury suite.  with a stunning view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2027, 6, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2786), 484.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Deluxe room.  with a private balcony..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 4, 9, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2812), 1347.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Single room.  with a cozy atmosphere..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 2, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2818), 1339.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 8, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2823), 953.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 11, 9, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2828), 1773.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 10, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2833), 1749.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 7, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2839), 1208.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Deluxe room. . Perfect for a romantic weekend..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 9, 14, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2844), 1075.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Single room.  with a stunning view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2027, 3, 26, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2850), 163.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Luxury suite.  with a private balcony..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 10, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2882), 1648.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Deluxe room.  with a cozy atmosphere..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 5, 4, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2888), 1629.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 7, 14, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2893), 736.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 1, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2899), 689.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 12, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2904), 738.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2903) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Single room.  with a beautiful view and modern amenities..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2027, 5, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2909), 1196.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite. . Perfect for a romantic weekend..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2027, 3, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2915), 287.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2913) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Deluxe room.  with a stunning view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 9, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2920), 1309.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Single room.  with a private balcony..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 3, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2925), 443.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Luxury suite.  with a cozy atmosphere..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2025, 4, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2954), 1707.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 8, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2959), 1874.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 2, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2965), 1286.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 7, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2970), 722.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 11, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2975), 974.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Single room. . Perfect for a romantic weekend..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 5, 9, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2980), 1115.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Luxury suite.  with a stunning view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 8, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2986), 811.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Deluxe room.  with a private balcony..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 9, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2991), 485.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Single room.  with a cozy atmosphere..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 8, 5, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3019), 1035.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2027, 7, 7, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3024), 1866.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3023) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2027, 7, 12, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3029), 817.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2027, 1, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3035), 1649.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3033) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2027, 7, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3040), 1024.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Deluxe room. . Perfect for a romantic weekend..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 3, 5, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3045), 632.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Single room.  with a stunning view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 1, 14, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3051), 648.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Luxury suite.  with a private balcony..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 11, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3056), 605.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Deluxe room.  with a cozy atmosphere..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 1, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3085), 1919.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 9, 24, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3091), 255.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 7, 26, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3096), 1388.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 6, 19, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3101), 458.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Single room.  with a beautiful view and modern amenities..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2027, 3, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3107), 962.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Luxury suite. . Perfect for a romantic weekend..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2027, 6, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3112), 411.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3111) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Deluxe room.  with a stunning view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2027, 4, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3117), 1056.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Single room.  with a private balcony..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 1, 2, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3123), 612.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Luxury suite.  with a cozy atmosphere..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 9, 17, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3153), 1001.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 7, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3158), 875.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 7, 2, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3164), 1831.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 6, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3169), 1925.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 5, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3174), 1848.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Single room. . Perfect for a romantic weekend..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2025, 7, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3179), 1101.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Luxury suite.  with a stunning view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2027, 1, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3185), 1705.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3183) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room.  with a private balcony..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2027, 3, 15, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3190), 1356.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Single room.  with a cozy atmosphere..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2027, 4, 26, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3226), 1241.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 1, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3231), 1489.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2027, 2, 11, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3237), 164.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 11, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3242), 145.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 10, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3247), 1923.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Deluxe room. . Perfect for a romantic weekend..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 4, 20, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3252), 1966.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Single room.  with a stunning view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2025, 10, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3258), 1024.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Luxury suite.  with a private balcony..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2027, 9, 12, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3263), 1439.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room.  with a cozy atmosphere..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 4, 20, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3268), 1986.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 7, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3295), 1835.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 1, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3300), 1827.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 2, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3306), 1939.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Single room.  with a beautiful view and modern amenities..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2027, 3, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3311), 845.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Luxury suite. . Perfect for a romantic weekend..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2026, 9, 13, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3316), 629.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Deluxe room.  with a stunning view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3322), 965.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Single room.  with a private balcony..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2027, 6, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3327), 1888.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Luxury suite.  with a cozy atmosphere..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2027, 10, 17, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3332), 729.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 2, 17, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3360), 844.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3359) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 12, 14, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3365), 1152.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3364) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 10, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3371), 1652.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2027, 5, 1, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3376), 573.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Single room. . Perfect for a romantic weekend..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 4, 2, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3381), 1171.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Luxury suite.  with a stunning view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2026, 8, 3, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3387), 1347.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Deluxe room.  with a private balcony..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2027, 10, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3392), 1404.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Single room.  with a cozy atmosphere..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2027, 2, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3398), 1414.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3396) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 6, 8, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3430), 1844.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2026, 5, 13, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3436), 1914.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3435) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2026, 11, 5, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3441), 820.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 4, 28, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3446), 190.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Deluxe room. . Perfect for a romantic weekend..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2026, 8, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3452), 1961.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 4, "Experience the Single room.  with a stunning view..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2027, 9, 14, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3457), 1312.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Luxury suite.  with a private balcony..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 6, 26, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3462), 806.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Deluxe room.  with a cozy atmosphere..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 4, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3467), 1227.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Single room. . Spacious room with a breathtaking view of the city..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2027, 3, 24, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3494), 1048.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3492) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2027, 9, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3499), 635.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3498) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2027, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3505), 1635.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Single room.  with a beautiful view and modern amenities..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 4, 20, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3510), 1730.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3508) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Luxury suite. . Perfect for a romantic weekend..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 9, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3515), 731.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3514) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Deluxe room.  with a stunning view..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 11, 14, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3520), 1265.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3519) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Single room.  with a private balcony..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2027, 6, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3526), 1943.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3524) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Luxury suite.  with a cozy atmosphere..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2027, 6, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3531), 1581.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 6, 10, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3559), 866.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2026, 1, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3564), 1423.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3563) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Luxury suite.  with a comfortable atmosphere and a stunning view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2025, 6, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3570), 957.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3568) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Deluxe room.  with a beautiful view and modern amenities..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2025, 10, 24, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3575), 1778.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3574) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Single room. . Perfect for a romantic weekend..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2027, 12, 5, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3580), 911.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3579) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 7, "Experience the Luxury suite.  with a stunning view..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2027, 3, 26, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3586), 519.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room.  with a private balcony..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2026, 3, 27, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3591), 1884.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3589) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Single room.  with a cozy atmosphere..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 6, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3596), 977.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3595) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Luxury suite. . Spacious room with a breathtaking view of the city..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 12, 4, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3624), 377.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Deluxe room.  with a cozy atmosphere and a beautiful view..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2027, 6, 17, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3629), 1808.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3628) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Single room.  with a comfortable atmosphere and a stunning view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2025, 11, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3634), 1877.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3633) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Luxury suite.  with a beautiful view and modern amenities..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2027, 3, 23, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3640), 1461.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Deluxe room. . Perfect for a romantic weekend..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 5, 20, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3645), 1743.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Single room.  with a stunning view..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 3, 4, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3650), 616.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Luxury suite.  with a private balcony..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2027, 9, 21, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3655), 629.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Deluxe room.  with a cozy atmosphere..\nOur hotel is a haven of tranquility and relaxation, where you can escape the hustle and bustle of the city. Our rooms are cozy and inviting, with soft beds and pillows, and soothing colors. Our hotel also features a pool, a garden, and a lounge, where you can unwind and recharge. Our hotel is also close to nature, with many parks, trails, and beaches nearby. Book your room now and treat yourself to our hotel.", new DateTime(2026, 7, 22, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3661), 1691.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3659) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Single room. . Spacious room with a breathtaking view of the city..\nOur hotel is a boutique hotel that offers a unique and personalized stay. Our rooms are individually decorated, with artistic touches and original details. Our hotel also has a rooftop terrace, a library, and a café, where you can enjoy the views, the books, and the coffee. Our hotel is located in a vibrant neighborhood, with many galleries, museums, and theaters nearby. Book your room now and discover our hotel.", new DateTime(2025, 11, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3688), 1212.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3686) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 6, "Experience the Luxury suite.  with a cozy atmosphere and a beautiful view..\nOur hotel is a family-friendly hotel that offers a fun and enjoyable stay. Our rooms are spacious and bright, with plenty of space for everyone. Our hotel also has a playground, a game room, and a kids’ club, where you can have fun and make new friends. Our hotel is also near many family attractions, such as amusement parks, zoos, and aquariums. Book your room now and have a blast at our hotel.", new DateTime(2025, 11, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3693), 113.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3692) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 5, "Experience the Deluxe room.  with a comfortable atmosphere and a stunning view..\nOur hotel is a business hotel that offers a professional and productive stay. Our rooms are sleek and modern, with high-speed internet, work desks, and ergonomic chairs. Our hotel also has a business center, a meeting room, and a conference hall, where you can conduct your work and events. Our hotel is also near the airport, the train station, and the business district. Book your room now and get down to business at our hotel.", new DateTime(2025, 11, 16, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3698), 719.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { "Experience the Single room.  with a beautiful view and modern amenities..\nEnjoy the serenity and comfort of our rooms, each equipped with modern amenities. Our dedicated staff is here to ensure your stay is as comfortable as possible. Book now and discover the luxury of our hotel.", new DateTime(2025, 11, 3, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3704), 1894.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3702) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 9, "Experience the Luxury suite. . Perfect for a romantic weekend..\nExperience the elegance and charm of our hotel, where you can relax in our spacious rooms, enjoy our delicious cuisine, and explore the nearby attractions. Whether you are traveling for business or pleasure, our hotel will make you feel at home. Reserve your room today and get ready for an unforgettable stay.", new DateTime(2026, 11, 6, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3709), 135.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 3, "Experience the Deluxe room.  with a stunning view..\nOur hotel is the perfect destination for travelers who want to experience the best of the city. Our rooms are cozy and stylish, with all the amenities you need. Our friendly staff will help you with anything you need, from booking tours to arranging transportation. Don’t miss our amazing deals and offers. Book your room now and enjoy our hotel.", new DateTime(2027, 9, 3, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3714), 1881.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 2, "Experience the Single room.  with a private balcony..\nWelcome to our hotel, where you can find comfort, convenience, and quality. Our rooms are designed to suit your needs, with modern facilities and services. Our hotel is located in the heart of the city, close to shopping, dining, and entertainment. Whether you are here for work or leisure, our hotel will make your stay memorable. Book now and take advantage of our special rates.", new DateTime(2026, 10, 30, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3719), 629.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3718) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 8, "Experience the Luxury suite.  with a cozy atmosphere..\nDiscover the beauty and culture of the city at our hotel, where you can enjoy a relaxing and luxurious stay. Our rooms are spacious and elegant, with stunning views of the city. Our hotel offers a range of amenities and services, including a fitness center, a spa, and a restaurant. Our hotel is also close to many attractions and landmarks. Book your room now and experience our hotel.", new DateTime(2025, 4, 25, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3725), 369.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3723) });

            migrationBuilder.UpdateData(
                table: "HotelOffers",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "Capacity", "Description", "EndDate", "Price", "StartDate" },
                values: new object[] { 1, "Experience the Deluxe room. . Spacious room with a breathtaking view of the city..\nOur hotel is more than just a place to sleep. It’s a place where you can feel the warmth and hospitality of our staff, the comfort and style of our rooms, and the taste and variety of our food. Our hotel is located in a prime location, with easy access to public transportation and major attractions. Whether you are here for a short or long stay, our hotel will make you feel welcome. Book now and save with our best price guarantee.", new DateTime(2026, 8, 12, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3730), 1348.0, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3729) });

            migrationBuilder.InsertData(
                table: "HotelOffers",
                columns: new[] { "Id", "AgencyId", "Capacity", "Description", "EndDate", "Price", "ProductId", "StartDate" },
                values: new object[] { 501, 2, 1, "Experience the Single room.  with a cozy atmosphere and a beautiful view..\nIf you are looking for a hotel that combines convenience, affordability, and quality, look no further than our hotel. Our rooms are clean and comfortable, with all the essentials you need. Our hotel is situated in a strategic location, with many shops, restaurants, and sights nearby. Our hotel also offers free Wi-Fi, parking, and breakfast. Book your room now and enjoy our hotel.", new DateTime(2027, 1, 29, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3758), 164.0, 2, new DateTime(2023, 11, 18, 19, 54, 8, 484, DateTimeKind.Utc).AddTicks(3756) });
        }
    }
}
