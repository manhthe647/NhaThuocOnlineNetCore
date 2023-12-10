using Newtonsoft.Json;
using NhaThuocOnline.Application.ViewModels.Customer;
using NhaThuocOnline.ViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NhaThuocOnline.ApiIntergration
{
    public class CustomerApiClient : ICustomerApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CustomerApiClient(IHttpClientFactory httpClientFactory) { 
            _httpClientFactory = httpClientFactory;
        }
        public Task<string> Authencate(LoginRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<CustomerVm> GetCustomerById(int id)
        {
            var client = _httpClientFactory.CreateClient();

            var response = await client.GetAsync($"https://localhost:7128/api/customers/{id}");
            var body = await response.Content.ReadAsStringAsync();
            var customer = JsonConvert.DeserializeObject<CustomerVm>(body);
            return customer;
        }

        public async Task<List<CustomerVm>> GetCustomerPaging()
        {
            var client = _httpClientFactory.CreateClient();

            var response = await client.GetAsync("https://localhost:7128/api/customers");
            var body= await response.Content.ReadAsStringAsync();
            var customers= JsonConvert.DeserializeObject<List<CustomerVm>>(body);
            return customers;
        }

        public async Task<bool> Register(RegisterRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            var json= JsonConvert.SerializeObject(request);
            var httpContent= new StringContent(json,Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:7128/api/customers", httpContent);
            var result= await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return true;
            return false;

        }

        public async Task<bool> SoftDelete(int id)
        {
            var client= _httpClientFactory.CreateClient();
            var response = await client.PatchAsync($"https://localhost:7128/api/customers/{id}/softdelete", null);

            var result= await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return true;
            return false;
        }

        public async Task<bool> Update(int id,CustomerUpdateRequest request)
        {
            var client = _httpClientFactory.CreateClient();

            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"https://localhost:7128/api/customers/{id}", httpContent);

            var result = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode) 
                return true;
            return false;

        }
    }
}
