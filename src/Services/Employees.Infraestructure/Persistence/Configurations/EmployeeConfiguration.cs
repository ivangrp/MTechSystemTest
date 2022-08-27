using Employees.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Employees.Infraestructure.Persistence.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(t => t.Name)
                .HasMaxLength(200)
                .IsRequired();
            builder.Property(t => t.LastName)
                .HasMaxLength(200)
                .IsRequired();
            builder.Property(t => t.RFC)
                .HasMaxLength(13)
                .IsRequired();
            builder.Property(t => t.Status)
                .IsRequired();
        }
    }
}
