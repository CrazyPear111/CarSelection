using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFGetStarted.Model
{
	class BloggingContext : DbContext
	{
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Post> Posts { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)	// Настройка DbContext
		{
			optionsBuilder.UseSqlServer("DbConnectionString");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)				// Настройка модели
		{
			modelBuilder.Entity<Blog>()
				.Property(b => b.Url)
				.IsRequired();
		}
	}
}
