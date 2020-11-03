using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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
        public async Task<IEnumerable<Department>> GetAllDepartments()
        {
            return await _appDbContext.Departments.ToListAsync();
        }

        public async Task<Department> GetDepartmentById(int departmentId)
        {
            return await _appDbContext.Departments.FindAsync(departmentId);
        }
    }
}
