using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tuseTheProgrammer.Api.Services;
using tuseTheProgrammerBlazor.Models;

namespace tuseTheProgrammer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentsController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        [HttpGet]
        public async Task<ActionResult> GetAllDepartments()
        {
            try
            {
                return base.Ok(await _departmentRepository.GetAllDepartments());
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                     "There were error in retrieving the list of departments from the database!");
            }
        }

        [HttpGet(template:"{id:int}")]
        public async Task<ActionResult<Department>> GetDepartmentById(int id)
        {
            try
            {
                var result = await _departmentRepository.GetDepartmentById(id);
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
                   "There were error in retrieving the specific department from the database!");
            }
        }
    }
}
