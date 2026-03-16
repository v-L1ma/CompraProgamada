using System;
using System.Threading;
using System.Threading.Tasks;

namespace CompraProgamada.Application.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IRepositoryBase<TEntity> GetRepository<TEntity>() where TEntity : class;
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}