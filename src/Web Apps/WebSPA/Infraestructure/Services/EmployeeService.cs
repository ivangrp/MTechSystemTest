using Microsoft.Extensions.Options;
using WebSPA.Infraestructure.Common;
using WebSPA.Infraestructure.Config;
using WebSPA.Models;

namespace WebSPA.Infraestructure.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _apiClient;
        private readonly UrlsConfig _urls;

        public EmployeeService(HttpClient httpClient, IOptions<UrlsConfig> config)
        {
            _apiClient = httpClient;
            _urls = config.Value;
        }

        public async Task<List<Employee>> GetEmployee() 
        {
            var url = _urls.Employee;

            var response = await _apiClient.GetAsync(url);

            return await response.ReadContentAs<List<Employee>>();
        }

        public async Task<List<Employee>> GetEmployeByName(string name)
        {
            var url = $"{_urls.Employee}{string.Format(UrlsConfig.EmployeeOperations.ByName, name)}";

            var response = await _apiClient.GetAsync(url);

            return await response.ReadContentAs<List<Employee>>();
        }

        public async Task<int> CreateEmployee(Employee request)
        {
            var url = _urls.Employee;
            
            var response = await _apiClient.PostAsJson(url, request);
            
            return await response.ReadContentAs<int>();
        }
    }
}
