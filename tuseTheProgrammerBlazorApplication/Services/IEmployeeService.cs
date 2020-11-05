using System.Collections.Generic;
using System.Threading.Tasks;
using tuseTheProgrammerBlazor.Models;

namespace tuseTheProgrammerBlazorApplication.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployeeById(int id);
        Task<Employee> UpdateEmployee(Employee updatedEmployee);
        Task<Employee> CreateEmployee(Employee newEmployee);
        Task DeleteEmployee(int id);
    }
}
