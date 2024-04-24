using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class Address
    {
        [Key]
        public int AddressId {get;set;}

        [Required]
        [MaxLength(200)]
        public string City { get; set; }

        [Required]
        [MaxLength(20)]
        public long PostalCode { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }

}
