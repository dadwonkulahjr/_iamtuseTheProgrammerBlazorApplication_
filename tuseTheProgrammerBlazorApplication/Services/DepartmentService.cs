using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using tuseTheProgrammerBlazor.Models;

namespace tuseTheProgrammerBlazorApplication.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly HttpClient _httpClient;
        public DepartmentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Department>> GetAllDepartments()
        {
            return await _httpClient.GetJsonAsync<Department[]>("api/departments");
        }
        public async Task<Department> GetDepartmentById(int departmentId)
        {
            return await _httpClient.GetJsonAsync<Department>($"api/departments/{departmentId}");
        }
    }
}
