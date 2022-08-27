using Employees.Domain.Enums;

namespace Employees.Application.Employees.Query
{
    public class EmployeeResponse
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string RFC { get; set; }

        public DateTime BornDate { get; set; }

        public EmployeeStatus Status { get; set; }
    }
}
