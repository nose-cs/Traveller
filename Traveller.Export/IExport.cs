namespace Traveller.Export
{
    public interface IExport
    {
        public static abstract Doc exportTable(string[] titles, float[] widthsPercent, IEnumerable<object> content);
    }

    public record Doc { 
        public string ContentType { get; set; } 
        public byte[] bytes {  get; set; } 
    }
}