using GraphQL.Types;
using Products.Application.Dtos;

namespace Products.Persentation.GQL.Types.Products;

public class ProductResType : ObjectGraphType<ProductDto>
{
    public ProductResType()
    {
        Field(x => x.Id, type: typeof(IdGraphType)).Description("شناسه محصول");
        Field(x => x.Title).Description("عنوان محصول");
        Field(x => x.Description, nullable: true).Description("توضیحات محصول");
        Field(x => x.CoverImageUrl, nullable: true).Description("آدرس تصویر محصول");
        Field(x => x.Price, type: typeof(FloatGraphType)).Description("قیمت محصول");
        Field(x => x.CategoryId, type: typeof(IdGraphType)).Description("شناسه دسته‌بندی");
        Field(x => x.CategoryTitle, nullable: true).Description("عنوان دسته‌بندی");
    }
}
