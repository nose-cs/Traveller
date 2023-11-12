using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Traveller.Api.Authentication.Services;
using Traveller.Api.OptionsSetup;
using Traveller.Persistence;
using Traveller.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Register the database context postgresql
builder.Services.AddDbContext<TravellerContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("TravellerDatabase")));

builder.Services.AddScoped<HotelRepository>();
builder.Services.AddScoped<TourRepository>();
builder.Services.AddScoped<FlightRepository>();
builder.Services.AddScoped<PackageRepository>();
builder.Services.AddScoped<FacilityRepository>();
builder.Services.AddScoped<UserRepository>();

builder.Services.AddScoped<IJwtProvider, JwtProvider>();
builder.Services.AddScoped<IPasswordService, PasswordService>();
builder.Services.AddScoped<LoginService>();

builder.Services.AddControllers();

// Add Jwt authentication settings
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer();
builder.Services.ConfigureOptions<JwtOptionsSetup>();
builder.Services.ConfigureOptions<JwtBearerOptionsSetup>();

builder.Services.AddAuthorization();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin", _builder =>
    {
        _builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.MapControllers();

app.Run();