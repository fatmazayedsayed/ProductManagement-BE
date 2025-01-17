using ProductManagement.Common.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductManagement.Domain.Models;

[Table("Category")]
public partial class Category : BaseModel
{

    [StringLength(50)]
    public required string Name { get; set; }
    [StringLength(200)]
    public string Description { get; set; } = string.Empty;
    public Guid? ParentCategoryId { get; set; } // Optional self-referencing foreign key.

    [ForeignKey(nameof(ParentCategoryId))]
    public virtual Category? ParentCategory { get; set; } // Navigation property for the parent category.

    [Required]
    public CategoryStatus Status { get; set; } = CategoryStatus.Active; // Enum for status with a default value.
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();



    public static SortExpression<Category> SortBy(string sorting)
    {
        // If sorting is null or empty, default to sorting by InsertedDate ascending
        if (string.IsNullOrEmpty(sorting))
        {
            sorting = "default";
        }

        switch (sorting.ToLower())
        {
            case "name_ascending":
                return new SortExpression<Category> { Expression = g => g.Name, IsDescending = false };

            case "name_descending":
                return new SortExpression<Category> { Expression = g => g.Name, IsDescending = true };

            case "default":
            default:
                return new SortExpression<Category> { Expression = g => g.InsertedDate, IsDescending = true };
        }
    }
}

