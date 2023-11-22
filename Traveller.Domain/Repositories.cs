using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Domain.Interfaces.Repositories;

namespace Traveller.Persistence.Repositories
{
    public class Repositories
    {
        public IAgencyRepository Agencies;
        public IFacilityRepository Facilties;
        public IFlightOfferRepository FlightOffers;
        public IFlightRepository Flights;
        public IFlightReservationRepository FlightReservations;
        public IHotelOfferRepository HotelOffers;
        public IHotelRepository Hotels;
        public IHotelReservationRepository HotelReservations;
        public IPackageRepository Packages;
        public IPackageReservationRepository PackageReservations;
        public IPackageOfferRepository PackageOffers;
        public IPaymentRepository Payment;
        public ITourOfferRepository TourOffers;
        public ITourRepository Tours;
        public ITourReservationRepository TourReservations;
        public IUserRepository Users;


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
                            IUserRepository Users)
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
        }
    }
}
