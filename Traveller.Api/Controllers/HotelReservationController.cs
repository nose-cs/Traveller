using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using Traveller.Domain;
using Traveller.Domain.Models;
using Traveller.Dtos;
using Traveller.Persistence.Repositories;

namespace Traveller.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HotelReservationController : ControllerBase
{
    private readonly Repositories _repositories;

    private readonly ILogger<HotelReservationController> _logger;

    public HotelReservationController(ILogger<HotelReservationController> logger, Repositories repositories)
    {
        _logger = logger;
        _repositories = repositories;
    }

    [HttpPost]
    [Authorize(Roles = ("Agent, Tourist"))]
    public async Task<ActionResult> Create(ReservationDto reservationDto)
    {
        if (await _repositories.HotelOffers.FindById(reservationDto.OfferId) == null)
            return NotFound($"Hotel Offer id: {reservationDto.OfferId} doesn´t exists");

        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var role = jwt.Claims.First(c => c.Type == "role").Value;
        var userId = int.Parse(jwt.Claims.First(c => c.Type == "id").Value);
        if ((role == "Tourist") && (userId != reservationDto.TouristId))
            return BadRequest($"Tourists can only make reservations for themselves");

        try
        {
            HotelReservation reservation = new HotelReservation();
            ReservationDto.Map<Hotel, HotelReservation, HotelOffer>(reservation, reservationDto);
            if (reservationDto.paymentDto.Total < reservationDto.Price)
                return BadRequest("The payment is not enough");
            await _repositories.Payment.AddAsync(PaymentDto.Map(reservationDto.paymentDto));
            await _repositories.Payment.SaveChangesAsync();
            await _repositories.HotelReservations.AddAsync(reservation);
            await _repositories.HotelReservations.SaveChangesAsync();
            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }

    [HttpPut("{id:int}")]
    [Authorize(Roles = ("Agent, Tourist"))]
    public async Task<ActionResult> Update([FromBody] ReservationDto reservationDto, [FromRoute] int id)
    {
        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var role = jwt.Claims.First(c => c.Type == "role").Value;
        var userId = int.Parse(jwt.Claims.First(c => c.Type == "id").Value);
        if ((role == "Tourist") && (userId != reservationDto.TouristId))
            return BadRequest($"Tourists can only change their own reservations");

        try
        {
            var dbHotelReservation = await _repositories.HotelReservations.FindById(id);
            if (dbHotelReservation is null)
                return NotFound($"Hotel Reservation with id {id} doesn't exist");
            int old_PaymentId = dbHotelReservation.PaymentId; //no quiero que nadie pueda modificar el PaymentId
            double old_Price = dbHotelReservation.Price; //ni los turistas el precio

            ReservationDto.Map<Hotel, HotelReservation, HotelOffer>(dbHotelReservation, reservationDto);
            dbHotelReservation.PaymentId = old_PaymentId;
            if (role == "Tourist")
                dbHotelReservation.Price = old_Price;

            await _repositories.HotelReservations.SaveChangesAsync();

            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("{id:int}")]
    [Authorize(Roles = ("Agent, Tourist"))]
    public async Task<ActionResult> Delete([FromRoute] int id)
    {
        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var role = jwt.Claims.First(c => c.Type == "role").Value;
        var userId = int.Parse(jwt.Claims.First(c => c.Type == "id").Value);

        try
        {
            var dbHotelReservation = await _repositories.HotelReservations.FindById(id);
            if (dbHotelReservation is null)
                return NotFound($"Hotel reservation with id {id} doesn't exist");
            if ((role == "Tourist") && (userId != dbHotelReservation.TouristId))
                return BadRequest($"Tourists can only delete their own reservations");
            await _repositories.Payment.Remove(dbHotelReservation.PaymentId);
            await _repositories.HotelReservations.Remove(id);
            await _repositories.Payment.SaveChangesAsync();
            await _repositories.HotelReservations.SaveChangesAsync();

            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }

    [HttpGet]
    [Authorize(Roles = ("Agent, Tourist"))]
    public ActionResult<IEnumerable<ReservationDto>> GetAll()
    {
        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var role = jwt.Claims.First(c => c.Type == "role").Value;
        var userId = int.Parse(jwt.Claims.First(c => c.Type == "id").Value);

        var dtos = _repositories.HotelReservations.Find()
            .Select(ReservationDto.Map<Hotel, HotelReservation, HotelOffer>);

        if (role == "Tourist")
            dtos = dtos.Where(rsv => (rsv.TouristId == userId));
        return Ok(dtos);
    }

    [HttpGet("{id:int}")]
    [Authorize(Roles = ("Agent, Tourist"))]
    public async Task<ActionResult> Get([FromRoute] int id)
    {
        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var role = jwt.Claims.First(c => c.Type == "role").Value;
        var userId = int.Parse(jwt.Claims.First(c => c.Type == "id").Value);

        try
        {
            var hotelReservation = await _repositories.HotelReservations.FindById(id);
            if (hotelReservation is null)
                return NotFound($"Hotel reservation with id {id} doesn't exist");
            if ((role == "Tourist") && (userId != hotelReservation.TouristId))
                return BadRequest($"Tourists can only see their own reservations");
            return Ok(ReservationDto.Map<Hotel, HotelReservation, HotelOffer>(hotelReservation));
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }
}