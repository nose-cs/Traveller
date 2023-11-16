using Traveller.Domain;
using Traveller.Domain.Interfaces.Models;
using Traveller.Domain.Models;

namespace Traveller.Dtos
{
    public class OfferDto
    {

        public int? Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Capacity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? AgencyName { get; set; }
        public int? AgencyId { get; set; }
        public string? ProductName { get; set; }
        public int ProductId { get; set; }

        public static void Map<TProduct, TReservation, TOffer>(TOffer offer, OfferDto offerDto) where TProduct : class, IProduct, new()
                                                                                                                 where TReservation : class, IReservation<TProduct, TReservation, TOffer>, new()
                                                                                                                 where TOffer : class, IOffer<TProduct, TReservation, TOffer>, new()
        {
            offer.Description = offerDto.Description;
            offer.Price = offerDto.Price;
            offer.Capacity = offerDto.Capacity;
            offer.StartDate = offerDto.StartDate;
            offer.EndDate = offerDto.EndDate;
            offer.ProductId = offerDto.ProductId;

            if (offerDto.Id != null)
                offer.Id = (int)offerDto.Id;
        }
        public static OfferDto Map<TProduct, TReservation, TOffer>(TOffer offer) where TProduct : class, IProduct, new()
                                                                                where TReservation : class, IReservation<TProduct, TReservation, TOffer>, new()
                                                                                where TOffer : class, IOffer<TProduct, TReservation, TOffer>, new()
        {
            return new OfferDto()
            {
                Id = offer.Id,
                Description = offer.Description,
                Price = offer.Price,
                Capacity = offer.Capacity,
                StartDate = offer.StartDate,
                EndDate = offer.EndDate,
                AgencyId = offer.AgencyId,
                ProductId = offer.ProductId
            };
        }

    }
}
