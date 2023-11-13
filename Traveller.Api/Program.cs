using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Traveller.Api.Authentication;
using Traveller.Api.Authentication.Services;
using Traveller.Persistence;
using Traveller.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Register the database context postgresql
builder.Services.AddDbContext<TravellerContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("TravellerDatabase")));

builder.Services.AddScoped<HotelRepository>();
builder.Services.AddScoped<HotelOfferRepository>();
builder.Services.AddScoped<TourRepository>();
builder.Services.AddScoped<FlightRepository>();
builder.Services.AddScoped<PackageRepository>();
builder.Services.AddScoped<FacilityRepository>();
builder.Services.AddScoped<AgencyRepository>();
builder.Services.AddScoped<UserRepository>();

builder.Services.AddScoped<Repositories>();

builder.Services.AddScoped<IJwtProvider, JwtProvider>();
builder.Services.AddScoped<IPasswordService, PasswordService>();
builder.Services.AddScoped<LoginService>();

builder.Services.AddControllers();

// Add Jwt authentication settings
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:SecretKey"]!)),
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true
    };
});

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