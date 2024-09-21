using Northwind.EntityModels;
using System.ComponentModel.DataAnnotations; // To use [StringLength]
using System.ComponentModel.DataAnnotations.Schema;// To use [Column]

public class Category
{
    public int CategoryId { get; set; }

    [StringLength(15)]
    public string CategoryName { get; set; } = null!;

    [Column(TypeName = "ntext")]
    public string Description { get; set; }

    // Navigation property for related table.
    public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();

}