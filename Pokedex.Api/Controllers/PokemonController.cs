using Microsoft.AspNetCore.Mvc;
using Pokedex.Contracts.DTOs;
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

        [HttpGet("pokemon")]
        public async Task<IActionResult> GetPokemon(string name)
        {
            if (name == null)
            {
                return BadRequest(name);
            }

            var result = await _client.GetPokemon(name);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet("pokemons")]
        public async Task<IEnumerable<PokemonDTO>> GetPokemonList()
        {
            var result = await _client.GetAllPokemons();

            return result;
        }
    }
}
