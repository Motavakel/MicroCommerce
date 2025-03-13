using Products.Application.Common.Mapping;
using Products.Domin.Entities;

namespace Products.Application.Dtos;

public class ProductDto : IMapFrom<Product>
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string CoverImageUrl { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public string CategoryTitle { get; set; } = string.Empty;

    public void Mapping(AutoMapper.Profile profile)
    {
        profile.CreateMap<Product, ProductDto>()
            .ForMember(d => d.CategoryTitle, opt => opt.MapFrom(s => s.Category.Title));
    }
}
