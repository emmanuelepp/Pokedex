using Newtonsoft.Json;
using Pokedex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Services
{
    public class ApiClient : IApiClient
    {
        private readonly HttpClient _httpClient;

        public ApiClient(HttpClient httpClient)
        {

            _httpClient = httpClient;

        }

        public Task<IEnumerable<Pokemon>> GetAllPokemons()
        {
            throw new NotImplementedException();
        }

        public async Task<Pokemon> GetPokemon(string name)
        {
            try
            {
                return JsonConvert.DeserializeObject<Pokemon>(name);
                await _httpClient.GetStringAsync($"pokemon/{name}");

            }
            catch (ArgumentException ex)
            {
                return null;
            }
        }
    }
}
