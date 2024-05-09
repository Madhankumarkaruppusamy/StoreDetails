using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }

        [Required]
        [MaxLength(120)]
        public string CustomerName { get; set; }

        public virtual ICollection<Address>? Addresses { get; set; }
        public virtual ICollection<Contact>? Contacts { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }
        public virtual ICollection<Item>? Items { get; set; }
        public virtual ICollection<Counter>? Counters { get; set; }

    }

}
