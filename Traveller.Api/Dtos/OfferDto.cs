using Traveller.Domain.Interfaces.Models;

namespace Traveller.Dtos
{
    public class OfferDto
    {

        public int? Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public double Price { get; set; }
        public uint Capacity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? AgencyName { get; set; }
        public int? AgencyId { get; set; }
        public string? ProductName { get; set; }
        public int ProductId { get; set; }
        public int ImageId { get; set; }

        public static void Map<TProduct, TReservation, TOffer>(TOffer offer, OfferDto offerDto) where TProduct : class, IProduct, new()
                                                                                                                 where TReservation : class, IReservation<TProduct, TReservation, TOffer>, new()
                                                                                                                 where TOffer : class, IOffer<TProduct, TReservation, TOffer>, new()
        {
            offer.Title = offerDto.Title;
            offer.Description = offerDto.Description;
            offer.Price = offerDto.Price;
            offer.Capacity = offerDto.Capacity;
            offer.StartDate = offerDto.StartDate;
            offer.EndDate = offerDto.EndDate;
            offer.ProductId = offerDto.ProductId;
            offer.ImageId = offerDto.ImageId;

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
                Title = offer.Title,
                Description = offer.Description,
                Price = offer.Price,
                Capacity = offer.Capacity,
                StartDate = offer.StartDate,
                EndDate = offer.EndDate,
                AgencyId = offer.AgencyId,
                ProductId = offer.ProductId,
                ImageId = offer.ImageId
            };
        }

    }
}
