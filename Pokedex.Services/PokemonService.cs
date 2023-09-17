using Newtonsoft.Json;
using Pokedex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pokedex.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly HttpClient _httpClient;

        public PokemonService(HttpClient httpClient)
        {

            _httpClient = httpClient;

        }

        public async Task<IEnumerable<Pokemon>> GetAllPokemons()
        {
            var pokemons = JsonConvert.DeserializeObject<PokemonsResultObject>(
            await _httpClient.GetStringAsync($"pokemon?limit=24&offset=24"));

            var result = new List<Pokemon>();

            foreach (var item in pokemons.Pokemons)
            {
                result.Add(await GetPokemon(item.Name));
            }

            return result;
        }

        public async Task<Pokemon> GetPokemon(string name)
        {
            return JsonConvert.DeserializeObject<Pokemon>(
            await _httpClient.GetStringAsync($"pokemon/{name}"));
        }
    }
}
