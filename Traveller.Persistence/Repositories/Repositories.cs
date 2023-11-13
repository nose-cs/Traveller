using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveller.Persistence.Repositories
{
    public class Repositories
    {
        public AgencyRepository Agencies;
        public FacilityRepository Facilties;
        public FlightRepository Flights;
        public HotelOfferRepository HotelOffers;
        public HotelRepository Hotels;
        public PackageRepository Packages;
        public TourRepository Tours;
        public UserRepository Users;

        public Repositories(AgencyRepository Agencies, 
                            FacilityRepository Facilties,
                            FlightRepository Flights,
                            HotelOfferRepository HotelOffers,
                            HotelRepository Hotels,
                            PackageRepository Packages,
                            TourRepository Tours,
                            UserRepository Users  ) 
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
