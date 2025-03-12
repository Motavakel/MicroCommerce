using Microsoft.EntityFrameworkCore;
using Products.Domin.Entities;


namespace Products.Application.Contract.Specification;

public static class SpecificationEvaluator<T> where T : BaseEntity
{
    public static IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpecification<T> specification)
    {
        var query = inputQuery.AsQueryable();

        if (specification.Criteria != null)
            query = query.Where(specification.Criteria);
        

        if (specification.OrderBy != null)
            query = query.OrderBy(specification.OrderBy);
        

        if (specification.OrderByDescending != null)
            query = query.OrderByDescending(specification.OrderByDescending);


        if (specification.Includes != null && specification.Includes.Any())
            query = specification.Includes.Aggregate(query, (current, value) => current.Include(value));

        if(specification.IsPagingEnabled)
            query = query.Skip(specification.Skip).Take(specification.Take);

        return query;
    }
}