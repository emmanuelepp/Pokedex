using Pokedex.Contracts.DTOs;

namespace Pokedex.Contracts.Interfaces
{
    public interface IPokemonService
    {
        Task<IEnumerable<PokemonDTO>> GetAllPokemons();
        Task<PokemonDTO> GetPokemon(string name);
    }
}
