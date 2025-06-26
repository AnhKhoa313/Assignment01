using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccessLayer
{
    public static class DataSource
    {
        public static void SeedData()
        {
            // Customers
            CustomerDAO.GetCustomers().AddRange(new List<Customer>
            {
                new Customer { CustomerID = 1, CompanyName = "Alpha Co", ContactName = "John", ContactTitle = "Manager", Address = "123 Main St", Phone = "0123456789" },
                new Customer { CustomerID = 2, CompanyName = "Beta Ltd", ContactName = "Anna", ContactTitle = "CEO", Address = "456 Oak St", Phone = "0987654321" },
                new Customer { CustomerID = 3, CompanyName = "Gamma Inc", ContactName = "Mike", ContactTitle = "Sales", Address = "789 Pine St", Phone = "0909090909" },
                new Customer { CustomerID = 4, CompanyName = "Delta Co", ContactName = "Linda", ContactTitle = "CTO", Address = "321 Elm St", Phone = "0333444555" }
            });

            // Categories
            CategoryDAO.GetCategories().AddRange(new List<Category>
            {
                new Category { CategoryID = 1, CategoryName = "Electronics", Description = "Electronic items" },
                new Category { CategoryID = 2, CategoryName = "Clothing", Description = "Men and Women Clothes" },
                new Category { CategoryID = 3, CategoryName = "Books", Description = "Various Books" },
                new Category { CategoryID = 4, CategoryName = "Groceries", Description = "Daily food items" }
            });

            // Products
            ProductDAO.GetProducts().AddRange(new List<Product>
            {
                new Product { ProductID = 1, ProductName = "Laptop", CategoryID = 1, UnitPrice = 1000, UnitsInStock = 10 },
                new Product { ProductID = 2, ProductName = "T-shirt", CategoryID = 2, UnitPrice = 20, UnitsInStock = 50 },
                new Product { ProductID = 3, ProductName = "Book: C# Guide", CategoryID = 3, UnitPrice = 30, UnitsInStock = 40 },
                new Product { ProductID = 4, ProductName = "Rice 5kg", CategoryID = 4, UnitPrice = 15, UnitsInStock = 100 }
            });

            // Employees
            EmployeeDAO.GetEmployees().AddRange(new List<Employee>
            {
                new Employee { EmployeeID = 1, Name = "Adam", UserName = "admin1", Password = "123456", JobTitle = "Admin" },
                new Employee { EmployeeID = 2, Name = "Baldad", UserName = "admin2", Password = "234567", JobTitle = "Admin" },
                new Employee { EmployeeID = 3, Name = "Carl", UserName = "employ1", Password = "478998", JobTitle = "Sales" },
                new Employee { EmployeeID = 4, Name = "Dave", UserName = "employ2", Password = "989898", JobTitle = "Support" }
            });

            // Orders
            OrderDAO.GetOrders().AddRange(new List<Order>
            {
                new Order { OrderID = 1, CustomerID = 1, EmployeeID = 1, OrderDate = DateTime.Now.AddDays(-3) },
                new Order { OrderID = 2, CustomerID = 2, EmployeeID = 2, OrderDate = DateTime.Now.AddDays(-2) },
                new Order { OrderID = 3, CustomerID = 3, EmployeeID = 1, OrderDate = DateTime.Now.AddDays(-1) },
                new Order { OrderID = 4, CustomerID = 4, EmployeeID = 3, OrderDate = DateTime.Now }
            });

            // Order Details
            OrderDetailDAO.GetOrderDetails().AddRange(new List<OrderDetail>
            {
                new OrderDetail { OrderID = 1, ProductID = 1, UnitPrice = 1000, Quantity = 1, Discount = 0.1f },
                new OrderDetail { OrderID = 2, ProductID = 2, UnitPrice = 20, Quantity = 3, Discount = 0 },
                new OrderDetail { OrderID = 3, ProductID = 3, UnitPrice = 30, Quantity = 2, Discount = 0.05f },
                new OrderDetail { OrderID = 4, ProductID = 4, UnitPrice = 15, Quantity = 5, Discount = 0 }
            });
        }
    }
}
