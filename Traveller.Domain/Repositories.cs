using Traveller.Domain.Interfaces.Repositories;

namespace Traveller.Domain
{
    public class Repositories
    {
        public readonly IAgencyRepository Agencies;
        public readonly IFacilityRepository Facilties;
        public readonly IFlightOfferRepository FlightOffers;
        public readonly IFlightRepository Flights;
        public readonly IFlightReservationRepository FlightReservations;
        public readonly IHotelOfferRepository HotelOffers;
        public readonly IHotelRepository Hotels;
        public readonly IHotelReservationRepository HotelReservations;
        public readonly IPackageRepository Packages;
        public readonly IPackageReservationRepository PackageReservations;
        public readonly IPackageOfferRepository PackageOffers;
        public readonly IPaymentRepository Payment;
        public readonly ITourOfferRepository TourOffers;
        public readonly ITourRepository Tours;
        public readonly ITourReservationRepository TourReservations;
        public readonly IUserRepository Users;
        public readonly IImageRepository Images;


        public Repositories(IAgencyRepository Agencies, 
                            IFacilityRepository Facilties,
                            IFlightOfferRepository FlightOffers,
                            IFlightRepository Flights,
                            IFlightReservationRepository FlightReservations,
                            IHotelOfferRepository HotelOffers,
                            IHotelRepository Hotels,
                            IHotelReservationRepository HotelReservations,
                            IPackageRepository Packages,
                            IPackageOfferRepository PackageOffers,
                            IPackageReservationRepository PackageReservations,
                            IPaymentRepository Payment,
                            ITourRepository Tours,
                            ITourOfferRepository TourOffers,
                            ITourReservationRepository TourReservations,
                            IUserRepository Users, IImageRepository images)
        {
            this.Agencies = Agencies;
            this.Facilties = Facilties;
            this.FlightOffers = FlightOffers;
            this.Flights = Flights;
            this.FlightReservations = FlightReservations;
            this.HotelOffers = HotelOffers;
            this.HotelReservations = HotelReservations;
            this.Hotels = Hotels;
            this.PackageOffers = PackageOffers;
            this.Packages = Packages;
            this.PackageReservations = PackageReservations;
            this.Payment = Payment;
            this.TourOffers = TourOffers;
            this.Tours = Tours;
            this.TourReservations = TourReservations;
            this.Users = Users;
            Images = images;
        }
    }
}
