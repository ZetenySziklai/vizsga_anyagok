using Allatgyogyaszat_GUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Allatgyogyaszat_GUI
{
    public class Gazda
    {
        [JsonPropertyName("id")]
        public int Id { get; init; }
        [JsonPropertyName("nev")]
        public string Nev { get; init; }
        [JsonPropertyName("telefon")]
        public string Telefon { get; init; }
        [JsonPropertyName("kerulet")]
        public int Kerulet { get; init; }
        [JsonPropertyName("email")]
        public string Email { get; init; }
        [JsonPropertyName("dogs")]
        public List<Kutya> Kutyak { get; init; }
        public override string ToString()
        {
            return string.Format($"{Nev} (Ker: {Kerulet}) Tel: {Telefon}\nEmail: {Email}");
        }
    }
}
