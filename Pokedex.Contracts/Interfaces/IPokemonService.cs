using Pokedex.Contracts.DTOs;
using Pokedex.Contracts.Entities;

namespace Pokedex.Contracts.Interfaces
{
    public interface IPokemonService
    {
        Task<PokemonsResultObjectDTO> GetAllPokemons(PaginationParameters parameters);
        Task<PokemonDTO> GetPokemon(string name);
    }
}
