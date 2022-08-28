namespace WebSPA.Infraestructure.Config
{
    public class UrlsConfig
    {
        public UrlsConfig()
        {
            Employee = "";
        }

        public static class EmployeeOperations
        {
            public const string Employees = "/employees";
            public const string ByName = "/employees?name={0}";
        }

        public string Employee { get; set; }
    }
}
