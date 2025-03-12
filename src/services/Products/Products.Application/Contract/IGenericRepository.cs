using Products.Application.Contract.Specification;
using Products.Domin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Contract;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellation);
    Task<T> GetAsync(CancellationToken cancellation);

    Task AddAsync(T entity,CancellationToken cancellation);
    void Update(T entity, CancellationToken cancellation);
    void Delete(T entity,CancellationToken cancellation);

    Task<IEnumerable<T>> GetAllWithSpec(ISpecification<T> specification, CancellationToken cancellation);
    Task<T> GetWithSpec(ISpecification<T> specification, CancellationToken cancellation);
    Task<int> GetCountWithSpec(ISpecification<T> specification , CancellationToken cancellation);

    //برای اعمال پروجکشن 
    IQueryable<T> GetQueryBySpec(ISpecification<T> specification , CancellationToken cancellation); 
}
