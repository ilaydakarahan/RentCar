﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentCar.Persistance.Context;

#nullable disable

namespace RentCar.Persistance.Migrations
{
    [DbContext(typeof(RentCarContext))]
    [Migration("20241104162818_mig_add_review")]
    partial class mig_add_review
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RentCar.Domain.Entities.About", b =>
                {
                    b.Property<int>("AboutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AboutId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboutId");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Banner", b =>
                {
                    b.Property<int>("BannerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BannerID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BannerID");

                    b.ToTable("Banners");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BlogId"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("BlogCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CoverImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BlogId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BlogCategoryId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.BlogCategory", b =>
                {
                    b.Property<int>("BlogCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BlogCategoryId"));

                    b.Property<string>("BlogCategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BlogCategoryId");

                    b.ToTable("BlogCategorys");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrandId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrandId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarId"));

                    b.Property<string>("BigImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("CoverImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fuel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Km")
                        .HasColumnType("int");

                    b.Property<byte>("Luggage")
                        .HasColumnType("tinyint");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Seat")
                        .HasColumnType("tinyint");

                    b.Property<string>("Transmission")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarId");

                    b.HasIndex("BrandId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.CarDescription", b =>
                {
                    b.Property<int>("CarDescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarDescriptionId"));

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("Deatils")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarDescriptionId");

                    b.HasIndex("CarId");

                    b.ToTable("CarDescriptions");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.CarFeature", b =>
                {
                    b.Property<int>("CarFeatureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarFeatureId"));

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("FeatureId")
                        .HasColumnType("int");

                    b.HasKey("CarFeatureId");

                    b.HasIndex("CarId");

                    b.HasIndex("FeatureId");

                    b.ToTable("CarFeatures");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.CarPricing", b =>
                {
                    b.Property<int>("CarPricingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarPricingId"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("PricingId")
                        .HasColumnType("int");

                    b.HasKey("CarPricingId");

                    b.HasIndex("CarId");

                    b.HasIndex("PricingId");

                    b.ToTable("CarPricings");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentID"));

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<string>("CommentContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommentID");

                    b.HasIndex("BlogId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SendDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Feature", b =>
                {
                    b.Property<int>("FeatureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeatureId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FeatureId");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.FooterAddress", b =>
                {
                    b.Property<int>("FooterAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FooterAddressId"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FooterAddressId");

                    b.ToTable("FooterAddresses");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Pricing", b =>
                {
                    b.Property<int>("PricingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PricingId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PricingId");

                    b.ToTable("Pricings");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.RentACar", b =>
                {
                    b.Property<int>("RentACarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RentACarId"));

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.HasKey("RentACarId");

                    b.HasIndex("CarId");

                    b.HasIndex("LocationId");

                    b.ToTable("RentACars");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.RentACarProcess", b =>
                {
                    b.Property<int>("RentACarProcessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RentACarProcessId"));

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DropOffDate")
                        .HasColumnType("Date");

                    b.Property<string>("DropOffDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("DropOffTime")
                        .HasColumnType("time");

                    b.Property<int>("DropOfflocation")
                        .HasColumnType("int");

                    b.Property<DateTime>("PickUpDate")
                        .HasColumnType("Date");

                    b.Property<int>("PickUpLocation")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("PickUpTime")
                        .HasColumnType("time");

                    b.Property<string>("PickupDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("RentACarProcessId");

                    b.HasIndex("CarId");

                    b.HasIndex("CustomerId");

                    b.ToTable("RentACarProcesses");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DriverLicenseYear")
                        .HasColumnType("int");

                    b.Property<int?>("DropOffLocationId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PickupLocationId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReservationId");

                    b.HasIndex("CarId");

                    b.HasIndex("DropOffLocationId");

                    b.HasIndex("PickupLocationId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"));

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StarValue")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("CarId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServiceId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.SocialMedia", b =>
                {
                    b.Property<int>("SocialMediaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SocialMediaId"));

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SocialMediaId");

                    b.ToTable("SocialMedias");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.TagCloud", b =>
                {
                    b.Property<int>("TagCloudID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagCloudID"));

                    b.Property<int>("BlogID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagCloudID");

                    b.HasIndex("BlogID");

                    b.ToTable("TagClouds");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Testimonial", b =>
                {
                    b.Property<int>("TestimonialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestimonialId"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestimonialId");

                    b.ToTable("Testimonials");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Blog", b =>
                {
                    b.HasOne("RentCar.Domain.Entities.Author", "Author")
                        .WithMany("Blogs")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentCar.Domain.Entities.BlogCategory", "BlogCategory")
                        .WithMany("Blogs")
                        .HasForeignKey("BlogCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("BlogCategory");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Car", b =>
                {
                    b.HasOne("RentCar.Domain.Entities.Brand", "Brand")
                        .WithMany("Cars")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.CarDescription", b =>
                {
                    b.HasOne("RentCar.Domain.Entities.Car", "Car")
                        .WithMany("CarDescriptions")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.CarFeature", b =>
                {
                    b.HasOne("RentCar.Domain.Entities.Car", "Car")
                        .WithMany("CarFeatures")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentCar.Domain.Entities.Feature", "Feature")
                        .WithMany("CarFeatures")
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Feature");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.CarPricing", b =>
                {
                    b.HasOne("RentCar.Domain.Entities.Car", "Car")
                        .WithMany("CarPricings")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentCar.Domain.Entities.Pricing", "Pricing")
                        .WithMany("CarPricings")
                        .HasForeignKey("PricingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Pricing");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Comment", b =>
                {
                    b.HasOne("RentCar.Domain.Entities.Blog", "Blog")
                        .WithMany("Comments")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.RentACar", b =>
                {
                    b.HasOne("RentCar.Domain.Entities.Car", "Car")
                        .WithMany("RentACars")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentCar.Domain.Entities.Location", "Location")
                        .WithMany("RentACars")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.RentACarProcess", b =>
                {
                    b.HasOne("RentCar.Domain.Entities.Car", "Car")
                        .WithMany("RentACarProcesses")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentCar.Domain.Entities.Customer", "Customer")
                        .WithMany("RentACarProcesses")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Reservation", b =>
                {
                    b.HasOne("RentCar.Domain.Entities.Car", "Car")
                        .WithMany("Reservations")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentCar.Domain.Entities.Location", "DropOffLocation")
                        .WithMany("DropOffReservation")
                        .HasForeignKey("DropOffLocationId");

                    b.HasOne("RentCar.Domain.Entities.Location", "PickUpLocation")
                        .WithMany("PickUpReservation")
                        .HasForeignKey("PickupLocationId");

                    b.Navigation("Car");

                    b.Navigation("DropOffLocation");

                    b.Navigation("PickUpLocation");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Review", b =>
                {
                    b.HasOne("RentCar.Domain.Entities.Car", "Car")
                        .WithMany("Reviews")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.TagCloud", b =>
                {
                    b.HasOne("RentCar.Domain.Entities.Blog", "Blog")
                        .WithMany("TagClouds")
                        .HasForeignKey("BlogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Author", b =>
                {
                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Blog", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("TagClouds");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.BlogCategory", b =>
                {
                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Brand", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Car", b =>
                {
                    b.Navigation("CarDescriptions");

                    b.Navigation("CarFeatures");

                    b.Navigation("CarPricings");

                    b.Navigation("RentACarProcesses");

                    b.Navigation("RentACars");

                    b.Navigation("Reservations");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Customer", b =>
                {
                    b.Navigation("RentACarProcesses");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Feature", b =>
                {
                    b.Navigation("CarFeatures");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Location", b =>
                {
                    b.Navigation("DropOffReservation");

                    b.Navigation("PickUpReservation");

                    b.Navigation("RentACars");
                });

            modelBuilder.Entity("RentCar.Domain.Entities.Pricing", b =>
                {
                    b.Navigation("CarPricings");
                });
#pragma warning restore 612, 618
        }
    }
}
