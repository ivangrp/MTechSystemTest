using Employees.Application.Common.Interfaces;
using Employees.Domain.Entities;
using Employees.Infraestructure.Persistence;
using Employees.Infraestructure.Repository.Command.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Infraestructure.Repository.Command
{
    public class EmployeeCommandRepository : CommandRepository<Employee>, IEmployeeCommandRepository
    {
        public EmployeeCommandRepository(EmployeeContext context) : base(context)
        {
        }
    }
}
