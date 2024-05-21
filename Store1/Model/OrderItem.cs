using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store1.Model
{
    public class OrderItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Item {  get; set; }
        public string ManufacturedDate { get; set; }
        public string ExpiryDate { get; set; }
        public double Price { get; set; }

        [ForeignKey("CustomerID")]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
    }
}
