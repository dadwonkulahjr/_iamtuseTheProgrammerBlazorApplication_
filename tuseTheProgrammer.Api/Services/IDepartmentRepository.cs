﻿using System.Collections.Generic;
using System.Threading.Tasks;
using tuseTheProgrammerBlazor.Models;

namespace tuseTheProgrammer.Api.Services
{
    public interface IDepartmentRepository
    {
        Task<Department> GetDepartmentById(int departmentId);
        Task<IEnumerable<Department>> GetAllDepartments();
    }
}
