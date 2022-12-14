using Employees.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employees.Domain.Entities
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string RFC { get; set; }

        public DateTime BornDate { get; set; }

        public EmployeeStatus Status { get; set; }
    }
}
