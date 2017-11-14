using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FeatureApplication.Models;
using FeatureApplication.Models.Interface;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FeatureApplication.ApplicationContext {
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string> {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base (options) { }
        public string CurrentUserId { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnModelCreating (ModelBuilder builder) {
            base.OnModelCreating (builder);
            builder.Entity<Customer> ().Property (c => c.Name).IsRequired ().HasMaxLength (100);
            builder.Entity<Customer> ().HasIndex (c => c.Name);
            builder.Entity<Customer> ().Property (c => c.Email).HasMaxLength (100);
            builder.Entity<Customer> ().Property (c => c.PhoneNumber).IsUnicode (false).HasMaxLength (30);
            builder.Entity<Customer> ().Property (c => c.City).HasMaxLength (50);
            builder.Entity<Customer> ().ToTable ("Customer", schema: "mst");

            builder.Entity<ProductCategory> ().Property (p => p.Name).IsRequired ().HasMaxLength (100);
            builder.Entity<ProductCategory> ().Property (p => p.Description).HasMaxLength (500);
            builder.Entity<ProductCategory> ().ToTable ("ProductCategory", schema: "mst");

            builder.Entity<Product> ().Property (p => p.Name).IsRequired ().HasMaxLength (100);
            builder.Entity<Product> ().HasIndex (p => p.Name);
            builder.Entity<Product> ().Property (p => p.Description).HasMaxLength (500);
            builder.Entity<Product> ().Property (p => p.Icon).IsUnicode (false).HasMaxLength (256);
            builder.Entity<Product> ().HasOne (p => p.Parent).WithMany (p => p.Children).OnDelete (DeleteBehavior.Restrict);
            builder.Entity<Product> ().ToTable ("Product", schema: "mst");

            builder.Entity<Order> ().Property (o => o.Comments).HasMaxLength (500);
            builder.Entity<Order> ().ToTable ("Order", schema: "mst");

            builder.Entity<OrderDetail> ().ToTable ("OrderDetail", schema: "mst");
        }
        public override int SaveChanges () {
            UpdateAuditEntities ();
            return base.SaveChanges ();
        }

        public override int SaveChanges (bool acceptAllChangesOnSuccess) {
            UpdateAuditEntities ();
            return base.SaveChanges (acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync (CancellationToken cancellationToken = default (CancellationToken)) {
            UpdateAuditEntities ();
            return base.SaveChangesAsync (cancellationToken);
        }
        public override Task<int> SaveChangesAsync (bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default (CancellationToken)) {
            UpdateAuditEntities ();
            return base.SaveChangesAsync (acceptAllChangesOnSuccess, cancellationToken);
        }
        private void UpdateAuditEntities () {
            var modifiedEntries = ChangeTracker.Entries ()
                .Where (x => x.Entity is IAuditableEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entry in modifiedEntries) {
                var entity = (IAuditableEntity) entry.Entity;
                DateTime now = DateTime.UtcNow;

                if (entry.State == EntityState.Added) {
                    entity.CreatedDate = now;
                    entity.CreatedBy = CurrentUserId;
                } else {
                    base.Entry (entity).Property (x => x.CreatedBy).IsModified = false;
                    base.Entry (entity).Property (x => x.CreatedDate).IsModified = false;
                }

                entity.UpdatedDate = now;
                entity.UpdatedBy = CurrentUserId;
            }
        }
    }
}