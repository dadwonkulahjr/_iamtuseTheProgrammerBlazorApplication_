﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tuseTheProgrammer.Api.Models;
using tuseTheProgrammerBlazor.Models;

namespace tuseTheProgrammer.Api.Services
{
    public class EmployeeService : IEmployeeRepository
    {
        private readonly AppDbContext _dbContext;

        public EmployeeService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Employee> Create(Employee employee)
        {
            var result = await _dbContext.Employees.AddAsync(employee);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async void Delete(int employeeId)
        {
            var employeeFound = await _dbContext.Employees.FirstOrDefaultAsync(e =>
            e.EmployeeId == employeeId);
            if (employeeFound != null)
            {
                _dbContext.Employees.Remove(employeeFound);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<Employee> GetEmployeeByEmail(string email)
        {
            return await _dbContext.Employees.FirstOrDefaultAsync(e => e.Email == email);
        }

        public async Task<Employee> GetEmployeeById(int employeeId)
        {
            return await _dbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _dbContext.Employees.ToListAsync();
        }

        public async Task<Employee> Update(Employee employee)
        {
            var findEmployee = await _dbContext.Employees.FirstOrDefaultAsync(e =>
            e.EmployeeId == employee.EmployeeId);
            if (findEmployee != null)
            {
                findEmployee.FirstName = employee.FirstName;
                findEmployee.LastName = employee.LastName;
                findEmployee.Email = employee.Email;
                findEmployee.BirthDate = employee.BirthDate;
                findEmployee.DepartmentId = employee.DepartmentId;
                findEmployee.Gender = employee.Gender;
                findEmployee.PhotoPath = employee.PhotoPath;

                await _dbContext.SaveChangesAsync();
                return findEmployee;

            }

            return null;
        }
    }
}
