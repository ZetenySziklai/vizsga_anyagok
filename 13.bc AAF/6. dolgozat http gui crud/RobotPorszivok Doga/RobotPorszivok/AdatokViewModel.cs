using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotPorszivok
{
    class AdatokViewModel : INotifyPropertyChanged
    {
        private readonly ApiService apiService = new ApiService();

        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<Ertekeles> Ertekelesek { get; set; } = new();
        public ObservableCollection<Robotporszivo> RobotPorszivok { get; set; } = new();

        public async Task ErtekelesekBetoltese()
        {
            Ertekelesek.Clear();
            var adatok = await apiService.GetErtekelesekAsync();
            foreach (var ertekeles in adatok)
            { 
                Ertekelesek.Add(ertekeles);
            }
        }

        public async Task<bool> ErtekelesekFeltoltese(Ertekeles ertekeles)
        {
            bool siker = await apiService.AddErtekelesAsync(ertekeles);
            return siker;
        }

        public async Task<bool> ErtekelesTorlese(int id)
        {
            bool siker = await apiService.DeleteErtekelesAsync(id);
            return siker;
        }

        public async Task<bool> ErtekelesModositas(int id, Ertekeles ertekeles)
        {
            bool siker = await apiService.UpdateErtekelesAsync(id, ertekeles);
            return siker;
        }

        public async Task RobotPorszivokBetoltese()
        {
            RobotPorszivok.Clear();
            var adatok = await apiService.GetRobotproszivokAsync();
            foreach (var porszivo in adatok)
            {
                RobotPorszivok.Add(porszivo);
            }
        }

        public async Task<bool> RobotPorszivokFeltoltese(Robotporszivo rporszivo)
        {
            bool siker = await apiService.AddRobotporszivoAsync(rporszivo);
            return siker;
        }

        public async Task<bool> RobotPorszivoTorlese(int id)
        {
            bool siker = await apiService.DeleteRobotporszivoAsync(id);
            return siker;
        }

        public async Task<bool> RobotPorszivoModositas(int id, Robotporszivo rporszivo)
        {
            bool siker = await apiService.UpdateRobotporszivoAsync(id, rporszivo);
            return siker;
        }
    }
}
