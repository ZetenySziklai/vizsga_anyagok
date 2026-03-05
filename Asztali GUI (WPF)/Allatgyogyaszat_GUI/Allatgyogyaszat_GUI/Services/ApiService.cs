using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Allatgyogyaszat_GUI
{
    internal class ApiService
    {
        private readonly HttpClient httpClient = new HttpClient { 
            BaseAddress = new Uri("http://localhost:3001")
        };

        public async Task<List<Gazda>> GetGazdakAsync()
        {
            try
            {
                var valasz = await httpClient.GetFromJsonAsync<List<Gazda>>("/api/owners");
                return valasz ?? new ();

            }
            catch(Exception ex) {
                Console.WriteLine($"Hiba történt: {ex.Message}");
                return new();
            }
        }

        public async Task<bool> AddGazdaAsync(Gazda gazda)
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync("/api/owners", gazda);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba történt a küldés során: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> DeleteGazdaAsync(int id)
        {
            try
            {
                var response = await httpClient.DeleteAsync($"/api/owners/{id}");
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba történt a küldés során: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> UpdateGazdaAsync(int id, Gazda gazda)
        {
            try
            {
                var response = await httpClient.PatchAsJsonAsync($"/api/owners/{id}",gazda);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                return false;
            }
        }        
    }
}
