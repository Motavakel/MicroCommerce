using Products.Domin.Entities;
using System.Linq.Expressions;

namespace Products.Application.Contract.Specification;

public interface ISpecification<T> where T : BaseEntity
{
    Expression<Func<T,bool>> Criteria {  get;}
    Expression<Func<T,Object>> OrderBy { get; }
    Expression<Func<T, Object>> OrderByDescending { get; }
    List<Expression<Func<T, Object>>> Includes { get; }

    //pagination
    int Take { get; set; }
    int Skip { get; set; }
    bool IsPagingEnabled { get; set; }
}
