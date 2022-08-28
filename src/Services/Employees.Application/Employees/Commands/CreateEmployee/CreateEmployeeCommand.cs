using Employees.Application.Common.Interfaces;
using Employees.Application.Common.Mapper;
using Employees.Domain.Entities;
using Employees.Domain.Enums;
using MediatR;

namespace Employees.Application.Employees.Commands.CreateEmployee
{
    public class CreateEmployeeCommand : IRequest<int>
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public string RFC { get; set; }

        public DateTime BornDate { get; set; }

        public EmployeeStatus Status { get; set; }
    }

    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, int>
    {
        private readonly IEmployeeCommandRepository _employeeCommandRepository;
        private readonly IEmployeeQueryRepository _employeeQueryRepository;

        public CreateEmployeeCommandHandler(IEmployeeCommandRepository employeeCommandRepository
            , IEmployeeQueryRepository employeeQueryRepository)
        {
            _employeeCommandRepository = employeeCommandRepository;
            _employeeQueryRepository = employeeQueryRepository;
        }

        public async Task<int> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employeeEntity = CustomerMapper.Mapper.Map<Employee>(request);

            if (employeeEntity is null)
            {
                throw new ArgumentException("There is a problem in mapper.");
            }

            var findRfc = await _employeeQueryRepository.GetByRfc(request.RFC);
            if(findRfc is not null)
            {
                throw new ArgumentException($"The RFC {request.RFC} is in use.");
            }

            var newEmployee = await _employeeCommandRepository.AddAsync(employeeEntity);
            
            return newEmployee.ID;
        }
    }
}
