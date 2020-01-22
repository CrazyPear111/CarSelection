using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using EFGetStarted;

namespace EFGetStarted.Model
{
	class CarContext : DbContext
	{
		public DbSet<CarBrand> CarBrands { get; set; }
		public DbSet<Detail> Details { get; set; }
		public DbSet<Seller> Sellers { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["CarConnectionString"].ConnectionString );
			optionsBuilder.UseSqlServer("Server=DESKTOP-D54LM9G;Database=CarSelection;Trusted_Connection=True;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			/*
			modelBuilder.Entity<Seller>()
				.HasKey(SId => SId.SellerId);

			modelBuilder.Entity<Seller>()
				.Property(a => a.Address);

			modelBuilder.Entity<Seller>()
				.Property(n => n.Name);

			modelBuilder.Entity<Seller>()
				.Property(pn => pn.PhoneNumber);
			*/	
		}
	}
}
