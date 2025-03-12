using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domin.Entities;

public class Product:BaseEntity
{
    public string Title { get; set; } 
    public string Description { get; set; } 
    public bool Active { get; set; }
    public string CoverImageUrl { get; set; }
    public decimal Price { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; }
}
