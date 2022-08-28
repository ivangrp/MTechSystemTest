using WebSPA.Models;

namespace WebSPA.Infraestructure.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployee();
        Task<List<Employee>> GetEmployeByName(string name);
        Task<int> CreateEmployee(Employee request);
    }
}
