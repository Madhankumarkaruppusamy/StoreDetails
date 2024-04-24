using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        [Phone]
        public long Phone { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
