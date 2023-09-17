using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models
{
    public class Pokemon
    {
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("types")]
        public List<PokemonType> Types { get; set; } = new List<PokemonType>();

        [JsonProperty("sprites")]
        public Sprite Sprites { get; set; } = new Sprite();

    }
}
