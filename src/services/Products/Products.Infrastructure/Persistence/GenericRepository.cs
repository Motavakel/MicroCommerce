using Microsoft.EntityFrameworkCore;
using Products.Application.Contract;
using Products.Application.Contract.Specification;
using Products.Domin.Entities;
using Products.Infrastructure.Persistence.Context;

namespace Products.Infrastructure.Persistence;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    private readonly ProductContext _context;
    private readonly DbSet<T> _dbSet;

    public GenericRepository(ProductContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();

    }

    public async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellation)
    {
        return await _dbSet.ToListAsync(cancellation);
    }

    public IQueryable<T> GetQuery()
    {
        return _dbSet.AsQueryable();
    }

    public async Task AddAsync(T entity, CancellationToken cancellation)
    {
       await _dbSet.AddAsync(entity,cancellation);
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
    }

    public async Task Delete(T entity, CancellationToken cancellation)
    {
        var spec = new BaseSpecification<T>(x => x.Id == entity.Id);
        var record = await GetBySpec(spec, cancellation);

        if (record != null) {
            _dbSet.Remove(record);
        }
    }


    public async Task<IEnumerable<T>> GetAllBySpec(ISpecification<T> specification, CancellationToken cancellation)
    {
        return await ApplySpecToQuery(specification).ToListAsync(cancellation);
    }

    public async Task<int> GetCountBySpec(ISpecification<T> specification, CancellationToken cancellation)
    {
        return await ApplySpecToQuery(specification).CountAsync(cancellation);
    }

    public IQueryable<T> GetQueryBySpec(ISpecification<T> specification)
    {
       return ApplySpecToQuery(specification);
    }

    public async Task<T> GetBySpec(ISpecification<T> specification, CancellationToken cancellation)
    {
        return await ApplySpecToQuery(specification).FirstOrDefaultAsync(cancellation);
    }

    private IQueryable<T> ApplySpecToQuery(ISpecification<T> specification)
    {
        return SpecificationEvaluator<T>.GetQuery(_dbSet.AsQueryable(), specification);
    }
}
