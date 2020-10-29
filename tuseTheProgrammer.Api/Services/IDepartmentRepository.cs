using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tuseTheProgrammerBlazor.Models;

namespace tuseTheProgrammer.Api.Services
{
    public interface IDepartmentRepository
    {
        Department GetDepartmentById(int departmentId);
        IEnumerable<Department> GetAllDepartments();
    }
}
