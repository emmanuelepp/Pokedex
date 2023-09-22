using Newtonsoft.Json;

namespace Pokedex.Contracts.DTOs
{
    public class PokemonDTO
    {
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("types")]
        public List<PokemonTypeDTO> Types { get; set; } = new List<PokemonTypeDTO>();

        [JsonProperty("sprites")]
        public SpriteDTO Sprites { get; set; } = new SpriteDTO();

    }
}
