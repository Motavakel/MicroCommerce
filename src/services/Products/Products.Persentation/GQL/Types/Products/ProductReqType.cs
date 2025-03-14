using GraphQL.Types;
using Products.Application.Features.Products.Query.GetAll;
using Products.Application.Wrappers;

namespace Products.Persentation.GQL.Types.Products;

public class ProductReqType:InputObjectGraphType<GetAllProductsQuery>
{
    public ProductReqType()
    {
        Name = nameof(ProductReqType);

        Field(x => x.PageIndex).Description("شماره صفحه");
        Field(x => x.PageSize).Description("حداکثر تعداد محصولات");
        Field(x => x.Search , nullable:true).Description("متن جستجو");
        Field(x => x.CurrentPrice , nullable:true).Description("قیمت موردنظر به تومان");
        Field(x => x.TypeSort, type: typeof(SortOptionsEnumType)).Description("نوع مرتب‌سازی");
    }
}

public class SortOptionsEnumType : EnumerationGraphType<SortOptions>
{
    public SortOptionsEnumType()
    {
        Name = "SortOptions";
        Description = "انواع مرتب‌سازی محصولات";

        AddValue("NEWEST", "جدیدترین محصولات", (int)SortOptions.Newest);
        AddValue("PRICE_HIGH_TO_LOW", "گران‌ترین محصولات", (int)SortOptions.PriceHighToLow);
        AddValue("PRICE_LOW_TO_HIGH", "ارزان‌ترین محصولات", (int)SortOptions.PriceLowToHigh);
        AddValue("NAME_A_TO_Z", "مرتب‌سازی بر اساس الفبا", (int)SortOptions.NameAToZ);
    }
}
