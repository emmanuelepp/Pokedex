using Pokedex.Models;

namespace Pokedex.Services
{
    public interface IApiClient
    {
        Task<IEnumerable<Pokemon>> GetAllPokemons();
        Task<Pokemon> GetPokemon(string name);
    }
}
