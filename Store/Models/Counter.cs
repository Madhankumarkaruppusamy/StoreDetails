using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Models
{
    public class Counter
    {
        [Key]
        public int CounterId { get; set; }
        [Required]
        [MaxLength(100)]
        public string  EmployeeName { get; set; }
        [Required]
        public string ItemOrdered { get; set; }
        [Required]
        public DateTime OrderedDate { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
