using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring
          (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-1MSR6CD\\SQLEXPRESS;database=AkademiPlusFinishDB;integrated security=true");
        }

        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<FeaturedProduct> FeaturedProducts { get; set; }

        public DbSet<NewArrival> NewArrivals { get; set; }

        public DbSet<SliderPhoto> SliderPhotos { get; set; }
        public DbSet<Policy> Policies { get; set; }

    }
}
