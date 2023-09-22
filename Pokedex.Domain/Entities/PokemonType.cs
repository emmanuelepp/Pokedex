namespace Pokedex.Domain
{
    public class PokemonType
    {
        public int Slot { get; set; }

        public Type? Type { get; set; } = new Type();
    }

    public class Type
    {
        public string Name { get; set; } = string.Empty;
    }
}
