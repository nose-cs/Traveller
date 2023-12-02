using Traveller.Domain.Interfaces.Repositories;

namespace Traveller.Domain
{
    public class Repositories
    {
        public readonly IAgencyRepository Agencies;
        public readonly IFacilityRepository Facilities;
        public readonly IFlightOfferRepository FlightOffers;
        public readonly IFlightRepository Flights;
        public readonly IFlightReservationRepository FlightReservations;
        public readonly IHotelOfferRepository HotelOffers;
        public readonly IHotelRepository Hotels;
        public readonly IHotelReservationRepository HotelReservations;
        public readonly IPackageReservationRepository PackageReservations;
        public readonly IPackageRepository Package;
        public readonly IPaymentRepository Payment;
        public readonly ITourOfferRepository TourOffers;
        public readonly ITourRepository Tours;
        public readonly ITourReservationRepository TourReservations;
        public readonly IUserRepository Users;
        public readonly IImageRepository Images;


        public Repositories(IAgencyRepository agencies,
            IFacilityRepository facilities,
            IFlightOfferRepository flightOffers,
            IFlightRepository flights,
            IFlightReservationRepository flightReservations,
            IHotelOfferRepository hotelOffers,
            IHotelRepository hotels,
            IHotelReservationRepository hotelReservations,
            IPackageRepository package,
            IPackageReservationRepository packageReservations,
            IPaymentRepository payment,
            ITourRepository tours,
            ITourOfferRepository tourOffers,
            ITourReservationRepository tourReservations,
            IUserRepository users, 
            IImageRepository images)
        {
            Agencies = agencies;
            Facilities = facilities;
            FlightOffers = flightOffers;
            Flights = flights;
            FlightReservations = flightReservations;
            HotelOffers = hotelOffers;
            HotelReservations = hotelReservations;
            Hotels = hotels;
            Package = package;
            PackageReservations = packageReservations;
            Payment = payment;
            TourOffers = tourOffers;
            Tours = tours;
            TourReservations = tourReservations;
            Users = users;
            Images = images;
        }
    }
}