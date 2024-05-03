using AppDesktop.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop.APIservice
{
    public class ServiceApiService
    {
        private readonly HttpClient _httpClient;

        public ServiceApiService(string baseUri)
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseUri)
            };
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<ServiceDto>> GetAllServices()
        {
            HttpResponseMessage response = await _httpClient.GetAsync("api/service/");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            

            return  JsonConvert.DeserializeObject<List<ServiceDto>>(responseBody);
        }

        public async Task<ServiceDto> GetServiceById(int id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"api/service/{id}");
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ServiceDto>(responseBody);
            }
            return null;
        }

        public async Task<bool> CreateService(ServiceDto service)
        {
            string json = JsonConvert.SerializeObject(service);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync("api/service", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateService(int id, ServiceDto service)
        {
            string json = JsonConvert.SerializeObject(service);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PutAsync($"api/service/{id}", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteService(int id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync($"api/service/{id}");
           
            return response.IsSuccessStatusCode;
        }

    }
}
