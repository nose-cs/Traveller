﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Traveller.Persistence;

#nullable disable

namespace Traveller.Persistence.Migrations
{
    [DbContext(typeof(TravellerContext))]
    partial class TravellerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ExtendedTourHotel", b =>
                {
                    b.Property<int>("ExtendedTourId")
                        .HasColumnType("integer");

                    b.Property<int>("HotelsId")
                        .HasColumnType("integer");

                    b.HasKey("ExtendedTourId", "HotelsId");

                    b.HasIndex("HotelsId");

                    b.ToTable("ExtendedTourHotel");
                });

            modelBuilder.Entity("PackageTour", b =>
                {
                    b.Property<int>("PackagesId")
                        .HasColumnType("integer");

                    b.Property<int>("ToursId")
                        .HasColumnType("integer");

                    b.HasKey("PackagesId", "ToursId");

                    b.HasIndex("ToursId");

                    b.ToTable("PackageTour");
                });

            modelBuilder.Entity("Traveller.Domain.Models.Agency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Agencies");
                });

            modelBuilder.Entity("Traveller.Domain.Models.Facility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Facilities");
                });

            modelBuilder.Entity("Traveller.Domain.Models.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Airline")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("FlightNumber")
                        .HasColumnType("integer");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("Traveller.Domain.Models.FlightOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AgencyId")
                        .HasColumnType("integer");

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AgencyId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("ProductId");

                    b.ToTable("FlightOffers");
                });

            modelBuilder.Entity("Traveller.Domain.Models.FlightReservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("NumberOfTravellers")
                        .HasColumnType("integer");

                    b.Property<int>("OfferId")
                        .HasColumnType("integer");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<int>("TouristId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("OfferId");

                    b.HasIndex("TouristId");

                    b.ToTable("FlightReservations");
                });

            modelBuilder.Entity("Traveller.Domain.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Category")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("Traveller.Domain.Models.HotelOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AgencyId")
                        .HasColumnType("integer");

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AgencyId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("ProductId");

                    b.ToTable("HotelOffers");
                });

            modelBuilder.Entity("Traveller.Domain.Models.HotelReservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("NumberOfTravellers")
                        .HasColumnType("integer");

                    b.Property<int>("OfferId")
                        .HasColumnType("integer");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<int>("TouristId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("OfferId");

                    b.HasIndex("TouristId");

                    b.ToTable("HotelReservations");
                });

            modelBuilder.Entity("Traveller.Domain.Models.Package", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("Traveller.Domain.Models.PackageFacility", b =>
                {
                    b.Property<int>("FacilityId")
                        .HasColumnType("integer");

                    b.Property<int>("PackageId")
                        .HasColumnType("integer");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.HasKey("FacilityId", "PackageId")
                        .HasName("PK_PackageFacility");

                    b.HasIndex("PackageId");

                    b.ToTable("PackageFacility");
                });

            modelBuilder.Entity("Traveller.Domain.Models.PackageOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AgencyId")
                        .HasColumnType("integer");

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AgencyId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("ProductId");

                    b.ToTable("PackageOffer");
                });

            modelBuilder.Entity("Traveller.Domain.Models.PackageReservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("NumberOfTravellers")
                        .HasColumnType("integer");

                    b.Property<int>("OfferId")
                        .HasColumnType("integer");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<int>("TouristId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("OfferId");

                    b.HasIndex("TouristId");

                    b.ToTable("PackageReservation");
                });

            modelBuilder.Entity("Traveller.Domain.Models.Tour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ArrivalDay")
                        .HasColumnType("integer");

                    b.Property<string>("ArrivalPlace")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<TimeOnly>("ArrivalTime")
                        .HasColumnType("time without time zone");

                    b.Property<int>("DepartureDay")
                        .HasColumnType("integer");

                    b.Property<string>("DeparturePlace")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<TimeOnly>("DepartureTime")
                        .HasColumnType("time without time zone");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Tours");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Tour");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Traveller.Domain.Models.TourOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AgencyId")
                        .HasColumnType("integer");

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AgencyId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("ProductId");

                    b.ToTable("TourOffers");
                });

            modelBuilder.Entity("Traveller.Domain.Models.TourReservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("NumberOfTravellers")
                        .HasColumnType("integer");

                    b.Property<int>("OfferId")
                        .HasColumnType("integer");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<int>("TouristId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("OfferId");

                    b.HasIndex("TouristId");

                    b.ToTable("TourReservation");
                });

            modelBuilder.Entity("Traveller.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("Role");

                    b.ToTable("Users");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Traveller.Domain.Models.ExtendedTour", b =>
                {
                    b.HasBaseType("Traveller.Domain.Models.Tour");

                    b.HasDiscriminator().HasValue("ExtendedTour");
                });

            modelBuilder.Entity("Traveller.Domain.Models.AgencyUser", b =>
                {
                    b.HasBaseType("Traveller.Domain.Models.User");

                    b.Property<int>("AgencyId")
                        .HasColumnType("integer");

                    b.HasIndex("AgencyId");

                    b.ToTable("AgencyUsers");
                });

            modelBuilder.Entity("Traveller.Domain.Models.Tourist", b =>
                {
                    b.HasBaseType("Traveller.Domain.Models.User");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasIndex("Nationality");

                    b.ToTable("Tourists");
                });

            modelBuilder.Entity("ExtendedTourHotel", b =>
                {
                    b.HasOne("Traveller.Domain.Models.ExtendedTour", null)
                        .WithMany()
                        .HasForeignKey("ExtendedTourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Traveller.Domain.Models.Hotel", null)
                        .WithMany()
                        .HasForeignKey("HotelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PackageTour", b =>
                {
                    b.HasOne("Traveller.Domain.Models.Package", null)
                        .WithMany()
                        .HasForeignKey("PackagesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Traveller.Domain.Models.Tour", null)
                        .WithMany()
                        .HasForeignKey("ToursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Traveller.Domain.Models.FlightOffer", b =>
                {
                    b.HasOne("Traveller.Domain.Models.Agency", "Agency")
                        .WithMany("Flights")
                        .HasForeignKey("AgencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Traveller.Domain.Models.Flight", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agency");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Traveller.Domain.Models.FlightReservation", b =>
                {
                    b.HasOne("Traveller.Domain.Models.FlightOffer", "Offer")
                        .WithMany("Reservations")
                        .HasForeignKey("OfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Traveller.Domain.Models.Tourist", "Tourist")
                        .WithMany("FlightReservations")
                        .HasForeignKey("TouristId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Offer");

                    b.Navigation("Tourist");
                });

            modelBuilder.Entity("Traveller.Domain.Models.HotelOffer", b =>
                {
                    b.HasOne("Traveller.Domain.Models.Agency", "Agency")
                        .WithMany("Hotels")
                        .HasForeignKey("AgencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Traveller.Domain.Models.Hotel", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agency");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Traveller.Domain.Models.HotelReservation", b =>
                {
                    b.HasOne("Traveller.Domain.Models.HotelOffer", "Offer")
                        .WithMany("Reservations")
                        .HasForeignKey("OfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Traveller.Domain.Models.Tourist", "Tourist")
                        .WithMany("HotelReservations")
                        .HasForeignKey("TouristId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Offer");

                    b.Navigation("Tourist");
                });

            modelBuilder.Entity("Traveller.Domain.Models.PackageFacility", b =>
                {
                    b.HasOne("Traveller.Domain.Models.Facility", "Facility")
                        .WithMany("Packages")
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Traveller.Domain.Models.Package", "Package")
                        .WithMany("Facilities")
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Facility");

                    b.Navigation("Package");
                });

            modelBuilder.Entity("Traveller.Domain.Models.PackageOffer", b =>
                {
                    b.HasOne("Traveller.Domain.Models.Agency", "Agency")
                        .WithMany("Packages")
                        .HasForeignKey("AgencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Traveller.Domain.Models.Package", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agency");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Traveller.Domain.Models.PackageReservation", b =>
                {
                    b.HasOne("Traveller.Domain.Models.PackageOffer", "Offer")
                        .WithMany("Reservations")
                        .HasForeignKey("OfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Traveller.Domain.Models.Tourist", "Tourist")
                        .WithMany("PackageReservations")
                        .HasForeignKey("TouristId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Offer");

                    b.Navigation("Tourist");
                });

            modelBuilder.Entity("Traveller.Domain.Models.TourOffer", b =>
                {
                    b.HasOne("Traveller.Domain.Models.Agency", "Agency")
                        .WithMany("Tours")
                        .HasForeignKey("AgencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Traveller.Domain.Models.Tour", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agency");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Traveller.Domain.Models.TourReservation", b =>
                {
                    b.HasOne("Traveller.Domain.Models.TourOffer", "Offer")
                        .WithMany("Reservations")
                        .HasForeignKey("OfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Traveller.Domain.Models.Tourist", "Tourist")
                        .WithMany("TourReservations")
                        .HasForeignKey("TouristId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Offer");

                    b.Navigation("Tourist");
                });

            modelBuilder.Entity("Traveller.Domain.Models.AgencyUser", b =>
                {
                    b.HasOne("Traveller.Domain.Models.Agency", "Agency")
                        .WithMany("AgencyUsers")
                        .HasForeignKey("AgencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Traveller.Domain.Models.User", null)
                        .WithOne()
                        .HasForeignKey("Traveller.Domain.Models.AgencyUser", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agency");
                });

            modelBuilder.Entity("Traveller.Domain.Models.Tourist", b =>
                {
                    b.HasOne("Traveller.Domain.Models.User", null)
                        .WithOne()
                        .HasForeignKey("Traveller.Domain.Models.Tourist", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Traveller.Domain.Models.Agency", b =>
                {
                    b.Navigation("AgencyUsers");

                    b.Navigation("Flights");

                    b.Navigation("Hotels");

                    b.Navigation("Packages");

                    b.Navigation("Tours");
                });

            modelBuilder.Entity("Traveller.Domain.Models.Facility", b =>
                {
                    b.Navigation("Packages");
                });

            modelBuilder.Entity("Traveller.Domain.Models.FlightOffer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Traveller.Domain.Models.HotelOffer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Traveller.Domain.Models.Package", b =>
                {
                    b.Navigation("Facilities");
                });

            modelBuilder.Entity("Traveller.Domain.Models.PackageOffer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Traveller.Domain.Models.TourOffer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Traveller.Domain.Models.Tourist", b =>
                {
                    b.Navigation("FlightReservations");

                    b.Navigation("HotelReservations");

                    b.Navigation("PackageReservations");

                    b.Navigation("TourReservations");
                });
#pragma warning restore 612, 618
        }
    }
}
