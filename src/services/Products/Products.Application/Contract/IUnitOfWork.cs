using Products.Domin.Entities;

namespace Products.Application.Contract;

public interface IUnitOfWork
{
    Task<int> SaveAsync(CancellationToken cancellation);
    IGenericRepository<T> GetGenericRepository<T>() where T : BaseEntity;

    Task BeginTransactionAsync(CancellationToken cancellation);
    Task CommitTransactionAsync(CancellationToken cancellation);
    Task RollbackTransactionAsync(CancellationToken cancellation);
}
