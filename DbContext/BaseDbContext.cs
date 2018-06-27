using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using YSC_Server.DaoModels;

namespace YSC_Server.DbContext
{
    public abstract class BaseDbContext: Microsoft.EntityFrameworkCore.DbContext, IBaseDbContext
    {
        protected BaseDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is EntityBase && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((EntityBase)entity.Entity).CrationTime = DateTime.UtcNow;
                }

                ((EntityBase)entity.Entity).LastUpdatedTime = DateTime.UtcNow;
            }
        }
    }
}