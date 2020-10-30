﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tuseTheProgrammerBlazor.Models;

namespace tuseTheProgrammerBlazorApplication.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
    }
}