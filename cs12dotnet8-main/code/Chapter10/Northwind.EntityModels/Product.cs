using System.ComponentModel.DataAnnotations; // To use [Required]
using System.ComponentModel.DataAnnotations.Schema; // To use [Column]

namespace Northwind.EntityModels;
public class Product
{
    public int ProductId { get; set; }

    [Required]
    [StringLength(50)]
    public string ProductName { get; set; } = null!;

    [Column("UnitPrice", TypeName = "money")]
    public decimal? Cost { get; set; }

    [Column("UnitsInStock")]
    public short? Stock { get; set; }

    public bool Discontinued { get; set; }

    // These two properties the foreign key relationship 
    // to the Categories tabe.
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; } = null!;
}