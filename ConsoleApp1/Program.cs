using GemBox.Spreadsheet;
using System.IO;
using System.Drawing;
class Program
{
    static void Main()
    {
        // If using the Professional version, put your serial key below.
        //SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
        SpreadsheetInfo.SetLicense("SN-2023Jun03-AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
        ExcelFile workbook = new ExcelFile();
        ExcelWorksheet worksheet = workbook.Worksheets.Add("Sheet1");
        ExcelCell cell = worksheet.Cells["A1"];

        cell.Value = "Hello World!";
        workbook.Save("C:\\Users\\SChichil\\Downloads\\HelloWorld.xlsx");
        workbook.Save("C:\\Users\\SChichil\\Downloads\\HelloWorld.pdf", new PdfSaveOptions() { SelectionType = SelectionType.EntireFile });
    }
}