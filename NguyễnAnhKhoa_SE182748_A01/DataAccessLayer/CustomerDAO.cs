using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BusinessObjects;

namespace DataAccessLayer
{
    public class CustomerDAO
    {
        private static List<Customer> customers = new List<Customer>();
        private static readonly object lockObj = new();

        public static List<Customer> GetCustomers() => customers;

        public static Customer? GetCustomerById(int id) =>
            customers.FirstOrDefault(c => c.CustomerID == id);

        public static void AddCustomer(Customer customer)
        {
            lock (lockObj)
            {
                customers.Add(customer);
            }
        }

        public static void UpdateCustomer(Customer customer)
        {
            var existing = GetCustomerById(customer.CustomerID);
            if (existing != null)
            {
                existing.CompanyName = customer.CompanyName;
                existing.ContactName = customer.ContactName;
                existing.ContactTitle = customer.ContactTitle;
                existing.Address = customer.Address;
                existing.Phone = customer.Phone;
            }
        }

        public static void DeleteCustomer(int id)
        {
            var customer = GetCustomerById(id);
            if (customer != null)
            {
                customers.Remove(customer);
            }
        }
    }
}
