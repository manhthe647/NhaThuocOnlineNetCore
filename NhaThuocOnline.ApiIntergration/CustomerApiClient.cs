﻿using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using NhaThuocOnline.Utilities.Exceptions;
using NhaThuocOnline.ViewModel.Common;
using NhaThuocOnline.ViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NhaThuocOnline.ApiIntergration
{
    public class CustomerApiClient : ICustomerApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public CustomerApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration) { 
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }



        public async Task<ApiResult<string>> Authenticate(LoginRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:7128");
            var response = await client.PostAsync("/api/customers/login", httpContent);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ApiSuccessResult<string>>(await response.Content.ReadAsStringAsync());
            }

            return JsonConvert.DeserializeObject<ApiErrorResult<string>>(await response.Content.ReadAsStringAsync());
        }

        public async Task<List<CustomerAddressVm>> GetCustomerAddresses(int customerId)
        {
            var client = _httpClientFactory.CreateClient();

            var response = await client.GetAsync($"https://localhost:7128/api/customers/{customerId}/addresses");
            var body = await response.Content.ReadAsStringAsync();
            var customerAddresses = JsonConvert.DeserializeObject<List<CustomerAddressVm>>(body);
            return customerAddresses;
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
