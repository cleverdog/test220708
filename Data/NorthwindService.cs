using System.Net.Http.Json;

namespace IgApplication.Northwind
{
    public class NorthwindService
    {
        private readonly HttpClient http;

        public NorthwindService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<EmployeesType[]?> GetEmployees()
        {
            return await http.GetFromJsonAsync<EmployeesType[]?>("static-data/northwind-employees.json");
        }
    }
}