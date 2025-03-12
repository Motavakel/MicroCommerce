using Products.Domin.Entities;
using System.Linq.Expressions;

namespace Products.Application.Contract.Specification;

public class BaseSpecification<T> : ISpecification<T> where T : BaseEntity
{
    public int Take { get; set; }
    public int Skip { get; set; }
    public bool IsPagingEnabled { get; set; }

    public Expression<Func<T,bool>> Criteria { get; } = _ => true;
    public Expression<Func<T, Object>> OrderBy { get; private set; } = null!;
    public Expression<Func<T, Object>> OrderByDescending { get; private set; } = null!;
    public List<Expression<Func<T, Object>>> Includes { get; private set; } = new();

    //برای جایی که نیازی به شرط نداریم
    public BaseSpecification()
    {

    }

    public BaseSpecification(Expression<Func<T, bool>> criteria)
    {
        Criteria = criteria;
    }

    public void AddIncludes(Expression<Func<T, Object>> include)
    {
        Includes.Add(include);
    }
    public void AddOrderBy(Expression<Func<T,Object>> orderBy)
    {
        OrderBy = orderBy;
    }
    public void AddOrderByDes(Expression<Func<T, Object>> orderByDes)
    {
        OrderByDescending = orderByDes;
    }

    public void ApplyPagging(int skip, int take,bool isPagingEnabled = true)
    {
        Skip = skip;
        Take = take;
        IsPagingEnabled = isPagingEnabled;
    }
}
