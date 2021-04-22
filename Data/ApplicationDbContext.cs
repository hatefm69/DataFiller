using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Common.Utilities;
using Data.Contracts;
using Entities;
using Entities.Product;
//using Entities.User;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Data
{
    public class ApplicationDbContext : DbContext, IUnitOfWork
    {
        public DbContext DbContext { get { return this; } }
        private void ChangeDateEntities()
        {
            var addedEntities = ChangeTracker.Entries().Where(z => z.State == EntityState.Added).ToList();
            addedEntities.ForEach((x) =>
            {
                if (x.Properties.Any(z => z.Metadata.Name == "CreateDm"))
                    x.Property("CreateDm").CurrentValue = DateTime.Now;
                if (x.Properties.Any(z => z.Metadata.Name == "CreateDs"))
                    x.Property("CreateDs").CurrentValue = DateTime.Now.ToPersian();
            });

            var modifiedEntities = ChangeTracker.Entries().Where(z => z.State == EntityState.Modified).ToList();
            modifiedEntities.ForEach((x) =>
            {
                if (x.Properties.Any(z => z.Metadata.Name == "LastUpdateDm"))
                    x.Property("LastUpdateDm").CurrentValue = DateTime.Now;
                if (x.Properties.Any(z => z.Metadata.Name == "LastUpdateDs"))
                    x.Property("LastUpdateDs").CurrentValue = DateTime.Now.ToPersian();
            });


        }

        private IDbContextTransaction _transaction;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var entitiesAssembly = typeof(IEntityApp).Assembly;

            modelBuilder.RegisterAllEntities<IEntityApp>(entitiesAssembly);
            modelBuilder.RegisterEntityTypeConfiguration(entitiesAssembly);
            modelBuilder.ApplyConfigurationsFromAssembly(entitiesAssembly);
            modelBuilder.AddRestrictDeleteBehaviorConvention();
            modelBuilder.AddSequentialGuidForIdConvention();
            modelBuilder.AddPluralizingTableNameConvention();

            modelBuilder.Entity<Part>()
                .HasMany(e => e.Categories)
                .WithMany(e => e.Parts)
                .UsingEntity<CategoryPart>(
                cg => cg
                    .HasOne(cg => cg.Category)
                    .WithMany()
                    .HasForeignKey("CategoriesId"),
                cg => cg
                    .HasOne(cg => cg.Part)
                    .WithMany()
                    .HasForeignKey("PartsId"))
                .ToTable("CategoryParts", "product")
                .HasKey(cg => new { cg.PartsId, cg.CategoriesId });

            modelBuilder.Entity<Part>()
                .HasMany(e => e.Vehicles)
                .WithMany(e => e.Parts)
                .UsingEntity<PartVehicle>(
                cg => cg
                    .HasOne(cg => cg.Vehicle)
                    .WithMany()
                    .HasForeignKey("VehiclesId"),
                cg => cg
                    .HasOne(cg => cg.Part)
                    .WithMany()
                    .HasForeignKey("PartsId"))
                .ToTable("PartVehicles", "product")
                .HasKey(cg => new { cg.PartsId, cg.VehiclesId });





        }

        public override int SaveChanges()
        {
            ChangeDateEntities();
            ChangeTracker.DetectChanges(); //NOTE: changeTracker.Entries<T>() will call it automatically.  
            ChangeTracker.AutoDetectChangesEnabled = false; // for performance reasons, to avoid calling DetectChanges() again.
            _cleanString();
            var result = base.SaveChanges();
            ChangeTracker.AutoDetectChangesEnabled = true;
            return result;
        }
        //public override int SaveChanges()
        //{
        //    ChangeTracker.DetectChanges(); //NOTE: changeTracker.Entries<T>() will call it automatically.  
        //    ChangeTracker.AutoDetectChangesEnabled = false; // for performance reasons, to avoid calling DetectChanges() again.
        //    var result = base.SaveChanges();
        //    ChangeTracker.AutoDetectChangesEnabled = true;
        //    return result;
        //}
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            ChangeDateEntities();
            ChangeTracker.DetectChanges();
            ChangeTracker.AutoDetectChangesEnabled = false; // for performance reasons, to avoid calling DetectChanges() again.
            _cleanString();
            var result = base.SaveChanges(acceptAllChangesOnSuccess);
            ChangeTracker.AutoDetectChangesEnabled = true;
            return result;
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            ChangeDateEntities();
            ChangeTracker.DetectChanges();
            ChangeTracker.AutoDetectChangesEnabled = false; // for performance reasons, to avoid calling DetectChanges() again.
            _cleanString();
            var result = base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
            ChangeTracker.AutoDetectChangesEnabled = true;
            return result;
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            ChangeDateEntities();
            ChangeTracker.DetectChanges();
            ChangeTracker.AutoDetectChangesEnabled = false; // for performance reasons, to avoid calling DetectChanges() again.
            _cleanString();
            var result = base.SaveChangesAsync(cancellationToken);
            ChangeTracker.AutoDetectChangesEnabled = true;
            return result;
        }
        private void _cleanString()
        {
            var changedEntities = ChangeTracker.Entries()
                .Where(x => x.State == EntityState.Added || x.State == EntityState.Modified);
            foreach (var item in changedEntities)
            {
                if (item.Entity == null)
                    continue;

                var properties = item.Entity.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    .Where(p => p.CanRead && p.CanWrite && p.PropertyType == typeof(string));

                foreach (var property in properties)
                {
                    var propName = property.Name;
                    var val = (string)property.GetValue(item.Entity, null);

                    if (val.HasValue())
                    {
                        var newVal = val.Fa2En().FixPersianChars();
                        if (newVal == val)
                            continue;
                        property.SetValue(item.Entity, newVal, null);
                    }
                }
            }
        }

        public void BeginTransaction()
        {
            _transaction = Database.BeginTransaction();
        }

        public void RollbackTransaction()
        {
            if (_transaction == null)
            {
                throw new NullReferenceException("Please call `BeginTransaction()` method first.");
            }
            _transaction.Rollback();
        }

        public void CommitTransaction()
        {
            if (_transaction == null)
            {
                throw new NullReferenceException("Please call `BeginTransaction()` method first.");
            }
            _transaction.Commit();
        }

        public void AddRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class
        {
            Set<TEntity>().AddRange(entities);
        }

        public void RemoveRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class
        {
            Set<TEntity>().RemoveRange(entities);
        }

        public void MarkAsChanged<TEntity>(TEntity entity) where TEntity : class
        {
            Update(entity);
        }
        public override void Dispose()
        {
            _transaction?.Dispose();
            base.Dispose();
        }
        public int SaveAllChanges()
        {
            return base.SaveChanges();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
