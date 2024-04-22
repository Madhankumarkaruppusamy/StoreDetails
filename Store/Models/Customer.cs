using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        [MaxLength(120)]
        public string CustomerName { get; set; }

        public virtual ICollection<Address>Addresses { get; set; }
        public virtual ICollection<Contact>Contacts { get; set; }
        public virtual ICollection<Order>Orders { get; set; }
    }

}
