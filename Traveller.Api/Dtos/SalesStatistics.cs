namespace Traveller.Dtos
{
    public static class Month
    {
        public static string getMonth(int number)
        {
            switch (number) 
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
            }

            throw new ArgumentException("Month index don´t exist, valid range 1 - 12");
        }
    }
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
        public GroupBy? GroupBy { get; set; }
    }

    public class SalesResponse
    {
        public string Group { get; set; }
        public string? Description { get; set; }
        public int Total { get; set; }
        public double MoneyAmount { get; set; }
    }
}
