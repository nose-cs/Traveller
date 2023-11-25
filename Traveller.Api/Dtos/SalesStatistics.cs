namespace Traveller.Dtos
{
    public enum GroupBy
    {
        Day,
        Month,
        Year
    }

    public class SalesRequest
    {
        public DateOnly Start { get; set; }
        public DateOnly End { get; set; }
        public GroupBy GroupBy { get; set; }
    }

    public class SalesResponse
    {
        public string Group { get; set; }
        public int Total { get; set; }
        public double MoneyAmount { get; set; }
    }
}
