using System.Net.Http.Json;

namespace IgApplication.NorthwindCloudApp1
{
    public class NorthwindCloudApp1Service
    {
        private readonly HttpClient http;

        public NorthwindCloudApp1Service(HttpClient http)
        {
            this.http = http;
        }

        public async Task<ApiCustomersType[]?> GetApiCustomers()
        {
            return await this.http.GetFromJsonAsync<ApiCustomersType[]?>("http://northwindcloud.azurewebsites.net/api/customers");
        }
    }
}