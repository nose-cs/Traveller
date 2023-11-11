using Microsoft.EntityFrameworkCore;
using Traveller.Persistence;
using Traveller.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Register the database context postgresql
builder.Services.AddDbContext<TravellerContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("TravellerDatabase")));

builder.Services.AddScoped<HotelRepository>();
builder.Services.AddScoped<TourRepository>();

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();