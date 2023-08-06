using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yosotronics.Persistence.Models;

namespace Yosotronics.Persistence
{
    public class YosotronicsDbContext : DbContext
    {
        public YosotronicsDbContext(DbContextOptions<YosotronicsDbContext> options) : base(options) { }

        public DbSet<UserDTO> Users { get; set; }
        public DbSet<UnitDTO> Units { get; set; }
        public DbSet<BrandDTO> Brands { get; set; }
        public DbSet<CategoryDTO> Categories { get; set; }
        public DbSet<SubCategoryDTO> SubCategories { get; set; }
        public DbSet<SubscribeDTO> Subscribes { get; set; }
        public DbSet<AttributeDTO> Attributes { get; set; }
        public DbSet<ProductTypeDTO> ProductTypes { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("yeso");

            modelBuilder.Entity<UserDTO>()
                        .HasIndex(u => u.Email)
                        .IsUnique();

            modelBuilder.Entity<UserDTO>()
                        .HasIndex(u => u.MobileNo)
                        .IsUnique();

            modelBuilder.Entity<SubscribeDTO>()
                        .HasIndex(u => u.Email)
                        .IsUnique();
            modelBuilder.Entity<AttributeDTO>()
                        .HasIndex(u => u.Name)
                        .IsUnique();
            modelBuilder.Entity<ProductTypeDTO>()
                        .HasIndex(u => u.Name)
                        .IsUnique();
            modelBuilder.Entity<BrandDTO>()
                       .HasIndex(u => u.Name)
                       .IsUnique();
            modelBuilder.Entity<UnitDTO>()
                      .HasIndex(u => u.Name)
                      .IsUnique();

        }
    }
}
