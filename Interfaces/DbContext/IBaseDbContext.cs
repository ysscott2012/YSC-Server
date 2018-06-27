using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace YSC_Server.DbContext
{
    public interface IBaseDbContext: IDisposable
    {
        DatabaseFacade Database { get; }
        
        ChangeTracker ChangeTracker { get; }
        
        IModel Model { get; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        
        int SaveChanges();
        
        int SaveChanges(bool acceptAllChangesOnSuccess);
        
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken));

        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        EntityEntry Entry(object entity);

        EntityEntry<TEntity> Add<TEntity>(TEntity entity) where TEntity : class;

        Task<EntityEntry<TEntity>> AddAsync<TEntity>(TEntity entity, CancellationToken cancellationToken = default(CancellationToken)) where TEntity : class;

        EntityEntry<TEntity> Attach<TEntity>(TEntity entity) where TEntity : class;

        EntityEntry<TEntity> Update<TEntity>(TEntity entity) where TEntity : class;

        EntityEntry<TEntity> Remove<TEntity>(TEntity entity) where TEntity : class;

        EntityEntry Add(object entity);

        Task<EntityEntry> AddAsync(object entity, CancellationToken cancellationToken = default(CancellationToken));

        EntityEntry Attach(object entity);

        EntityEntry Update(object entity);

        EntityEntry Remove(object entity);

        void AddRange(params object[] entities);

        Task AddRangeAsync(params object[] entities);

        void AttachRange(IEnumerable<object> entities);

        void UpdateRange(IEnumerable<object> entities);

        void RemoveRange(IEnumerable<object> entities);

        object Find(Type entityType, params object[] keyValues);

        Task<object> FindAsync(Type entityType, params object[] keyValues);

        Task<object> FindAsync(Type entityType, object[] keyValues, CancellationToken cancellationToken);

        TEntity Find<TEntity>(params object[] keyValues) where TEntity : class;

        Task<TEntity> FindAsync<TEntity>(params object[] keyValues) where TEntity : class;

        Task<TEntity> FindAsync<TEntity>(object[] keyValues, CancellationToken cancellationToken) where TEntity : class;
    
    }
}