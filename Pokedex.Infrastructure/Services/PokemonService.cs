using Newtonsoft.Json;
using Pokedex.Contracts.DTOs;
using Pokedex.Contracts.Interfaces;

namespace Pokedex.Infrastructure.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly HttpClient _httpClient;

        public PokemonService(HttpClient httpClient)
        {

            _httpClient = httpClient;

        }

        public async Task<IEnumerable<PokemonDTO>> GetAllPokemons()
        {
            var pokemons = JsonConvert.DeserializeObject<PokemonsResultObjectDTO>(
            await _httpClient.GetStringAsync($"pokemon?limit=24&offset=24"));

            var result = new List<PokemonDTO>();

            foreach (var item in pokemons.Pokemons)
            {
                result.Add(await GetPokemon(item.Name));
            }

            return result;
        }

        public async Task<PokemonDTO> GetPokemon(string name)
        {
            return JsonConvert.DeserializeObject<PokemonDTO>(
            await _httpClient.GetStringAsync($"pokemon/{name}"));
        }
    }
}
