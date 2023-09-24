using Newtonsoft.Json;
using Pokedex.Contracts.DTOs;
using Pokedex.Contracts.Entities;
using Pokedex.Contracts.Interfaces;
using Pokedex.Domain;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Pokedex.Infrastructure.Services
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
