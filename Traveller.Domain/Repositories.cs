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
        public IHotelOfferRepository HotelOffers;
        public IHotelRepository Hotels;
        public IPackageOfferRepository PackageOffers;
        public IPackageRepository Packages;
        public ITourOfferRepository TourOffers;
        public ITourRepository Tours;
        public IUserRepository Users;

        public Repositories(IAgencyRepository Agencies, 
                            IFacilityRepository Facilties,
                            IFlightOfferRepository FlightOffers,
                            IFlightRepository Flights,
                            IHotelOfferRepository HotelOffers,
                            IHotelRepository Hotels,
                            IPackageOfferRepository PackageOffers,
                            IPackageRepository Packages,
                            ITourOfferRepository TourOffers,
                            ITourRepository Tours,
                            IUserRepository Users)
        {
            this.Agencies = Agencies;
            this.Facilties = Facilties;
            this.FlightOffers = FlightOffers;
            this.Flights = Flights;
            this.HotelOffers = HotelOffers;
            this.Hotels = Hotels;
            this.PackageOffers = PackageOffers;
            this.Packages = Packages;
            this.TourOffers = TourOffers;
            this.Tours = Tours;
            this.Users = Users;
        }
    }
}
