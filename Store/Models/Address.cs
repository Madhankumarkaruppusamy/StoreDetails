using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Models
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId {get;set;}

        [Required]
        [MaxLength(200)]
        public string City { get; set; }

        [Required]
        [MaxLength(20)]
        public long PostalCode { get; set; }
        [ForeignKey("CustomerID")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }

}
