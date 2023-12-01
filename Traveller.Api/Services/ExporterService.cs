using Traveller.Dtos;
using Traveller.Export;

namespace Traveller.Services;

public enum ExportType
{
    PDF,
    EXCEL
}

public class ExporterService
{
    public DocumentDto getDoc(string filename, string[] titles, float[] widthsPercent, IEnumerable<object> content, ExportType exportTo)
    {
        Doc d = new Doc();
        
        switch(exportTo)
        {
            case ExportType.PDF:
                d = ExportPDF.exportTable(titles, widthsPercent, content);
                filename += ".pdf";
                break;
            case ExportType.EXCEL:
                d = ExportEXCEL.exportTable(titles, widthsPercent, content);
                filename += ".xlsx";
                break;
        }
        
        string base64 = Convert.ToBase64String(d.bytes);

        return new DocumentDto { ContentBase64 = base64 , ContentType = d.ContentType , Name = filename };
    }
}