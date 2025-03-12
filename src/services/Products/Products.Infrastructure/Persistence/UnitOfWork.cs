using Products.Application.Contract;
using Products.Domin.Entities;
using Products.Infrastructure.Persistence.Context;

namespace Products.Infrastructure.Persistence;

public class UnitOfWork : IUnitOfWork
{
    private readonly ProductContext _context;
    public UnitOfWork(ProductContext context)
    {
        _context = context;
    }
    public IGenericRepository<T> GetGenericRepository<T>() where T : BaseEntity
    {
        return new GenericRepository<T>(_context);
    }
    public async Task<int> SaveAsync(CancellationToken cancellation)
    {
        return await _context.SaveChangesAsync(cancellation);
    }

    public async Task RollbackTransactionAsync(CancellationToken cancellation)
    {
        await _context.Database.RollbackTransactionAsync(cancellation);
    }
    public async Task BeginTransactionAsync(CancellationToken cancellation)
    {
        await _context.Database.BeginTransactionAsync(cancellation);
    }
    public async Task CommitTransactionAsync(CancellationToken cancellation)
    {
        await _context.Database.CommitTransactionAsync(cancellation);
    }

}
