namespace Products.Domin.Entities;

public class Category : BaseEntity
{
    public string Title { get; set; } 
    public string Description { get; set; } 
    public bool Active { get; set; }
    public int Priority { get; set; }
    public string BannerUrl { get; set; } 
    public string IconUrl { get; set; } 
    public string ThumbnailUrl { get; set; } 

    public ICollection<Product> Products { get; set; }
    public ICollection<Category> Children { get; set; } = new List<Category>();
    public int? ParentCategoryId { get; set; }
    public Category ParentCategory { get; set; }
}