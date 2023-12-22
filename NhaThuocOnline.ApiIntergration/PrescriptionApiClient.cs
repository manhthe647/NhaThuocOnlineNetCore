using Newtonsoft.Json;
using NhaThuocOnline.ViewModel.Coupon;
using NhaThuocOnline.ViewModel.Prescription;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.ApiIntergration
{
    public class PrescriptionApiClient : IPrescriptionApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public PrescriptionApiClient (IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<bool> Create(PrescriptionCreateRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            var multipartContent = new MultipartFormDataContent();

            // Thêm các trường dữ liệu vào multipartContent
            multipartContent.Add(new StringContent(request.CustomerNote), "CustomerNote");
            multipartContent.Add(new StringContent(request.CustomerName), "CustomerName");
            multipartContent.Add(new StringContent(request.CustomerPhone), "CustomerPhone");

            // Thêm tệp tin vào multipartContent (nếu có)
            if (request.ImagePath != null)
            {
                var fileContent = new StreamContent(request.ImagePath.OpenReadStream());
                fileContent.Headers.ContentType = new MediaTypeHeaderValue(request.ImagePath.ContentType);
                multipartContent.Add(fileContent, "ImagePath", request.ImagePath.FileName);
            }

            var response = await client.PostAsync("https://localhost:7128/api/prescriptions", multipartContent);
            var result = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
                return true;

            return false;
        }
        public async Task<List<PrescriptionVm>> GetAll()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7128/api/prescriptions");
            var body = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<PrescriptionVm>>(body);
            return results;
        }
    }
}
