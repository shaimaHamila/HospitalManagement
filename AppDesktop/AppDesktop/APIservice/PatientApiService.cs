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
    internal class PatientApiService
    {
        private readonly HttpClient _httpClient;

        public PatientApiService(string baseUri)
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseUri)
            };
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<PatientDto>> GetAllPatients()
        {
            HttpResponseMessage response = await _httpClient.GetAsync("api/patient");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<PatientDto>>(responseBody);
        }

        public async Task<PatientDto> GetPatientById(int id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"api/patient/{id}");
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<PatientDto>(responseBody);
            }
            return null;
        }

        public async Task<bool> CreatePatient(PatientDto patient)
        {
            string json = JsonConvert.SerializeObject(patient);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync("api/patient", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdatePatient(int id, PatientDto patient)
        {
            string json = JsonConvert.SerializeObject(patient);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PutAsync($"api/patient/{id}", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeletePatient(int id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync($"api/patient/{id}");
            return response.IsSuccessStatusCode;
        }
    }

}
