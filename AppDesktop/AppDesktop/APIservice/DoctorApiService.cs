using AppDesktop.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;using System.Net.Http;
using System.Net.Http.Headers;


namespace AppDesktop.APIservice
{
    public class DoctorApiService
    {
        private readonly HttpClient _httpClient;

        public DoctorApiService(string baseUrl)
        {
            _httpClient = new HttpClient { BaseAddress = new Uri(baseUrl) };

            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<DoctorDto>> GetAllDoctors()
        {
            HttpResponseMessage response = await _httpClient.GetAsync("api/doctor");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<DoctorDto>>(responseBody);
        }

        public async Task<DoctorDto> GetDoctorById(int id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"api/doctor/{id}");
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<DoctorDto>(responseBody);
            }
            return null;
        }

        public async Task<bool> CreateDoctor(DoctorDto doctor)
        {
            string json = JsonConvert.SerializeObject(doctor);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync("api/doctor", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateDoctor(int id, DoctorDto doctor)
        {
            string json = JsonConvert.SerializeObject(doctor);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PutAsync($"api/doctor/{id}", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteDoctor(int id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync($"api/doctor/{id}");
            return response.IsSuccessStatusCode;
        }
        public async Task<List<int>> GetServiceIds()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("api/service");
                if (response.IsSuccessStatusCode)
                {
                    List<ServiceDto> services = await response.Content.ReadAsAsync<List<ServiceDto>>();
                    return services.Select(s => s.Id).ToList();
                }
                else
                {
                    Console.WriteLine("Failed to retrieve Service IDs: " + response.ReasonPhrase);
                    return new List<int>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while retrieving Service IDs: " + ex.Message);
                return new List<int>();
            }

        }
    }
}
