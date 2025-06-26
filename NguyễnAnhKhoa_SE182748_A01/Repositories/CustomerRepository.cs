using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private static readonly CustomerRepository instance = new();
        public static CustomerRepository Instance => instance;

        private CustomerRepository() { }

        public List<Customer> GetCustomers() => CustomerDAO.GetCustomers();
        public Customer? GetCustomerById(int id) => CustomerDAO.GetCustomerById(id);
        public void AddCustomer(Customer customer) => CustomerDAO.AddCustomer(customer);
        public void UpdateCustomer(Customer customer) => CustomerDAO.UpdateCustomer(customer);
        public void DeleteCustomer(int id) => CustomerDAO.DeleteCustomer(id);
    }
}