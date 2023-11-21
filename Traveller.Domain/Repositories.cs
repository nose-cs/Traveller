using Traveller.Domain.Interfaces.Repositories;

namespace Traveller.Domain
{
    public class Repositories
    {
        public readonly IAgencyRepository Agencies;
        public readonly IFacilityRepository Facilties;
        public readonly IFlightOfferRepository FlightOffers;
        public readonly IFlightRepository Flights;
        public readonly IHotelOfferRepository HotelOffers;
        public readonly IHotelRepository Hotels;
        public readonly IPackageOfferRepository PackageOffers;
        public readonly IPackageRepository Packages;
        public readonly ITourOfferRepository TourOffers;
        public readonly ITourRepository Tours;
        public readonly IUserRepository Users;

        public Repositories(IAgencyRepository agencies,
            IFacilityRepository facilties,
            IFlightOfferRepository flightOffers,
            IFlightRepository flights,
            IHotelOfferRepository hotelOffers,
            IHotelRepository hotels,
            IPackageOfferRepository packageOffers,
            IPackageRepository packages,
            ITourOfferRepository tourOffers,
            ITourRepository tours,
            IUserRepository users)
        {
            Agencies = agencies;
            Facilties = facilties;
            FlightOffers = flightOffers;
            Flights = flights;
            HotelOffers = hotelOffers;
            Hotels = hotels;
            PackageOffers = packageOffers;
            Packages = packages;
            TourOffers = tourOffers;
            Tours = tours;
            Users = users;
        }
    }
}