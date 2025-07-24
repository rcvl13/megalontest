using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerOrders.Data.Models
{
    public class Order
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int OrderID { get; set; } 

        [Required]
        public Guid CustomerID { get; set; } 

        [Required]
        [Column(TypeName = "VARCHAR(100)")]
        public string ItemName { get; set; }

        [Required]
        [Column(TypeName = "DECIMAL(10,2)")]
        public decimal ItemPrice { get; set; } 

        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }
    }
}