using Products.Application.Contract.Specification;
using Products.Domin.Entities;

namespace Products.Application.Contract;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellation);
    IQueryable<T> GetQuery();
    Task AddAsync(T entity,CancellationToken cancellation);
    void Update(T entity);
    Task Delete(T entity,CancellationToken cancellation);

    Task<IEnumerable<T>> GetAllBySpec(ISpecification<T> specification, CancellationToken cancellation);
    Task<T> GetBySpec(ISpecification<T> specification, CancellationToken cancellation);
    Task<int> GetCountBySpec(ISpecification<T> specification , CancellationToken cancellation);

    //برای اعمال پروجکشن 
    IQueryable<T> GetQueryBySpec(ISpecification<T> specification); 
}
