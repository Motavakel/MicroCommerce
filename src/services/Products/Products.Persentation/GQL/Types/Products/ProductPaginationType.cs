using GraphQL.Types;
using Products.Application.Dtos;
using Products.Application.Wrappers;

namespace Products.Persentation.GQL.Types.Products;

public class ProductPaginationType : ObjectGraphType<PaginationResponse<ProductDto>>
{
    public ProductPaginationType()
    {
        Name = "ProductPagination";

        Field(x => x.PageIndex).Description("شماره صفحه");
        Field(x => x.PageSize).Description("تعداد آیتم‌ها در هر صفحه");
        Field(x => x.Count).Description("مجموع تعداد آیتم‌ها");
        Field(x => x.MinPrice, nullable: true).Description("حداقل قیمت");
        Field(x => x.MaxPrice, nullable: true).Description("حداکثر قیمت");
        Field<ListGraphType<ProductResType>>(
            name: "Result",
            resolve: context => context.Source.Result
        ).Description = "لیست محصولات";

    }
}
