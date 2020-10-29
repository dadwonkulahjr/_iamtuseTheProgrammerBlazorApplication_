using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tuseTheProgrammer.Api.Models;
using tuseTheProgrammerBlazor.Models;

namespace tuseTheProgrammer.Api.Services
{
    public class DepartmentService : IDepartmentRepository
    {
        private readonly AppDbContext _appDbContext;

        public DepartmentService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Department> GetAllDepartments()
        {
            return _appDbContext.Departments.ToList();
        }

        public Department GetDepartmentById(int departmentId)
        {
            return _appDbContext.Departments.Find(departmentId);
        }
    }
}
