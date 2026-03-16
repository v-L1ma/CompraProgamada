using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using CompraProgamada.Application.Repositories;
using CompraProgamada.Infrastructure;

namespace CompraProgamada.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private readonly ConcurrentDictionary<Type, object> _repositories;
        private bool _disposed;

        public UnitOfWork(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _repositories = new ConcurrentDictionary<Type, object>();
        }

        public IRepositoryBase<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            var type = typeof(TEntity);

            return (IRepositoryBase<TEntity>)_repositories.GetOrAdd(type, t =>
            {
                var repositoryType = typeof(RepositoryBase<>).MakeGenericType(t);
                return Activator.CreateInstance(repositoryType, _context) 
                    ?? throw new InvalidOperationException($"Could not create instance of {repositoryType.Name}");
            });
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                _context.Dispose();
            }
            _disposed = true;
        }
    }
}