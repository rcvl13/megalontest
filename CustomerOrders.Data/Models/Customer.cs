using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace CustomerOrders.Data.Models
{
    public class Customer
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public Guid CustomerID { get; set; } 

        [Required]
        [Column(TypeName = "VARCHAR(100)")]
        public string FirstName { get; set; } 

        [Required]
        [Column(TypeName = "VARCHAR(100)")]
        public string LastName { get; set; } 

        [Required]
        [Column(TypeName = "DATE")]
        public DateTime DOB { get; set; } 

       
        public ICollection<Order> Orders { get; set; }
    }
}