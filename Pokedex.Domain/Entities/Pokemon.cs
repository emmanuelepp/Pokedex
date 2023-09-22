namespace Pokedex.Domain
{
    public class Pokemon
    {
        public string Name { get; set; } = string.Empty;

        public List<PokemonType> Types { get; set; } = new List<PokemonType>();

        public Sprite Sprites { get; set; } = new Sprite();
    }
}
