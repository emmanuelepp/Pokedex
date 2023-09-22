namespace Pokedex.Domain
{
    public class PokemonsResultObject
    {
        public IEnumerable<Pokemon> Pokemons { get; set; } = new List<Pokemon>();
    }
}
