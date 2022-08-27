using Employees.Application.Common.Interfaces;
using Employees.Infraestructure.Persistence;
using Microsoft.Extensions.Configuration;

namespace Employees.Infraestructure.Repository.Query.Base
{
    public class QueryRepository<T> : DbConnector, IQueryRepository<T> where T : class
    {
        protected QueryRepository(IConfiguration configuration) 
            : base(configuration)
        {
        }
    }
}
