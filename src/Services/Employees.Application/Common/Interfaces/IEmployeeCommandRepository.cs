﻿using Employees.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Application.Common.Interfaces
{
    public interface IEmployeeCommandRepository : ICommandRepository<Employee>
    {
    }
}
