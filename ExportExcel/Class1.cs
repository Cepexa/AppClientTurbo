using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Excel
{
    public class Excel
    {
        
        ExcelPackage package;
        ExcelWorksheets sheets;
        public Excel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;//LicenseContext.Commercial;
            package = new ExcelPackage(new FileInfo("newdoc.xlsx"));
            sheets = package.Workbook.Worksheets;
        }
        public Excel(string FilePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;//LicenseContext.Commercial;
            package = new ExcelPackage(new FileInfo(FilePath));
            sheets = package.Workbook.Worksheets;
        }
        public void AddSheet(string sheetName)
        {
            sheets.Add(sheetName);
        }
        public int SheetsCount()
        {
            return sheets.Count;
        }
        public int GetIdxSheetByName(string aName)
        {
            return sheets[aName].Index;
        }        
        public string GetNameSheetByIdx(int aIndex)
        {
            return sheets[aIndex].Name;
        }
        public void RenameSheet(int sheetsNumber,string newName)
        {
            sheets[sheetsNumber].Name = newName;
        }
        public void DeleteSheet(int sheetsNumber)
        {
            sheets.Delete(sheetsNumber);
        }
        public void SetSheetProtect(int sheetsNumber,bool flag)
        {
            sheets[sheetsNumber].Protection.IsProtected = flag;
        }
        public void AddValueCell(int sheetsNumber, int aRow, int aCol, string aValue = null)
        {
            sheets[sheetsNumber].Cells[aRow, aCol].Value = aValue;
        }
        public void AddValueCell(int sheetsNumber, int aRow, int aCol)
        {
            sheets[sheetsNumber].Cells[aRow, aCol].Value = null;
        }
        public void SetValueCell(int sheetsNumber, int aRow, int aCol, object aValue = null)
        {
            sheets[sheetsNumber].Cells[aRow, aCol].Value = aValue;
        }        
        public void SetValueCell(int sheetsNumber, int aRow, int aCol)
        {
            sheets[sheetsNumber].Cells[aRow, aCol].Value = null;
        }        
        public object GetValueCell(int sheetsNumber, int aRow, int aCol)
        {
            return sheets[sheetsNumber].Cells[aRow, aCol].Value;
        }
        public string GetValueCellStr(int sheetsNumber, int aRow, int aCol)
        {
            return sheets[sheetsNumber].Cells[aRow, aCol].Value?.ToString();
        }
        public void AddValueRow(int sheetsNumber, int aRow, int aCol, string aValue, string separator = "•")
        {
            string[] aValues = aValue.Split(separator);
            for (int i = 0; i < aValues.Length; i++)
            {
                sheets[sheetsNumber].Cells[aRow, aCol + i].Value = aValues[i];
            }
        }
        public void AddValueRow(int sheetsNumber, int aRow, int aCol, string aValue)
        {
            string separator = "•";
            string[] aValues = aValue.Split(separator);
            for (int i = 0; i < aValues.Length; i++)
            {
                sheets[sheetsNumber].Cells[aRow, aCol + i].Value = aValues[i];
            }
        }
        public int RowsCount(int sheetsNumber)
        {
            return sheets[sheetsNumber].Dimension.End.Row;
        }        
        public void AddValueCol(int sheetsNumber, int aRow, int aCol, string aValue, string separator = "•")
        {
            string[] aValues = aValue.Split(separator);
            for (int i = 0; i < aValues.Length; i++)
            {
                sheets[sheetsNumber].Cells[aRow + i, aCol].Value = aValues[i];
            }
        }
        public void AddValueCol(int sheetsNumber, int aRow, int aCol, string aValue)
        {
            string separator = "•";
            string[] aValues = aValue.Split(separator);
            for (int i = 0; i < aValues.Length; i++)
            {
                sheets[sheetsNumber].Cells[aRow + i, aCol].Value = aValues[i];
            }
        }
        public int ColsCount(int sheetsNumber)
        {
            return sheets[sheetsNumber].Dimension.End.Column;
        }
        public void SetWidthColumn(int sheetsNumber, int aCol, int aWidth)
        {
            sheets[sheetsNumber].Column(aCol).Width = aWidth;
        }
        public void FreezePanes(int sheetsNumber, int aRow, int aCol)
        {
            sheets[sheetsNumber].View.FreezePanes(aRow, aCol);
        }        
        public void SetWrapText(int sheetsNumber, int fromRow, int fromCol, int toRow, int toCol, bool flag)
        {
            sheets[sheetsNumber].Cells[fromRow, fromCol, toRow, toCol].Style.WrapText = flag;
        }
        public void SetMergeCells(int sheetsNumber, int fromRow, int fromCol, int toRow, int toCol, bool flag)
        {
            sheets[sheetsNumber].Cells[fromRow, fromCol, toRow, toCol].Merge = flag;
        }
        public void SetColorCells(int sheetsNumber, int fromRow, int fromCol, int toRow, int toCol,
                                  string colorHexBack = "#BC1205", string colorHexFont = "#000000")
        {
            Color colFromHexBack = System.Drawing.ColorTranslator.FromHtml(colorHexBack);
            Color colFromHexFont = System.Drawing.ColorTranslator.FromHtml(colorHexFont);
            sheets[sheetsNumber].Cells[fromRow, fromCol, toRow, toCol].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheets[sheetsNumber].Cells[fromRow, fromCol, toRow, toCol].Style.Fill.BackgroundColor.SetColor(colFromHexBack);
            sheets[sheetsNumber].Cells[fromRow, fromCol, toRow, toCol].Style.Font.Color.SetColor(colFromHexFont);
        }
        public void SetFilterCells(int sheetsNumber, int fromRow, int fromCol, int toRow, int toCol, bool flag)
        {
            sheets[sheetsNumber].Cells[fromRow, fromCol, toRow, toCol].AutoFilter = flag;
        }
        public void SetStyleCells(int sheetsNumber, int fromRow, int fromCol, int toRow, int toCol ,string style)
        {
            if (style.Equals("Bold"))
            {
                sheets[sheetsNumber].Cells[fromRow, fromCol, toRow, toCol].Style.Font.Bold = true;
            }
            else if (style.Equals("Italic"))
            {
                sheets[sheetsNumber].Cells[fromRow, fromCol, toRow, toCol].Style.Font.Italic = true;
            }
            else if (style.Equals("Strike"))
            {
                sheets[sheetsNumber].Cells[fromRow, fromCol, toRow, toCol].Style.Font.Strike = true;
            }
            else if (style.Equals("UnderLine"))
            {
                sheets[sheetsNumber].Cells[fromRow, fromCol, toRow, toCol].Style.Font.UnderLine = true;
            }
            else if (style.Equals("Default"))
            {
                sheets[sheetsNumber].Cells[fromRow, fromCol, toRow, toCol].Style.Font.Bold      = false;
                sheets[sheetsNumber].Cells[fromRow, fromCol, toRow, toCol].Style.Font.Italic    = false;
                sheets[sheetsNumber].Cells[fromRow, fromCol, toRow, toCol].Style.Font.Strike    = false;
                sheets[sheetsNumber].Cells[fromRow, fromCol, toRow, toCol].Style.Font.UnderLine = false;
            }
        }
        public void SetAlignmentCells(int sheetsNumber, int fromRow, int fromCol, int toRow, int toCol, string style)
        {
            sheets[sheetsNumber].Cells[fromRow, fromCol, toRow, toCol].Style.HorizontalAlignment =
              style.Equals("Left") ? ExcelHorizontalAlignment.Left :
              style.Equals("Center") ? ExcelHorizontalAlignment.Center :
              style.Equals("Right") ? ExcelHorizontalAlignment.Right :
                                       ExcelHorizontalAlignment.General;
        }
        public void SetFormatCell(int sheetsNumber, int fromRow, int fromCol, int toRow, int toCol, string format = null)
        {
            sheets[sheetsNumber].Cells[fromRow, fromCol,  toRow, toCol].Style.Numberformat.Format = format;
        }
        public void SetFormatCell(int sheetsNumber, int fromRow, int fromCol, int toRow, int toCol)
        {
            sheets[sheetsNumber].Cells[fromRow, fromCol,  toRow, toCol].Style.Numberformat.Format = null;
        }
        public void SetBorderStyle(int sheetsNumber, int fromRow, int fromCol, int toRow, int toCol, int aStyle)
        {
            sheets[sheetsNumber].Cells[fromRow, fromCol, toRow, toCol].Style.Border.BorderAround((ExcelBorderStyle)aStyle);//0-12
        }        
        public void SetBorderStyle(int sheetsNumber, string aRange, int aStyle)
        {
            sheets[sheetsNumber].Cells[aRange].Style.Border.BorderAround((ExcelBorderStyle)aStyle);//0-12
        }
        public void CreateNamedRange(int sheetsNumber, int fromRow, int fromCol, int toRow, int toCol, string aName)
        {
            package.Workbook.Names.Add(aName, sheets[sheetsNumber].Cells[fromRow, fromCol, toRow, toCol]);
        }
        public void CreateNamedRangeLocal(int sheetsNumber, int fromRow, int fromCol, int toRow, int toCol, string aName)
        {
            sheets[sheetsNumber].Names.Add(aName, sheets[sheetsNumber].Cells[fromRow, fromCol, toRow, toCol]);
        }
        public void CreateNamedRange(int sheetsNumber, string aRange, string aName)
        {
            package.Workbook.Names.Add(aName, sheets[sheetsNumber].Cells[aRange]);
        }
        public void CreateNamedRangeLocal(int sheetsNumber, string aRange, string aName)
        {
            sheets[sheetsNumber].Names.Add(aName, sheets[sheetsNumber].Cells[aRange]);
        }
        public void DeleteNamedRange(string aName)
        {
            package.Workbook.Names.Remove(aName);
        }
        public void DeleteNamedRangeLocal(int sheetsNumber, string aName)
        {
            sheets[sheetsNumber].Names.Remove(aName);
        }
        public void RenameNamedRange(string oldName, string newName )
        {
            ExcelNamedRange namedRange = package.Workbook.Names[oldName];
            package.Workbook.Names.Add(newName, namedRange.Worksheet.Cells[namedRange.Address]);
            package.Workbook.Names.Remove(namedRange.Name);
        }
        public void RenameNamedRangeLocal(int sheetsNumber, string oldName, string newName )
        {
            ExcelNamedRange namedRange = sheets[sheetsNumber].Names[oldName];
            sheets[sheetsNumber].Names.Add(newName, sheets[sheetsNumber].Cells[namedRange.Address]);
            sheets[sheetsNumber].Names.Remove(namedRange.Name);
        }
        public void ResizeNamedRange(int sheetsNumber, int fromRow, int fromCol, int toRow, int toCol, string aName)
        {
            ExcelNamedRange namedRangeOld = package.Workbook.Names[aName];
            namedRangeOld.Address = sheets[sheetsNumber].Cells[fromRow, fromCol, toRow, toCol].Address;
        }        
        public void ResizeNamedRangeLocal(int sheetsNumber, int fromRow, int fromCol, int toRow, int toCol, string aName)
        {
            ExcelNamedRange namedRangeOld = sheets[sheetsNumber].Names[aName];
            namedRangeOld.Address = sheets[sheetsNumber].Cells[fromRow, fromCol, toRow, toCol].Address;
        }        
        public void SetAddressNamedRange(int sheetsNumber, string newAddress, string aName)
        {
            ExcelNamedRange namedRangeOld = package.Workbook.Names[aName];
            namedRangeOld.Address = sheets[sheetsNumber].Cells[newAddress].Address;
        }
        public void SetAddressNamedRangeLocal(int sheetsNumber, string newAddress, string aName)
        {
            ExcelNamedRange namedRangeOld = sheets[sheetsNumber].Names[aName];
            namedRangeOld.Address = sheets[sheetsNumber].Cells[newAddress].Address;
        }
        public int GetIdxSheetByNamedRange(string aName) 
        {
            return package.Workbook.Names[aName].Worksheet.Index;
        }
        public string GetAddressNamedRange(string aName) 
        {
            return package.Workbook.Names[aName].Address;
        }
        public string GetAddressNamedRangeLocal(int sheetsNumber, string aName) 
        {
            return sheets[sheetsNumber].Names[aName].Address;
        }
        public bool CheckNamedRange(string aName)
        {
            return package.Workbook.Names.ContainsKey(aName);
        }
        public bool CheckNamedRangeLocal(int sheetsNumber, string aName)
        {
            return sheets[sheetsNumber].Names.ContainsKey(aName);
        }
        public void AddTable(int sheetsNumber, int fromRow, int fromCol, int toRow, int toCol, string aName)
        {
            sheets[sheetsNumber].Tables.Add(package.Workbook.Worksheets[sheetsNumber].Cells[fromRow, fromCol, toRow, toCol], aName);
        }
        public void AddTable(int sheetsNumber, string aRange, string aName)
        {
            sheets[sheetsNumber].Tables.Add(package.Workbook.Worksheets[sheetsNumber].Cells[aRange], aName);
        }
        public int FindTableSheet(string aName)
        {
            foreach (var sheet in sheets)
            {
                var tables = sheet.Tables;
                foreach (var table in tables)
                {
                    if (table.Name == aName)
                    {
                        return sheet.Index;
                    }
                }
            }
            return -1;
        }
        public void DeleteTable(int sheetsNumber, string aName)
        {
            sheets[sheetsNumber].Tables.Delete(aName);
        }
        public void DeleteTable(int sheetsNumber, string aName, bool clearRange = false)
        {
            sheets[sheetsNumber].Tables.Delete(aName, clearRange);
        }
        public void RenameTable(int sheetsNumber, string oldName, string newName)
        {
            sheets[sheetsNumber].Tables[oldName].Name = newName;
        }
        public int RowCountTable(int sheetsNumber, string aName)
        {
            return sheets[sheetsNumber].Tables[aName].Address.Rows;
        }
        public int ColCountTable(int sheetsNumber, string aName)
        {
            return sheets[sheetsNumber].Tables[aName].Address.Columns;
        }
        public string GetAddressTable(int sheetsNumber, string aName)
        {
            return sheets[sheetsNumber].Tables[aName].Address.Address;
        }
        public int GetStartRowTable(int sheetsNumber, string aName)
        {
            return sheets[sheetsNumber].Tables[aName].Address.Start.Row;
        }
        public int GetStartColTable(int sheetsNumber, string aName)
        {
            return sheets[sheetsNumber].Tables[aName].Address.Start.Column;
        }
        public int GetEndRowTable(int sheetsNumber, string aName)
        {
            return sheets[sheetsNumber].Tables[aName].Address.End.Row;
        }
        public int GetEndColTable(int sheetsNumber, string aName)
        {
            return sheets[sheetsNumber].Tables[aName].Address.End.Column;
        }
        public void AddRowTable(int sheetsNumber, string aName)
        {
            sheets[sheetsNumber].Tables[aName].AddRow();
        }
        public void AddRowTable(int sheetsNumber, string aName, int rows = 1)
        {
            sheets[sheetsNumber].Tables[aName].AddRow(rows);
        }
        public void InsertRowTable(int sheetsNumber, string aName, int position)
        {
            sheets[sheetsNumber].Tables[aName].InsertRow(position);
        }
        public void InsertRowTable(int sheetsNumber, string aName, int position, int rows = 1)
        {
            sheets[sheetsNumber].Tables[aName].InsertRow(position, rows);
        }
        public void DeleteRowTable(int sheetsNumber, string aName, int position)
        {
            sheets[sheetsNumber].Tables[aName].DeleteRow(position);
        }
        public void DeleteRowTable(int sheetsNumber, string aName, int position, int rows = 1)
        {
            sheets[sheetsNumber].Tables[aName].DeleteRow(position, rows);
        }
        public void AddColTable(int sheetsNumber, string aName)
        {
            sheets[sheetsNumber].Tables[aName].Columns.Add();
        }
        public void AddColTable(int sheetsNumber, string aName, int cols = 1)
        {
            sheets[sheetsNumber].Tables[aName].Columns.Add(cols);
        }
        public void InsertColTable(int sheetsNumber, string aName, int position)
        {
            sheets[sheetsNumber].Tables[aName].Columns.Insert(position);
        }
        public void InsertColTable(int sheetsNumber, string aName, int position, int cols = 1)
        {
            sheets[sheetsNumber].Tables[aName].Columns.Insert(position, cols);
        }
        public void DeleteColTable(int sheetsNumber, string aName, int position)
        {
            sheets[sheetsNumber].Tables[aName].Columns.Delete(position);
        }
        public void DeleteColTable(int sheetsNumber, string aName, int position, int cols = 1)
        {
            sheets[sheetsNumber].Tables[aName].Columns.Delete(position, cols);
        }
        public void SaveExcel(string fullPath)
        {
            try
            {
                File.WriteAllBytes(fullPath, package.GetAsByteArray());
            }
            finally
            {
                package.Dispose();
            }
        }

    }
}
