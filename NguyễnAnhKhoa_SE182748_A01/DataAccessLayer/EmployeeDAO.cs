using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using System.Xml.Linq;

namespace DataAccessLayer
{
    public class EmployeeDAO
    {
        private static List<Employee> employees = new();
        private static readonly object lockObj = new();

        public static List<Employee> GetEmployees() => employees;

        public static Employee? GetById(int id) =>
            employees.FirstOrDefault(e => e.EmployeeID == id);

        public static Employee? GetByCredentials(string username, string password) =>
            employees.FirstOrDefault(e => e.UserName == username && e.Password == password);

        public static void AddEmployee(Employee employee)
        {
            lock (lockObj)
            {
                employees.Add(employee);
            }
        }

        public static void UpdateEmployee(Employee employee)
        {
            var existing = GetById(employee.EmployeeID);
            if (existing != null)
            {
                existing.Name = employee.Name;
                existing.UserName = employee.UserName;
                existing.Password = employee.Password;
                existing.JobTitle = employee.JobTitle;
            }
        }

        public static void DeleteEmployee(int id)
        {
            var emp = GetById(id);
            if (emp != null)
            {
                employees.Remove(emp);
            }
        }
    }
}
