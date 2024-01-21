using System;
using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Concrete.Configs;
using MiniShop.Entity.Concrete;

namespace MiniShop.Data.Concrete.Context
{
	public class MiniShopDbContext : DbContext
	{
        public MiniShopDbContext(DbContextOptions options):base(options)
        {
           
        }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ProductCategory> ProductCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryConfig).Assembly);
            //category config tipinde olanların hepsini al
            //data-config içindekileri tek tek tanıtmaya gerek kalmadı

            base.OnModelCreating(modelBuilder);
        }
    }
}

