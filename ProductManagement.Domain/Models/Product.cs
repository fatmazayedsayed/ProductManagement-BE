using ProductManagement.Common.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductManagement.Domain.Models;

[Table("Product")]
public partial class Product : BaseModel
{


    [Required]
    [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
    public string Name { get; set; } = null!; // Required property.

    [Required]
    [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
    public string Description { get; set; } = null!; // Required property.

    [Required]
    [Range(0.01, double.MaxValue, ErrorMessage = "Price must be a positive value.")]
    public decimal Price { get; set; } // Required positive decimal.

    [Required]
    public Guid CategoryId { get; set; } // Foreign key to the `Category` table.

    [ForeignKey(nameof(CategoryId))]
    public virtual Category Category { get; set; } = null!; // Navigation property for the category.

    [Required]
    public ProductStatus Status { get; set; } = ProductStatus.Active; // Enum for status with a default value.

    [Required]
    [Range(0, int.MaxValue, ErrorMessage = "Stock quantity must be non-negative.")]
    public int StockQuantity { get; set; } // Non-negative integer.

    [Url]
    public string? ImageUrl { get; set; } // Optional URL for the product image.



    public static SortExpression<Product> SortBy(string sorting)
    {
        // If sorting is null or empty, default to sorting by InsertedDate ascending
        if (string.IsNullOrEmpty(sorting))
        {
            sorting = "default";
        }

        switch (sorting.ToLower())
        {
            case "name_ascending":
                return new SortExpression<Product> { Expression = g => g.Name, IsDescending = false };

            case "name_descending":
                return new SortExpression<Product> { Expression = g => g.Name, IsDescending = true };

            case "default":
            default:
                return new SortExpression<Product> { Expression = g => g.InsertedDate, IsDescending = true };
        }
    }
}

