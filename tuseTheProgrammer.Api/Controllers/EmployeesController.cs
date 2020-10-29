using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tuseTheProgrammer.Api.Services;
using tuseTheProgrammerBlazor.Models;

namespace tuseTheProgrammer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllEmployees()
        {
            try
            {
                return Ok(await _employeeRepository.GetEmployees());

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There were error in retrieving the data from the database!");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            try
            {
                var result = await _employeeRepository.GetEmployeeById(id);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There were error in retrieving the data from the database!");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> AddNewEmployee(Employee employee)
        {
            try
            {
                if (employee == null)
                {
                    return BadRequest();
                }
                var empEmail = await _employeeRepository.GetEmployeeByEmail(employee.Email);
                if (empEmail != null)
                {
                    ModelState.AddModelError("email", "Employee email is already in use.");
                    return BadRequest(ModelState);
                }

                var employeeCreated = await _employeeRepository.Create(employee);
                return CreatedAtAction(nameof(GetEmployee), new { id = employeeCreated.EmployeeId }, employeeCreated);

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                     "There were error in retrieving the data from the database!");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Employee>> UpdateEmployee(int id, Employee employee)
        {
            try
            {
                if (id != employee.EmployeeId)
                {
                    return BadRequest("Employee Id mismatch.");
                }
                var getUpdateEmployee = await _employeeRepository.GetEmployeeById(id);
                if(getUpdateEmployee != null)
                {
                    return await _employeeRepository.Update(employee);
                }
                else
                {
                    return NotFound($"Employee with Id = {id} not found");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
