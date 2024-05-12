using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store1.Model
{
    public class CustomerAdditionalDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [ForeignKey("CustomerID")]
        public long CustomerID { get; set; }
        public Customer Customer { get; set; }
        public string City {  get; set; }
        public string Country { get; set; }
    }
}
