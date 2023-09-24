using Microsoft.AspNetCore.Mvc;
using Pokedex.Contracts.Interfaces;
using Pokedex.Api.Controllers;
using Pokedex.Contracts.Entities;
using Pokedex.Contracts.DTOs;
using Moq;

namespace TestPokemonApi
{
    public class PokemonApiControllerTest
    {
        private readonly PokemonController _controller;
        private readonly Mock<IPokemonService> _mockService;

        public PokemonApiControllerTest()
        {
            _mockService = new Mock<IPokemonService>();

            _controller = new PokemonController(_mockService.Object);
        }

        [Fact]
        public async Task GetPokemon_ReturnsOkResult_WhenNameIsValid()
        {
            var name = "Pikachu";

            _mockService.Setup(service => service.GetPokemon(name))
                        .ReturnsAsync(new PokemonDTO());

            var result = await _controller.GetPokemon(name);

            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.NotNull(okResult.Value);
        }

        [Fact]
        public async Task GetPokemon_ReturnsNotFound_WhenNameIsInvalid()
        {
            var name = "InvalidPokemonName";

            _mockService.Setup(service => service.GetPokemon(name))
                        .ReturnsAsync((PokemonDTO)null);

            var result = await _controller.GetPokemon(name);

            Assert.IsType<NotFoundObjectResult>(result);
        }


        [Fact]
        public async Task GetPokemonList_ReturnsOkResult_WithValidParameters()
        {
            var parameters = new PaginationParameters();

            _mockService.Setup(service => service.GetAllPokemons(parameters))
                        .ReturnsAsync(new PokemonsResultObjectDTO());

            var result = await _controller.GetPokemonList(parameters);

            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.NotNull(okResult.Value);
        }

    }
}
