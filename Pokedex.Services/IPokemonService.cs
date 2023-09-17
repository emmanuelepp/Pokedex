using Pokedex.Models;

namespace Pokedex.Services
{
    public interface IPokemonService
    {
        Task<IEnumerable<Pokemon>> GetAllPokemons();
        Task<Pokemon> GetPokemon(string name);
    }
}
