using Microsoft.EntityFrameworkCore;
using CustomerOrders.Data.Data; 
using CustomerOrders.Data.Models; 

namespace CustomerOrders.Api.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomersWithOrdersAsync()
        {
            return await _context.Customers
                                 .Include(c => c.Orders)
                                 .AsNoTracking()
                                 .ToListAsync();
        }

        public async Task<Customer> GetCustomerWithOrdersByIdAsync(Guid customerId)
        {
            return await _context.Customers
                                 .Include(c => c.Orders)
                                 .AsNoTracking()
                                 .FirstOrDefaultAsync(c => c.CustomerID == customerId);
        }
    }
}