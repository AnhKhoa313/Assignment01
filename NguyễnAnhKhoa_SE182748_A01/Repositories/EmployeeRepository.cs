using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private static readonly EmployeeRepository instance = new();
        public static EmployeeRepository Instance => instance;

        private EmployeeRepository() { }

        public List<Employee> GetEmployees() => EmployeeDAO.GetEmployees();
        public Employee? GetById(int id) => EmployeeDAO.GetById(id);
        public Employee? GetByCredentials(string username, string password) => EmployeeDAO.GetByCredentials(username, password);
        public void AddEmployee(Employee employee) => EmployeeDAO.AddEmployee(employee);
        public void UpdateEmployee(Employee employee) => EmployeeDAO.UpdateEmployee(employee);
        public void DeleteEmployee(int id) => EmployeeDAO.DeleteEmployee(id);
    }
}
