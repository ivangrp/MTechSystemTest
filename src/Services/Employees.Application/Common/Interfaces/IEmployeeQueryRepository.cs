using Employees.Domain.Entities;

namespace Employees.Application.Common.Interfaces
{
    public interface IEmployeeQueryRepository : IQueryRepository<Employee>
    {
        Task<IReadOnlyList<Employee>> GetAllAsync();
        Task<Employee> GetByIdAsync(Int64 id);
        Task<IReadOnlyList<Employee>> GetEmployeeByName(string name);
    }
}
