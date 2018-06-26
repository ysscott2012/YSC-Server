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
            var entityEntries = this.ChangeTracker.Entries().Where<EntityEntry>((Func<EntityEntry, bool>) (x =>
            {
                if (!(x.Entity is EntityBase))
                {
                    return false;
                }

                if (x.State != EntityState.Added)
                {
                    return x.State == EntityState.Modified;
                }

                return true;
            }));
            
            foreach (var entityEntry in entityEntries)
            {
                if (entityEntry.State == EntityState.Added)
                {
                    ((EntityBase)entityEntry.Entity).CrationTime = DateTime.Now;
                }   
                ((EntityBase)entityEntry.Entity).LastUpdatedTime = DateTime.Now;
            }
        }
    }
}