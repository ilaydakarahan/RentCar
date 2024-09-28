using Microsoft.EntityFrameworkCore;
using RentCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Persistance.Context
{
    public class RentCarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-BFPJH2M;initial Catalog=DbRentCar;integrated Security =true;trustServerCertificate=true;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<BlogCategory> BlogCategorys { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarDescription> CarDescriptions { get; set; }
        public DbSet<CarFeature> CarFeatures { get; set; }
        public DbSet<CarPricing> CarPricings { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FooterAddress> FooterAddresses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<TagCloud> TagClouds { get; set; }
        public DbSet<RentACar> RentACars { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<RentACarProcess> RentACarProcesses { get; set; }
        //public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>()
                .HasOne(x => x.PickUpLocation).WithMany(t => t.PickUpReservation).HasForeignKey(z => z.PickupLocationId).OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<Reservation>()
                .HasOne(t => t.DropOffLocation).WithMany(y => y.DropOffReservation).HasForeignKey(k => k.DropOffLocationId).OnDelete(DeleteBehavior.ClientSetNull);
        
            //Bir tablo içerisinde iki farklı id'yi karşı tabloda tek id ile eşleştirme işlemi 
        }
    }
}
