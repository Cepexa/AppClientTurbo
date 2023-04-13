
using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExcel
{
    class TestExcel
    {
        string fullPath;
        ExcelPackage package;
        List<ExcelWorksheet> sheets;
        public TestExcel(string fullPath)
        {
            this.fullPath = fullPath;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;//LicenseContext.Commercial;
            package = new ExcelPackage(new FileInfo("newdoc.xlsx"));
            sheets = new List<ExcelWorksheet>();
        }
        public void AddSheet(string sheetName)
        {
            //package.Workbook.Worksheets.
            sheets.Add(package.Workbook.Worksheets.Add(sheetName));
        }
        public void AddValueCell(int sheetsNumber,  int aRow, int aCol, string aValue)
        {
            sheets[sheetsNumber].Cells[aRow, aCol].Value = aValue;
        }
        public void SaveExcel()
        {
            File.WriteAllBytes(fullPath, package.GetAsByteArray());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region Test1
            // //Создание нового файла .xlsx:
            // string file = "D:\\куча документов\\Нокиан\\ДОТнет\\newdoc.xlsx";
            // string fileSave = "D:\\куча документов\\Нокиан\\ДОТнет\\Save.xlsx";
            // ExcelPackage.LicenseContext = LicenseContext.NonCommercial;//LicenseContext.Commercial;
            // ExcelPackage package = new ExcelPackage(new FileInfo(file));
            // ExcelWorksheet sheet1 = package.Workbook.Worksheets[0];
            // ExcelWorksheet sheet = package.Workbook.Worksheets[1];
            // int uuu = sheet.Dimension.End.Row;
            // int uu = sheet.Dimension.End.Column;
            // sheet.Name = "Петухbbbb";// .Add("Market1 Report");
            // sheet.View.FreezePanes(2, 1);
            // int t = package.Workbook.Worksheets["Петухbbbb"].Index;
            // sheet.Cells["A1:B8"].Style.WrapText = true;
            // sheet.Columns.AutoFit();
            // DateTime d = new DateTime(2, 04, 12,12,22,11);
            // sheet.Cells[1,10].Value = "2005";
            // sheet.Cells[2, 3].Value = "1";
            // sheet.Cells["B3"].Value = "Location:";
            // sheet.Cells["C3"].Value = $"2 " + $"2, " + $"2";
            // sheet.Cells["B4"].Value = "Sector:";
            // sheet.Cells["C3"].Style.Numberformat.Format = "#,##0.00";
            // sheet.Cells["C3"].Style.Numberformat.Format = "#,##0.00";
            // sheet.Cells[1,1,5,5].Style.Numberformat.Format = DateTimeFormatInfo.CurrentInfo.FullDateTimePattern;
            // sheet.Cells[1,1,5,5].Style.Numberformat.Format = "dd.MM.yyyy HH:mm:ss";
            // sheet.Cells[1, 1, 5, 5].Style.Numberformat.Format = "@";
            // sheet.Cells[1, 1, 5, 5].Style.Numberformat.Format = "0";
            // sheet.Cells[1, 1, 5, 5].Style.Numberformat.Format = "#";
            // sheet.Names.Add("RangeName", sheet.Cells[1, 1, 5, 5]);
            // ExcelNamedRange namedRangeOld = sheet.Names["RangeName"];
            // namedRangeOld.Address = sheet.Cells[3, 3, 7, 7].Address;


            // // Создание нового именованного диапазона с новым именем и тем же адресом
            // ExcelNamedRange namedRange = sheet.Names["RangeName"]; 
            // string address =  namedRange.Address;
            // string newName = "Новое_имя_диапазона";
            // ExcelNamedRange newNamedRange = sheet.Names.Add(newName, sheet.Cells[address]);
            // //sheet.Names.Remove(namedRange.Name);
            // package.Workbook.Names.Add("Боря", package.Workbook.Worksheets[0].Cells[address]);
            // ExcelNamedRange namedRangeOld1 = package.Workbook.Names["Боря"];
            // namedRangeOld1.Address = package.Workbook.Worksheets[0].Cells[1, 1, 22, 22].Address;

            // var t2 = package.Workbook.Names.ContainsKey("wqdqwd");
            // //sheet.Names["RangeName"].Delete(eShiftTypeDelete.Left);
            // //ExcelRange namedRange = sheet.Cells[1, 1, 5, 5];
            // //namedRange.StyleName = "12";
            // //{
            // //    for (int rowIndex = namedRange.Start.Row; rowIndex <= namedRange.End.Row; rowIndex++)
            // //    {
            // //        for (int columnIndex = namedRange.Start.Column; columnIndex <= namedRange.End.Column; columnIndex++)
            // //        {
            // //            sheet.Cells[1, 1, 5, 5].Value = "no more hair pulling";
            // //        }
            // //    }
            // //}
            // sheet.Cells[1,1,5,5].Style.Numberformat.Format = "dd.MM.yyyy";
            // sheet.Cells["B3"].Value = "12-03-2055 15:22:33";
            // string temp = (string)sheet1.Cells[1, 1].Value;
            // string temp2 = sheet1.Cells[100, 5].Value?.ToString();

            // sheet1.Cells[1, 2].Value = temp;
            // AddValueCell(ref sheet, 1, 1, "Пиз\n\rда");
            // sheet.Cells[8, 2, 13, 1].LoadFromArrays(new object[][] { new[] { "Capital ization", "SharePrice", "Date", "Жопа" } });
            // var row = 9;
            // var column = 2;

            //// sheet.Cells[1, 1, row, column + 2].AutoFitColumns();
            // //sheet.Column(2).Width = 14;
            // //sheet.Column(3).Width = 12;
            // sheet.Cells["B11"].Value = "хуй";
            // //sheet.Cells[9, 4, 9 + report.History.Length, 4].Style.Numberformat.Format = "yyyy";
            // //sheet.Cells[9, 2, 9 + report.History.Length, 2].Style.Numberformat.Format = "### ### ### ##0";
            // //sheet.Column(2).Style.Numberformat = ExcelNumberFormat.
            // sheet.Column(2).Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            // sheet.Cells[8, 3, 8 + 1, 3].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            // sheet.Column(4).Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;

            // sheet.Cells[8, 2, 8, 4].Style.Font.Bold = true;
            // sheet.Cells["B2:C4"].Style.Font.Bold = true;
            // Color colFromHexBack = System.Drawing.ColorTranslator.FromHtml("#BC1205");
            // Color colFromHexFont = System.Drawing.ColorTranslator.FromHtml("#000000");
            // sheet.Cells["B2:C4"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            // sheet.Cells["B2:C4"].Style.Fill.BackgroundColor.SetColor(colFromHexBack);
            // sheet.Cells["B2:C4"].Style.Font.Color.SetColor(colFromHexFont);
            // sheet.Cells[8, 2, 8, 4].AutoFilter = true;
            // sheet.Cells[5, 2, 6, 2].Merge = true;
            // ;
            // sheet.Cells["B2:C4"].Style.Font.Strike = true;

            // sheet.Cells[8, 2, 8 + 21, 4].Style.Border.BorderAround(ExcelBorderStyle.Double);
            // sheet.Cells[8, 2, 8 + 21, 2].Style.Border.BorderAround(ExcelBorderStyle.Double);
            // sheet.Cells[8, 2, 8, 4].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;

            // var capitalizationChart = sheet.Drawings.AddChart("Findings4Chart", OfficeOpenXml.Drawing.Chart.eChartType.Line);
            // capitalizationChart.Title.Text = "Capitalization";
            // capitalizationChart.SetPosition(7, 0, 5, 0);
            // capitalizationChart.SetSize(800, 400);
            // var capitalizationData = (ExcelChartSerie)(capitalizationChart.Series.Add(sheet.Cells["B9:B28"], sheet.Cells["D9:D28"]));
            // capitalizationData.Header = "руб";

            // sheet.Protection.IsProtected = false;

            // File.WriteAllBytes(fileSave, package.GetAsByteArray());
            #endregion Test1
            #region Test2
            //TestExcel te = new TestExcel("D:\\куча документов\\Нокиан\\ДОТнет\\newdoc2.xlsx");
            //te.AddSheet("Страница 2");
            //te.AddValueCell(0, 1, 1, "Хуй");
            //te.AddValueCell(0, 2, 1, "bkefe");
            //te.AddValueCell(0, 3, 1, "fseesf");
            //te.AddValueCell(0, 4, 1, "Хуseffseй");
            //te.AddValueCell(0, 5, 1, "Хfsefsefweуй33333333333");
            //te.SaveExcel();
            #endregion Test2
            #region Test3
            string file = "C:\\Users\\SChichil\\Downloads\\ОтчетПоЯрлыкам_Шаблон.xlsx";
            string fileSave = "C:\\Users\\SChichil\\Downloads\\newdoc.xlsx";
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;//LicenseContext.Commercial;
            ExcelPackage package = new ExcelPackage(new FileInfo(file));
            ExcelWorksheet p = package.Workbook.Worksheets[1];
            //package.Workbook.Worksheets[3].Tables["d"].AddRow(); 
            var dd2 = package.Workbook.Worksheets[3].Tables.Add(package.Workbook.Worksheets[3].Cells[3, 3, 7, 7], "Вася");
            var rr = package.Workbook.Worksheets[3].Tables["Вася"].Address.Rows;
            var gdgd = package.Workbook.Worksheets[3].Tables["Table2"].Address.Address;
            package.Workbook.Worksheets[3].Tables["Table2"].AddRow(2);
            package.Workbook.Worksheets[3].Cells[4,2].Value = "Уровень";
            package.Workbook.Worksheets[3].Tables["Table2"].AddRow(2);
            //var r = p.Dimension.End;
            //ExcelWorksheet sheet1 = package.Workbook.Worksheets[0];
            //ExcelWorksheet sheet = package.Workbook.Worksheets[1];
            //int uuu = sheet.Dimension.End.Row;
            //int uu = sheet.Dimension.End.Column;
            //sheet.Name = "Петухbbbb";// .Add("Market1 Report");
            //sheet.View.FreezePanes(2, 1);
            //int t = package.Workbook.Worksheets["Петухbbbb"].Index;
            //sheet.Cells["A1:B8"].Style.WrapText = true;
            //sheet.Columns.AutoFit();
            //DateTime d = new DateTime(2, 04, 12, 12, 22, 11);
            //sheet.Cells[1, 10].Value = "2005";
            //sheet.Cells[2, 3].Value = "1";
            //sheet.Cells["B3"].Value = "Location:";
            //sheet.Cells["C3"].Value = $"2 " + $"2, " + $"2";
            //sheet.Cells["B4"].Value = "Sector:";
            //sheet.Cells["C3"].Style.Numberformat.Format = "#,##0.00";
            //sheet.Cells["C3"].Style.Numberformat.Format = "#,##0.00";
            //sheet.Cells[1, 1, 5, 5].Style.Numberformat.Format = DateTimeFormatInfo.CurrentInfo.FullDateTimePattern;
            //sheet.Cells[1, 1, 5, 5].Style.Numberformat.Format = "dd.MM.yyyy HH:mm:ss";
            //sheet.Cells[1, 1, 5, 5].Style.Numberformat.Format = "@";
            //sheet.Cells[1, 1, 5, 5].Style.Numberformat.Format = "0";
            //sheet.Cells[1, 1, 5, 5].Style.Numberformat.Format = "#";
            //sheet.Names.Add("RangeName", sheet.Cells[1, 1, 5, 5]);
            //ExcelNamedRange namedRangeOld = sheet.Names["RangeName"];
            //namedRangeOld.Address = sheet.Cells[3, 3, 7, 7].Address;

            File.WriteAllBytes(fileSave, package.GetAsByteArray());
            #endregion Test3
        }

        static void AddValueCell(ref ExcelWorksheet sheet, int aCol, int aRow, string aValue)
        {
            sheet.Cells[aCol, aRow].Value = aValue;
        }


    }

}
