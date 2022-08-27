using Employees.Application.Common.Interfaces;
using Employees.Domain.Entities;
using Employees.Infraestructure.Persistence;
using Employees.Infraestructure.Repository.Command.Base;

namespace Employees.Infraestructure.Repository.Command
{
    public class EmployeeCommandRepository : CommandRepository<Employee>, IEmployeeCommandRepository
    {
        public EmployeeCommandRepository(EmployeeContext context) : base(context)
        {
        }
    }
}
