using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using Repositories;

namespace Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository repo = CustomerRepository.Instance;

        public List<Customer> GetCustomers() => repo.GetCustomers();
        public Customer? GetCustomerById(int id) => repo.GetCustomerById(id);
        public void AddCustomer(Customer customer) => repo.AddCustomer(customer);
        public void UpdateCustomer(Customer customer) => repo.UpdateCustomer(customer);
        public void DeleteCustomer(int id) => repo.DeleteCustomer(id);
    }
}