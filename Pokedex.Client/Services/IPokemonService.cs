using Pokedex.Models;

namespace Pokedex.Client.Services
{
    public interface IPokemonService
    {
        Task<IEnumerable<Pokemon>> GetAllPokemons();
        Task GetPokemon(string name);
    }
}
