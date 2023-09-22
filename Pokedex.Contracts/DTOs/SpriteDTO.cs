using Newtonsoft.Json;

namespace Pokedex.Contracts.DTOs
{
    public class SpriteDTO
    {
        [JsonProperty("front_default")]
        public string Front { get; set; } = string.Empty;

        [JsonProperty("back_default")]
        public string Back { get; set; } = string.Empty;
    }
}
