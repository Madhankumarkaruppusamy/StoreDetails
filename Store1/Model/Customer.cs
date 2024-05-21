using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store1.Model
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int ID { get; set; }
        public string CustomerName {  get; set; }
        public string Email {  get; set; }
        public string DOB { get; set; }
        public virtual CustomerDetail Details { get; set; }    
        public virtual CustomerAdditionalDetail AdditionalDetails { get; set; }
        public virtual OrderItem OrderItems { get; set; }
    }
}
