using RepositoryPatternDemo.Api.Models;

namespace RepositoryPatternDemo.Api.Repository.Interfaces
{
    public interface IEmployeeServices
    {
        void AddEmployee(MyEmployee employee);
        List<MyEmployee> GetEmployees();
        MyEmployee GetEmployee(int id);
        void DeleteEmployee(MyEmployee employee);
    }
}
