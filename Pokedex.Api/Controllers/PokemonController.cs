using Microsoft.AspNetCore.Mvc;
using Pokedex.Contracts.Entities;
using Pokedex.Contracts.Interfaces;

namespace Pokedex.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonService _client;

        public PokemonController(IPokemonService apiClient)
        {
            _client = apiClient;
        }

        [HttpGet("pokemon/{name}")]
        public async Task<IActionResult> GetPokemon(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return BadRequest("The name cannot be empty.");
            var result = await _client.GetPokemon(name);
            return result == null ? NotFound($"Pokemon with the name '{name}' not found.") : Ok(result);
        }

        [HttpGet("pokemons")]
        public async Task<IActionResult> GetPokemonList(PaginationParameters parameters)
        {
            var result = await _client.GetAllPokemons(parameters);
            return (result == null) ? NotFound("Not Pokemon found.") : Ok(result);
        }
    }
}
