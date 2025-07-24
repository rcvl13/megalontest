using System;
using System.Collections.Generic;

namespace CustomerOrders.App.DTOs
{
    public class CustomerDto
    {
        public Guid CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public ICollection<OrderDto> Orders { get; set; } = new List<OrderDto>();
    }
}