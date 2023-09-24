using Newtonsoft.Json;
using Pokedex.Application;
using Pokedex.Contracts.DTOs;
using Pokedex.Contracts.Entities;
using Pokedex.Domain;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pokedex.Client.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly HttpClient _httpClient;
        public PokemonService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<PokemonsResultObjectDTO> GetAllPokemons(PaginationParameters parameters)
        {
            return JsonConvert.DeserializeObject<PokemonsResultObjectDTO>(
                 await _httpClient.GetStringAsync($"pokemon?limit={parameters.PageSize}&offset={parameters.Offset}"));
        }

        public async Task<PokemonDTO> GetPokemon(string name)
        {
            return JsonConvert.DeserializeObject<PokemonDTO>(
                await _httpClient.GetStringAsync($"pokemon/{name}"));
        }
    }
}

