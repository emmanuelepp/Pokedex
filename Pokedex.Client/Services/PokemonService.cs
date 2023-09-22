using Pokedex.Application;
using Pokedex.Contracts.DTOs;
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

        public List<PokemonDTO> Pokemons { get; set; } = new List<PokemonDTO>();

        public async Task<IEnumerable<PokemonDTO>> GetAllPokemons()
        {
            var result = await _httpClient.GetFromJsonAsync<List<PokemonDTO>>("https://localhost:7266/api/Pokemon/pokemons");
            return result;
        }

        Task IPokemonService.GetPokemon(string name)
        {
            throw new NotImplementedException();
        }
    }
}
