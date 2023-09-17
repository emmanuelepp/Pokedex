using Microsoft.AspNetCore.Mvc;
using Pokedex.Models;
using Pokedex.Services;

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

        [HttpGet("get-pokemon")]
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

        [HttpGet("get-pokemons")]
        public async Task<IEnumerable<Pokemon>> GetPokemonList()
        {
            var result = await _client.GetAllPokemons();

            return result;
        }
    }
}
