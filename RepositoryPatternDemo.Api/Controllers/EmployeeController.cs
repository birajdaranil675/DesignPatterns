using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternDemo.Api.Models;
using RepositoryPatternDemo.Api.Repository.Interfaces;

namespace RepositoryPatternDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServices _services;

        public EmployeeController(IEmployeeServices employeeServices)
        {
            _services = employeeServices;
        }

        [HttpGet]
        [Route("/GetAll")]
        public List<MyEmployee> GetAllEmployees()
        {
            var employees = _services.GetEmployees();
            return employees;
        }
    }
}
