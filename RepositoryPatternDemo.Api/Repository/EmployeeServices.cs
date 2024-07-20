using RepositoryPatternDemo.Api.Data;
using RepositoryPatternDemo.Api.Models;
using RepositoryPatternDemo.Api.Repository.Interfaces;

namespace RepositoryPatternDemo.Api.Repository
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly EmployeeDbContext _employeeDbContext;

        public EmployeeServices(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }

        public void AddEmployee(MyEmployee employee)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(MyEmployee employee)
        {
            throw new NotImplementedException();
        }

        public MyEmployee GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public List<MyEmployee> GetEmployees()
        {
            var employees = _employeeDbContext.Employees.ToList();

            return employees;
        }
    }
}
