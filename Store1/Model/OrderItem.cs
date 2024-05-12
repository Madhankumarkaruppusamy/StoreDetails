using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store1.Model
{
    public class OrderItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public string Item {  get; set; }
        public DateTime OrderDate { get; set; }
        public double Price { get; set; }

        [ForeignKey("CustomerID")]
        public long CustomerID { get; set; }
    }
}
