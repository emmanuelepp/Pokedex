using Newtonsoft.Json;

namespace Pokedex.Contracts.DTOs
{
    public class PokemonDTO
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("types")]
        public List<PokemonTypeDTO> Types { get; set; } = new List<PokemonTypeDTO>();

        [JsonProperty("sprites")]
        public SpriteDTO Sprites { get; set; } = new SpriteDTO();

        [JsonProperty("weight")]
        public int Weight { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("base_experience")]
        public int Experience { get; set; }


    }
}
