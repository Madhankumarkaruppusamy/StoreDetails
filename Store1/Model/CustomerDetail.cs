using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store1.Model
{
    public class CustomerDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [ForeignKey("CustomerID")]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public string FatherName {  get; set; }
        public long PhoneNumber {  get; set; }
    }
}
