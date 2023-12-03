namespace Traveller.Dtos
{
    public class PaginationDto
    {
        public int? PageIndex { get; set; }
        public int? PageSize { get; set; }

        public string? OrderBy { get; set; }
        public bool? Descending { get; set; }
    }
}
