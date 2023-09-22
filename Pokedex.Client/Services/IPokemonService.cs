﻿using Pokedex.Contracts.DTOs;

namespace Pokedex.Client.Services
{
    public interface IPokemonService
    {
        Task<IEnumerable<PokemonDTO>> GetAllPokemons();
        Task GetPokemon(string name);
    }
}
