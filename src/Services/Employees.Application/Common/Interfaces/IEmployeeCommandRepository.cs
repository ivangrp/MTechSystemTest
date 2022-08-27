using Employees.Domain.Entities;

namespace Employees.Application.Common.Interfaces
{
    public interface IEmployeeCommandRepository : ICommandRepository<Employee>
    {
    }
}
