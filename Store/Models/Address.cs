﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }

}
