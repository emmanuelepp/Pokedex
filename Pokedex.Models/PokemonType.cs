using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models
{
    public class PokemonType
    {
        [JsonProperty("slot")]
        public int Slot { get; set; }

        [JsonProperty("type")]
        public Type? Type { get; set; }
    }

    public class Type
    {
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;
    }
}
