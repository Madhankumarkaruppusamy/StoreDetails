using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Store.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        [MaxLength(100)]
        public string OrderItem {  get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
