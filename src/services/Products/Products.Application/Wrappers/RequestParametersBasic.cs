using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Wrappers;

public abstract class RequestParametersBasic : PaginationParametersDto
{

    public string Search { get; set; } = string.Empty;
    public SortOptions TypeSort { get; set; } = SortOptions.Newest;

}

public enum SortOptions
{
    Newest = 1,       // جدیدترین ها
    PriceHighToLow,   // گران‌ترین
    PriceLowToHigh,   // ارزان‌ترین
    NameAToZ,         // براساس الفبا
}
