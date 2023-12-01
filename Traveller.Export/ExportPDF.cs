using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace Traveller.Export
{
    public class ExportPDF : IExport
    {
        public static Doc exportTable(string[] titles, float[] widthsPercent, IEnumerable<object> content)
        {
            MemoryStream ms = new MemoryStream();

            PdfWriter writer = new PdfWriter(ms);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            Table table = new Table(widthsPercent.Select(percent => percent * 6).ToArray());

            foreach (string title in titles)
            {
                table.AddCell(new Cell(2, 1).Add(new Paragraph(title).SetBold().SetFontSize(12).SetTextAlignment(TextAlignment.CENTER)));
            }

            foreach (object element in content)
            {
                table.AddCell(new Cell().Add(new Paragraph(element.ToString()).SetTextAlignment(TextAlignment.CENTER)));
            }

            document.Add(table);
            document.Close();

            byte[] pdfBytes = ms.ToArray();

            return new Doc { ContentType = "application/pdf", bytes = pdfBytes };
        }
    }
}
