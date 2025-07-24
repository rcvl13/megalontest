using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerOrders.Data.Models; 

namespace CustomerOrders.Api.Repositories
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllCustomersWithOrdersAsync();
        Task<Customer> GetCustomerWithOrdersByIdAsync(Guid customerId);
    }
}