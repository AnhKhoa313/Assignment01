using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace Services
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
        Employee? GetById(int id);
        Employee? GetByCredentials(string username, string password);
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
    }
}
