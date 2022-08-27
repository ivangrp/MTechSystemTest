using Employees.Application.Common.Interfaces;
using Employees.Application.Common.Mapper;
using MediatR;

namespace Employees.Application.Employees.Query
{
    public class GetEmployeeByNameQuery : IRequest<List<EmployeeDto>>
    {
        public string Name { get; set; }

        public GetEmployeeByNameQuery(string name)
        {
            this.Name = name;
        }
    }

    public class GetEmployeeByNameQueryHandler : IRequestHandler<GetEmployeeByNameQuery, List<EmployeeDto>>
    {
        private readonly IEmployeeQueryRepository _employeeQueryRepository;

        public GetEmployeeByNameQueryHandler(IEmployeeQueryRepository employeeQueryRepository)
        {
            _employeeQueryRepository = employeeQueryRepository;
        }

        public async Task<List<EmployeeDto>> Handle(GetEmployeeByNameQuery request, CancellationToken cancellationToken)
        {
            var employees = await _employeeQueryRepository.GetEmployeeByName(request.Name);
            var response = CustomerMapper.Mapper.Map<List<EmployeeDto>>(employees);
            return response;
        }
    }
}
