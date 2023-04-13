using System;

namespace ExportTEST2
{
    class Program
    {
        static void Main(string[] args)
        {
            Excel.Excel ex = new Excel.Excel();
            ex.AddSheet("стр1");
            ex.AddValueCell(0, 1, 2, "ttt");
            string[] ss = { "ttt", "ew" , "wws" , "qqq"};
            // Create an array of IntPtrs.
            IntPtr[] image_files_array = new IntPtr[ss.Length];

            // Each IntPtr array element will point to a copy of a
            // string element in the openFileDialog.FileNames array.
            for (int i = 0; i < ss.Length; i++)
            {
                image_files_array[i] = System.Runtime.InteropServices.Marshal.StringToCoTaskMemUni(ss[i]);
            }

            //ex.AddValueRow(0, 3, 1, image_files_array, ss.Length);
            ex.SaveExcel("D:\\куча документов\\Нокиан\\ДОТнет\\жую.xlsx");

        }
    }
}
