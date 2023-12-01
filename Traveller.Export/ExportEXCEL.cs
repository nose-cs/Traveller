using ClosedXML.Excel;
using System.Data;

namespace Traveller.Export
{
    public class ExportEXCEL : IExport
    {
        public static Doc exportTable(string[] titles, float[] widthsPercent, IEnumerable<object> content)
        {
            XLWorkbook workbook = new XLWorkbook();

            IXLWorksheet worksheet = workbook.Worksheets.Add("Data");

            IXLTable table = content.Count() > 0 ? worksheet.Cell(1, 1).InsertTable((IEnumerable<IEnumerable<object>>)content.Select((c, i) => new { Value = c, Index = i })
                                                                       .GroupBy(item => item.Index / titles.Length, item => item.Value))
                                                 : worksheet.Cell(1, 1).InsertTable(new List<string[]>() { new string[titles.Length] });
            int i = 0;
            foreach(var cell in table.HeadersRow().CellsUsed())
            {
                cell.Value = titles[i++];
                cell.Style.Font.SetBold(true);
                cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            }

            foreach(var cell in table.CellsUsed())
            {
                cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            }

            for (i = 0; i < widthsPercent.Length; i++)
                worksheet.Column(i + 1).Width = widthsPercent[i] * 2;

            MemoryStream ms = new MemoryStream();
            workbook.SaveAs(ms);

            byte[] exbytes = ms.ToArray();

            return new Doc { ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", bytes = exbytes };
        }
    }
}
