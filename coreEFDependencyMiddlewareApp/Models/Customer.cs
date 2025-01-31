using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace coreEFDependencyMiddlewareApp.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        [MinLength(8)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [Range(18,60)]
        public int Age { get; set; }

        [EmailAddress]
        [Column("EmailAddress")]
        public string Email { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime DateOfJoining { get; set; }

    }

}
