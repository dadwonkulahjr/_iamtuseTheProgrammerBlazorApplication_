using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tuseTheProgrammerBlazor.Models;

namespace tuseTheProgrammer.Api.Services
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> Create(Employee employee);
        Task<Employee> Update(Employee employee);
        Task<Employee> GetEmployeeById(int employeeId);
        Task<Employee> Delete(int employeeId);
        Task<IEnumerable<Employee>> Search(string name, Gender? gender);
        Task<Employee> GetEmployeeByEmail(string email);
    }
}
