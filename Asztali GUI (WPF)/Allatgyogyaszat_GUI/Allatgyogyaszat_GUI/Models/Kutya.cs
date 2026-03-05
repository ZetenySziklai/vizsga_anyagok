using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Allatgyogyaszat_GUI.Models
{
    public class Kutya
    {
        [JsonPropertyName("id")]
        public int Id { get; init; }
        [JsonPropertyName("nem")]
        public bool Kan { get; init; }
        [JsonPropertyName("korEv")]
        public int korEv { get; init; }
        [JsonPropertyName("korHonap")]
        public int korHonap { get; init; }

    }
}
