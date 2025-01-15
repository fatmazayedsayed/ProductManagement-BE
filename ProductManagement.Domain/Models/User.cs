using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ProductManagement.Common.Enum;

namespace ProductManagement.Domain.Models
{

    [Table("User")]
    public partial class User : BaseModel
    {


        [StringLength(500)]
        [Required]
        public string UserName { get; set; } = string.Empty;

        [StringLength(500)]
        public string Password { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;


        public UserType UserType { get; set; }
        public string Email { get; set; }
    }


}
