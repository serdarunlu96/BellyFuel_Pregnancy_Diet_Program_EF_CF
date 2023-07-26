using BellyFuel_Pregnancy_Diet_Program.Data;
using BellyFuel_Pregnancy_Diet_Program.SeedData;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellyFuel_Pregnancy_Diet_Program.Context
{
    public class BellyFuelDbContext : DbContext
    {

        public DbSet<User> Users { get; set; } = null!;

        public DbSet<Beverage> Beverages { get; set; }

        public DbSet<UserFood> UserFoods { get; set; }
        public DbSet<UserBeverage> UserBeverages { get; set; }

        public DbSet<FoodCategory> FoodCategories { get; set; }

        public DbSet<BeverageCategory> BeverageCategories { get; set; }
        public DbSet<Food> Foods { get; set; }

        public DbSet<Meal> Meals { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.Id);
                entity.Property(u => u.Email).IsRequired();
                entity.Property(u => u.Password).IsRequired();
                entity.HasOne(u => u.Role)
                    .WithMany(r => r.Users)
                    .HasForeignKey(u => u.RoleId)
                    .IsRequired();
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(r => r.Id);
                entity.Property(r => r.RoleName).IsRequired();
            });

            modelBuilder.Entity<Food>()
                .Property(f => f.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Food>()
                .Property(f => f.Photo)
                .IsRequired(false)
                .HasMaxLength(255); 

            modelBuilder.Entity<Food>()
                .Property(f => f.CategoryId)
                .IsRequired();

            modelBuilder.Entity<Food>()
                .Property(f => f.Calories)
                .IsRequired();

            modelBuilder.Entity<Food>()
                .Property(f => f.Fat)
                .IsRequired();

            modelBuilder.Entity<Food>()
                .Property(f => f.Protein)
                .IsRequired();

            modelBuilder.Entity<Food>()
                .Property(f => f.Sugar)
                .IsRequired();

            modelBuilder.Entity<Food>()
                .Property(f => f.Carbs)
                .IsRequired();

            modelBuilder.Entity<Food>()
                .Property(f => f.Sodium)
                .IsRequired();

            modelBuilder.Entity<Food>()
                .HasOne(f => f.Category)
                .WithMany(c => c.Foods)
                .HasForeignKey(f => f.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserFood>()
                .HasKey(uf => new { uf.UserId, uf.FoodId });

            modelBuilder.Entity<UserFood>()
                .HasOne(uf => uf.User)
                .WithMany(u => u.UserFoods)
                .HasForeignKey(uf => uf.UserId);

            modelBuilder.Entity<UserFood>()
                .HasOne(uf => uf.Food)
                .WithMany(f => f.UserFoods)
                .HasForeignKey(uf => uf.FoodId);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;database=BellyFuelDb;trusted_connection=true");
            optionsBuilder.UseLazyLoadingProxies(useLazyLoadingProxies: true);

        }

    }
}
