using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json; 
using System.Threading.Tasks;
using CustomerOrders.App.DTOs;
using System;

namespace CustomerOrders.App.Services
{
    public class CustomerApiService
    {
        private readonly HttpClient _httpClient;

        public CustomerApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CustomerDto>?> GetCustomersAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<CustomerDto>>("api/Customers");
        }

        public async Task<CustomerDto?> GetCustomerByIdAsync(Guid customerId)
        {
            return await _httpClient.GetFromJsonAsync<CustomerDto>($"api/Customers/{customerId}");
        }
    }
}