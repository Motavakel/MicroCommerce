using Products.Domin.Entities;

namespace Products.Infrastructure.SeedData;

public class GenerateFakeData
{
    public static List<Product> SeedFakeProduct()
    {
        var products = new List<Product>
                {
                    new Product
                    {
                        Id = 1,
                        Title = "گوشی موبایل سامسونگ",
                        Description = "گوشی موبایل سامسونگ مدل Galaxy S21",
                        Price = 20000,
                        Active = true,
                        CategoryId = 2,
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "لپ‌تاپ ایسوس",
                        Description = "لپ‌تاپ ایسوس مدل ZenBook Pro",
                        Price = 30000,
                        Active = true,
                        CategoryId = 3,
                    },
                    new Product
                    {
                        Id = 3,
                        Title = "کیبورد گیمینگ",
                        Description = "کیبورد گیمینگ برند ریزر مدل BlackWidow",
                        Price = 5000,
                        Active = true,
                        CategoryId = 4,
                    },
                    new Product
                    {
                        Id = 4, 
                        Title = "کامپیوتر رومیزی Dell",
                        Description = "کامپیوتر رومیزی برند Dell مدل XPS",
                        Price = 40000,
                        Active = true,
                        CategoryId = 4,
                    },
                    new Product
                    {
                        Id = 5,
                        Title = "یخچال سامسونگ",
                        Description = "یخچال سامسونگ مدل Side by Side",
                        Price = 15000,
                        Active = true,
                        CategoryId = 5,
                    },
                    new Product
                    {
                        Id = 6,
                        Title = "گوشی موبایل آیفون 13",
                        Description = "گوشی موبایل آیفون 13 با پردازنده A15 Bionic",
                        Price = 25000,
                        Active = true,
                        CategoryId = 2,
                    },
                    new Product
                    {
                        Id = 7,
                        Title = "لپ‌تاپ اپل مک‌بوک پرو",
                        Description = "لپ‌تاپ اپل مک‌بوک پرو 16 اینچ",
                        Price = 35000,
                        Active = true,
                        CategoryId = 3,
                    },
                    new Product
                    {
                        Id = 8,
                        Title = "تبلت آیپد پرو",
                        Description = "تبلت اپل آیپد پرو 12.9 اینچ",
                        Price = 22000,
                        Active = true,
                        CategoryId = 2,
                    },
                    new Product
                    {
                        Id = 9,
                        Title = "مانیتور 4K سامسونگ",
                        Description = "مانیتور 4K برند سامسونگ مدل U32J590",
                        Price = 8000,
                        Active = true,
                        CategoryId = 4,
                    },
                    new Product
                    {
                        Id = 10,
                        Title = "ماوس گیمینگ ریزر",
                        Description = "ماوس گیمینگ ریزر مدل DeathAdder",
                        Price = 1500,
                        Active = true,
                        CategoryId = 4,
                    },
                    new Product
                    {
                        Id = 11,
                        Title = "ماشین لباسشویی بوش",
                        Description = "ماشین لباسشویی بوش مدل Serie 8",
                        Price = 12000,
                        Active = true,
                        CategoryId = 5,
                    },
                    new Product
                    {
                        Id = 12,
                        Title = "یخچال ساید بای ساید ال‌جی",
                        Description = "یخچال ساید بای ساید ال‌جی مدل GR-B247JDS",
                        Price = 18000,
                        Active = true,
                        CategoryId = 5,
                    },
                    new Product
                    {
                        Id= 13,
                        Title = "لپ‌تاپ اچ‌پی",
                        Description = "لپ‌تاپ اچ‌پی مدل Spectre x360",
                        Price = 33000,
                        Active = true,
                        CategoryId = 3,
                    },
                    new Product
                    {
                        Id= 14,
                        Title = "دوربین دیجیتال کانن",
                        Description = "دوربین دیجیتال کانن مدل EOS 90D",
                        Price = 12000,
                        Active = true,
                        CategoryId = 1,
                    },
                    new Product
                    {
                        Id = 15,
                        Title = "پاور بانک انکر",
                        Description = "پاور بانک انکر مدل PowerCore 10000",
                        Price = 1200,
                        Active = true,
                        CategoryId = 1,
                    },
                    new Product
                    {
                        Id = 16,
                        Title = "هارد اکسترنال وسترن دیجیتال",
                        Description = "هارد اکسترنال وسترن دیجیتال مدل My Passport",
                        Price = 2500,
                        Active = true,
                        CategoryId = 1,
                    },
                    new Product
                    {
                        Id = 17,
                        Title = "اسپیکر بلوتوثی جی‌بی‌ال",
                        Description = "اسپیکر بلوتوثی جی‌بی‌ال مدل Flip 5",
                        Price = 3500,
                        Active = true,
                        CategoryId = 1,
                    }
                };
        return products;
    }

    public static List<Category> SeedFakeCategory()
    {
        var categories = new List<Category>
                {
                    new Category
                    {
                        Id= 1,
                        Title = "کالای دیجیتال",
                        Description = "انواع دستگاه‌های دیجیتال مانند گوشی موبایل، لپ‌تاپ و...",
                        Active = true,
                        ParentCategoryId = null,
                        Priority = 1,
                    },
                    new Category
                    {
                        Id = 2,
                        Title = "گوشی موبایل",
                        Description = "گوشی‌های هوشمند و جدیدترین مدل‌های برندهای معروف.",
                        Active = true,
                        ParentCategoryId = 1,
                        Priority = 2,
                    },
                    new Category
                    {
                        Id = 3,
                        Title = "لپ‌تاپ",
                        Description = "انواع لپ‌تاپ‌ها و نوت‌بوک‌های برندهای مختلف.",
                        Active = true,
                        ParentCategoryId = 1,
                        Priority = 3,
                    },
                    new Category
                    {
                        Id = 4,
                        Title = "کامپیوتر و لوازم جانبی",
                        Description = "قطعات کامپیوتر، ماوس، کیبورد و سایر لوازم جانبی.",
                        Active = true,
                        ParentCategoryId = 1,
                        Priority = 4,
                    },
                    new Category
                    {
                        Id = 5,
                        Title = "لوازم خانه و آشپزخانه",
                        Description = "لوازم خانگی و آشپزخانه‌ای از جمله یخچال، ماشین لباسشویی و...",
                        Active = true,
                        ParentCategoryId = null,
                        Priority = 5,
                    }
                };
        return categories;
    }
}

