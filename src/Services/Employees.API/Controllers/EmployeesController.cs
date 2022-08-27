using Employees.Application.Employees.Commands.CreateEmployee;
using Employees.Application.Employees.Query;
using Microsoft.AspNetCore.Mvc;

namespace Employees.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<EmployeeDto>>> Get()
        {
            return await Mediator.Send(new GetAllEmployeesQuery());
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<List<EmployeeDto>>> GetByName(string name)
        {
            return await Mediator.Send(new GetEmployeeByNameQuery(name));
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateEmployeeCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
