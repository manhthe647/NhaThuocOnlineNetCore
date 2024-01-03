using Newtonsoft.Json;
using NhaThuocOnline.ViewModel.Customer;
using NhaThuocOnline.ViewModel.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Intergration
{
    public class OrderApiClient : IOrderApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public OrderApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<List<OrderItemVm>> GetProductByCartId(string cartId)
        {
            var client = _httpClientFactory.CreateClient();

            var response = await client.GetAsync($"https://localhost:7128/api/orders/checkout?cartId={cartId}");
            var body = await response.Content.ReadAsStringAsync();
            var items = JsonConvert.DeserializeObject<List<OrderItemVm>>(body);
            return items;
        }
    }
}
