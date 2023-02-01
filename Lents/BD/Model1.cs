using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lents.BD
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Placement> Placement { get; set; }
        public virtual DbSet<Point> Point { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }
        public virtual DbSet<OrderComposition> OrderComposition { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacturer>()
                .HasMany(e => e.Product)
                .WithOptional(e => e.Manufacturer1)
                .HasForeignKey(e => e.manufacturer);

            modelBuilder.Entity<Order>()
                .HasOptional(e => e.OrderComposition)
                .WithRequired(e => e.Order);

            modelBuilder.Entity<Placement>()
                .Property(e => e.article_number)
                .IsFixedLength();

            modelBuilder.Entity<Point>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.Point)
                .HasForeignKey(e => e.ID_item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.article_number)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.unit)
                .IsFixedLength();

            modelBuilder.Entity<Provider>()
                .HasMany(e => e.Product)
                .WithOptional(e => e.Provider1)
                .HasForeignKey(e => e.provider);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Role1)
                .HasForeignKey(e => e.role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Order)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.ID_client);

            modelBuilder.Entity<OrderComposition>()
                .Property(e => e.article_number)
                .IsFixedLength();
        }
    }
}
