namespace Traveller.Dtos
{
    public class PaginationResponse<TResponse>
    {
        public int TotalCollectionSize { get; set; }
        public IEnumerable<TResponse> Items { get; set; }
    }
}
