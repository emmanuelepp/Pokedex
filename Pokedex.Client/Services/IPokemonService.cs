using Pokedex.Contracts.DTOs;
using Pokedex.Contracts.Entities;

namespace Pokedex.Client.Services
{
    public interface IPokemonService
    {
        Task<PokemonsResultObjectDTO> GetAllPokemons(PaginationParameters parameters);
        Task<PokemonDTO> GetPokemon(string name);
    }
}
