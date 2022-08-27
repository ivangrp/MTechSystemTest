using Dapper;
using Employees.Application.Common.Interfaces;
using Employees.Domain.Entities;
using Employees.Infraestructure.Repository.Query.Base;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace Employees.Infraestructure.Repository.Query
{
    public class EmployeeQueryRepository : QueryRepository<Employee>, IEmployeeQueryRepository
    {
        public EmployeeQueryRepository(IConfiguration configuration) 
            : base(configuration)
        {
        }

        public async Task<IReadOnlyList<Employee>> GetAllAsync()
        {
            try
            {
                var query = "SELECT * FROM EMPLOYEES"; // No se debe utilizar la consulta directamente, si no por sp, pero por falta de tiempo lo dejo asi.

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Employee>(query)).OrderBy(r => r.BornDate).ToList();
                }
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Employee> GetByIdAsync(long id)
        {
            try
            {
                var query = "SELECT * FROM EMPLOYEES WHERE ID = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("Id", id, DbType.Int64);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Employee>(query, parameters));
                }
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<Employee>> GetEmployeeByName(string name)
        {
            try
            {
                var query = "SELECT * FROM EMPLOYEES WHERE Name = @name";
                var parameters = new DynamicParameters();
                parameters.Add("Name", name, DbType.String);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Employee>(query, parameters)).ToList();
                }
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }
    }
}
