using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistance.Context
{
    public class CarBookContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=AYSEPC\\SQL2019;initial Catalog=CarBookProject;integrated Security=true;TrustServerCertificate=true");
        }

        public DbSet<About> About { get; set; }
        public DbSet<Banner> Banner { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<CarDescription> CarDescription { get; set; }
        public DbSet<CarFeature> CarFeature { get; set; }
        public DbSet<CarPricing> CarPricing { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Feature> Feature { get; set; }
        public DbSet<FooterAddress> FooterAddress { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Pricing> Pricing { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<TagCloud> TagClouds { get; set; }
        public DbSet<Comment> Comments { get; set; }


    }
}
