using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allatgyogyaszat_GUI
{
    public class AdatokViewModel : INotifyPropertyChanged
    {
        private readonly ApiService apiService = new ApiService();

        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<Gazda> Gazdak { get; set; } = new();

        public async Task GazdakBetoltese()
        {
            Gazdak.Clear();
            var adatok = await apiService.GetGazdakAsync();
            foreach (var gazda in adatok)
            {
                Gazdak.Add(gazda);
            }
        }

        public async Task<bool> GazdaFeltoltese(Gazda gazda)
        {
            bool siker = await apiService.AddGazdaAsync(gazda);
            return siker;
        }

        public async Task<bool> GazdaTorlese(int id)
        {
            bool siker = await apiService.DeleteGazdaAsync(id);
            return siker;
        }

        public async Task<bool> GazdaModositas(int id, Gazda gazda)
        {
            bool siker = await apiService.UpdateGazdaAsync(id, gazda);
            return siker;
        }

    }
}
