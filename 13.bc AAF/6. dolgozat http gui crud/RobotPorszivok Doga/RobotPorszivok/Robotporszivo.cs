using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RobotPorszivok
{
    internal class Robotporszivo
    {
        [JsonPropertyName("id")]
        public int Id { get; init; }
        [JsonPropertyName("marka")]
        public string Marka { get; init; }
        [JsonPropertyName("tipus")]
        public string Tipus { get; init; }
        [JsonPropertyName("teljesitmeny")]
        public int Teljesitmeny { get; init; }
        [JsonPropertyName("ar")]
        public int Ar { get; init; }
    }
}
