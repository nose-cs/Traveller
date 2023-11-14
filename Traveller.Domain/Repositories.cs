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
        public IFlightRepository Flights;
        public IHotelOfferRepository HotelOffers;
        public IHotelRepository Hotels;
        public IPackageRepository Packages;
        public ITourRepository Tours;
        public IUserRepository Users;

        public Repositories(IAgencyRepository Agencies, 
                            IFacilityRepository Facilties,
                            IFlightRepository Flights,
                            IHotelOfferRepository HotelOffers,
                            IHotelRepository Hotels,
                            IPackageRepository Packages,
                            ITourRepository Tours,
                            IUserRepository Users  ) 
        {
            this.Agencies = Agencies;
            this.Facilties = Facilties;
            this.Flights = Flights;
            this.HotelOffers = HotelOffers;
            this.Hotels = Hotels;
            this.Packages = Packages;
            this.Tours = Tours;
            this.Users = Users;
        }
    }
}
