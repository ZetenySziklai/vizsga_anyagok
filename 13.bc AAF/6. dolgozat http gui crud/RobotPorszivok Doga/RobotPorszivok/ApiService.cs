using RobotPorszivok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RobotPorszivok
{
    internal class ApiService
    {
        private readonly HttpClient httpClient = new HttpClient { 
            BaseAddress = new Uri("http://localhost:3001")
        };

        public async Task<List<Ertekeles>> GetErtekelesekAsync()
        {
            try
            {
                var valasz = await httpClient.GetFromJsonAsync<List<Ertekeles>>("/api/ertekelesek");
                return valasz ?? new ();

            }
            catch(Exception ex) {
                Console.WriteLine($"Hiba történt: {ex.Message}");
                return new();
            }
        }

        public async Task<bool> AddErtekelesAsync(Ertekeles ertekeles)
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync("/api/ertekelesek", ertekeles);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Hiba történt a küldés során: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> DeleteErtekelesAsync(int id)
        {
            try
            {
                var response = await httpClient.DeleteAsync($"/api/ertekelesek/{id}");
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Hiba történt a küldés során: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> UpdateErtekelesAsync(int id, Ertekeles ertekeles)
        {
            try
            {
                var response = await httpClient.PutAsJsonAsync($"/api/ertekelesek/{id}",ertekeles);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<List<Robotporszivo>> GetRobotproszivokAsync()
        {
            try
            {
                var valasz = await httpClient.GetFromJsonAsync<List<Robotporszivo>>("/api/robotporszivo");
                return valasz ?? new();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba történt: {ex.Message}");
                return new();
            }
        }

        public async Task<bool> AddRobotporszivoAsync(Robotporszivo rporszivo)
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync("/api/robotporszivo", rporszivo);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> DeleteRobotporszivoAsync(int id)
        {
            try
            {
                var response = await httpClient.DeleteAsync($"/api/robotporszivo/{id}");
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> UpdateRobotporszivoAsync(int id, Robotporszivo rporszivo)
        {
            try
            {
                var response = await httpClient.PutAsJsonAsync($"/api/robotporszivo/{id}", rporszivo);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Hiba történt a küldés során: {ex.Message}");
                return false;
            }
        }
    }
}
