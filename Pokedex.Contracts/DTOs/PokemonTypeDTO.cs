using Newtonsoft.Json;

namespace Pokedex.Contracts.DTOs
{
    public class PokemonTypeDTO
    {
        [JsonProperty("slot")]
        public int Slot { get; set; }

        [JsonProperty("type")]
        public Type? Type { get; set; } = new Type();
    }

    public class Type
    {
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;
    }
}
