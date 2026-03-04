using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RobotPorszivok
{
    internal class Ertekeles
    {
        [JsonPropertyName("id")]
        public int Id { get; init; }
        [JsonPropertyName("robot_id")]
        public int RobotId { get; init; }
        [JsonPropertyName("felhasznalonev")]
        public string Felhasznalonev { get; init; }
        [JsonPropertyName("csillagszam")]
        public int Csillagszam { get; init; }
        [JsonPropertyName("szoveg")]
        public string Szoveg { get; init; }
        [JsonPropertyName("marka")]
        public string Marka { get; init; }
        [JsonPropertyName("tipus")]
        public string Tipus { get; init; }
        
    }
}
