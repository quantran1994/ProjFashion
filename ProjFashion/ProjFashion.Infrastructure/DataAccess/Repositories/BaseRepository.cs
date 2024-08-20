using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ProjectFashion.Core.Interfaces.Repositories;
using ProjFashion.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFashion.Infrastructure.DataAccess.Repositories
{
    public class BaseRepository<T>(ApplicationDbContext context) : IGenericRepository<T>, IDisposable where T : BaseEntity
    {
        protected ApplicationDbContext Context = context;
        private DbSet<T> _dbSet = context.Set<T>();
        public Task<bool> Create(T entity)
        {
            _dbSet.Add(entity);
            return Task.FromResult(true);
        }

        public Task<bool> Delete(int id)
        {
            T? _entity = _dbSet.Find(id);
            EntityEntry<T>? _result = null;
            if (_entity != null)
            {
                _result = _dbSet.Remove(_entity);
            }
            return Task.FromResult(_result?.State == EntityState.Deleted);
        }

        public Task<bool> DeleteByListId(List<int> listId)
        {
            foreach (int id in listId)
            {
                Delete(id);
            }
            return Task.FromResult(true);
        }

        public async Task<T> Get(int id) => await _dbSet.FirstOrDefaultAsync(x => x.Id == id);

        public async Task<List<T>> GetAll() => await _dbSet.ToListAsync();

        public Task<bool> Update(T entity)
        {
            _dbSet.Update(entity);
            return Task.FromResult(true);
        }


        #region IDisposable

        // To detect redundant calls.
        private bool _disposed;

        ~BaseRepository() => Dispose(false);

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            // Dispose managed state (managed objects).
            if (disposing)
                Context.Dispose();

            _disposed = true;
        }
        #endregion
    }
}
