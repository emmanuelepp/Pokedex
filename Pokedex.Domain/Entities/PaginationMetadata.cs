namespace Pokedex.Domain
{
    public class PaginationMetadata
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageCount { get; set; }
        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPages;
    }
}
