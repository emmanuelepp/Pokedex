using Pokedex.Models;
using System.Net.Http.Json;

namespace Pokedex.Client.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly HttpClient _httpClient;

        public PokemonService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<Pokemon> Pokemons { get; set; } = new List<Pokemon>();

        public async Task<IEnumerable<Pokemon>> GetAllPokemons()
        {
            var result = await _httpClient.GetFromJsonAsync<List<Pokemon>>("https://localhost:7266/api/Pokemon/get-pokemons");
            return result;
        }

        Task IPokemonService.GetPokemon(string name)
        {
            throw new NotImplementedException();
        }
    }
}
