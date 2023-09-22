using Newtonsoft.Json;

namespace Pokedex.Contracts.DTOs
{
    public class PokemonsResultObjectDTO
    {
        [JsonProperty("results")]
        public IEnumerable<PokemonDTO> Pokemons { get; set; } = new List<PokemonDTO>();
    }
}
