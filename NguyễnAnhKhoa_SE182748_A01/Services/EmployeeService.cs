using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using Repositories;

namespace Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository repo = EmployeeRepository.Instance;

        public List<Employee> GetEmployees() => repo.GetEmployees();
        public Employee? GetById(int id) => repo.GetById(id);
        public Employee? GetByCredentials(string username, string password) => repo.GetByCredentials(username, password);
        public void AddEmployee(Employee employee) => repo.AddEmployee(employee);
        public void UpdateEmployee(Employee employee) => repo.UpdateEmployee(employee);
        public void DeleteEmployee(int id) => repo.DeleteEmployee(id);
    }
}
