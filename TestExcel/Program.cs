#define test18

#if test18

using OfficeOpenXml;
using OfficeOpenXml.VBA;
using System;
using System.Collections.Generic;
using System.IO;
using GemBox.Spreadsheet;
using System.Linq;
using System.Drawing.Printing;

class Program
{
    static void Main()
    {
        var aPath = "C:\\Users\\SChichil\\Downloads\\kk.xlsx";
        var aPathTest = "C:\\Users\\SChichil\\Downloads\\УПД_с_штукамиТест.xlsx";
        SpreadsheetInfo.SetLicense("SN-2023Jun03-AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
        ExcelFile excelFile = ExcelFile.Load(aPath);
        var sheet = excelFile.Worksheets[0];
        //var d = excelFile.DefinedNames.Count;
        //var sheet = excelFile.Worksheets["TDSheet"];
        //sheet.Cells[sheet.NamedRanges["field_ПредставлениеПоставщика"]. Range.StartPosition].Value = "Тест";
        // Получите ссылку на именованный диапазон и скопируйте его в буфер обмена.
        //var namedRange = sheet.NamedRanges["DefaultRow"];
        // Перейдите к новой строке под именованным диапазоном.
        //sheet.Rows.InsertCopy(namedRange.Range.FirstRowIndex+1,166, sheet.Rows[namedRange.Range.FirstRowIndex] );


        // Получить диапазон для копирования
        //var range = sheet.Cells.GetSubrangeAbsolute(namedRange.Range.FirstRowIndex-3, 0, namedRange.Range.FirstRowIndex-1, sheet.Columns.Count);
        //sheet.Rows.InsertEmpty(29, 3);
        //range.CopyTo(29, 0);
        //sheet.Rows[29].SetHeight(sheet.Rows[namedRange.Range.FirstRowIndex - 3].Height, LengthUnit.Twip);
        //sheet.Rows[30].SetHeight(sheet.Rows[namedRange.Range.FirstRowIndex - 2].Height, LengthUnit.Twip);
        //sheet.HeadersFooters.DefaultPage.Header.RightSection.Append("Лист &P");
        //sheet.HeadersFooters.FirstPage.Header.RightSection.Content = "";

        // Добавление данных в ячейки
        sheet.Cells["A1"].Value = "Имя";
        sheet.Cells["B1"].Value = "Возраст";
        sheet.Cells["A2"].Value = "Иван";
        sheet.Cells["B2"].Value = 30;

        // Проверка существования другого именованного диапазона
        if (sheet.NamedRanges["MyOtherRange"] == null)
        {
            // Создание другого именованного диапазона, если он не существует
            sheet.NamedRanges.Add("MyOtherRange", sheet.Cells.GetSubrange("A1:B2"));
        }

        // Сохранение файла в формате XLSX
        excelFile.Save(aPathTest);

        Console.WriteLine("Файл output.xlsx создан успешно!");


    }
}


#endif

#if test17

using OfficeOpenXml;
using OfficeOpenXml.VBA;
using System;
using System.Collections.Generic;
using System.IO;
using GemBox.Spreadsheet;
using System.Linq;

class Program
{
    static void Main()
    {
        var aPath = "C:\\Users\\SChichil\\Downloads\\УПД_с_штуками.xlsm";
        var aPathNew = "C:\\Users\\SChichil\\Downloads\\УПД_с_штуками2.xlsx";
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;//LicenseContext.Commercial;
        using (var package = new ExcelPackage(new FileInfo(aPath)))
        {
            // Создание нового файла XLSM без макросов
            using (var newPackage = new ExcelPackage(aPathNew))
            {

                // Копирование данных из старого файла в новый
                foreach (var worksheet in package.Workbook.Worksheets)
                {
                    // Создание нового листа в целевой рабочей книге
                    var newWorksheet = newPackage.Workbook.Worksheets[worksheet.Name];
                    if (newWorksheet == null)
                    newWorksheet = newPackage.Workbook.Worksheets.Add(worksheet.Name);
                    //// Копирование колонтитулов
                    newWorksheet.HeaderFooter.FirstFooter.CenteredText = worksheet.HeaderFooter.FirstFooter.CenteredText;
                    newWorksheet.HeaderFooter.FirstFooter.LeftAlignedText = worksheet.HeaderFooter.FirstFooter.LeftAlignedText;
                    newWorksheet.HeaderFooter.FirstFooter.RightAlignedText = worksheet.HeaderFooter.FirstFooter.RightAlignedText;
                    newWorksheet.HeaderFooter.FirstHeader.CenteredText = worksheet.HeaderFooter.FirstHeader.CenteredText;
                    newWorksheet.HeaderFooter.FirstHeader.LeftAlignedText = worksheet.HeaderFooter.FirstHeader.LeftAlignedText;
                    newWorksheet.HeaderFooter.FirstHeader.RightAlignedText = worksheet.HeaderFooter.FirstHeader.RightAlignedText;
                    newWorksheet.HeaderFooter.OddHeader.CenteredText = worksheet.HeaderFooter.OddHeader.CenteredText;
                    newWorksheet.HeaderFooter.OddHeader.LeftAlignedText = worksheet.HeaderFooter.OddHeader.LeftAlignedText;
                    newWorksheet.HeaderFooter.OddHeader.RightAlignedText = worksheet.HeaderFooter.OddHeader.RightAlignedText;
                    newWorksheet.HeaderFooter.OddFooter.CenteredText = worksheet.HeaderFooter.OddFooter.CenteredText;
                    newWorksheet.HeaderFooter.OddFooter.LeftAlignedText = worksheet.HeaderFooter.OddFooter.LeftAlignedText;
                    newWorksheet.HeaderFooter.OddFooter.RightAlignedText = worksheet.HeaderFooter.OddFooter.RightAlignedText;
                    newWorksheet.HeaderFooter.EvenHeader.CenteredText = worksheet.HeaderFooter.EvenHeader.CenteredText;
                    newWorksheet.HeaderFooter.EvenHeader.LeftAlignedText = worksheet.HeaderFooter.EvenHeader.LeftAlignedText;
                    newWorksheet.HeaderFooter.EvenHeader.RightAlignedText = worksheet.HeaderFooter.EvenHeader.RightAlignedText;
                    newWorksheet.HeaderFooter.EvenFooter.CenteredText = worksheet.HeaderFooter.EvenFooter.CenteredText;
                    newWorksheet.HeaderFooter.EvenFooter.LeftAlignedText = worksheet.HeaderFooter.EvenFooter.LeftAlignedText;
                    newWorksheet.HeaderFooter.EvenFooter.RightAlignedText = worksheet.HeaderFooter.EvenFooter.RightAlignedText;

                    // Копирование данных из исходного листа в новый лист
                    worksheet.Cells[worksheet.Rows.StartRow, worksheet.Columns.StartColumn, worksheet.Rows.EndRow, worksheet.Columns.EndColumn].Copy(newWorksheet.Cells);
                    //newWorksheet.Row(1).Height = worksheet.Row(1).Height;
                    for (int row = 1; row <= worksheet.Dimension.Rows; row++)
                    {
                        newWorksheet.Row(row).Height = worksheet.Row(row).Height;
                    }
                    // Копирование размеров столбцов
                    for (int col = 1; col <= worksheet.Dimension.Columns; col++)
                    {
                        newWorksheet.Column(col).Width = worksheet.Column(col).Width;
                    }
                    // Копирование размеров листа
                    //newWorksheet.View.ZoomScale   = worksheet.View.ZoomScale;
                    //newWorksheet.View.TopLeftCell = worksheet.View.TopLeftCell;
                    //newWorksheet.View.PageBreakView = worksheet.View.PageBreakView;
                    //newWorksheet.View.PageLayoutView = worksheet.View.PageLayoutView;
                    //newWorksheet.View.ShowGridLines = worksheet.View.ShowGridLines;
                    newWorksheet.PrinterSettings.PaperSize = worksheet.PrinterSettings.PaperSize;
                    newWorksheet.PrinterSettings.Orientation = worksheet.PrinterSettings.Orientation;
                    newWorksheet.PrinterSettings.FitToPage = worksheet.PrinterSettings.FitToPage;
                    // Копирование именованных диапазонов
                    foreach (var namedRange in package.Workbook.Names)
                    {
                        if (namedRange.Worksheet.Name == worksheet.Name)
                        {
                            newPackage.Workbook.Names.Add(namedRange.Name, newPackage.Workbook.Worksheets[worksheet.Name].Cells[namedRange.Address]);
                        }
                    }

                }

                // Сохранение нового файла без макросов в формате XLSX
                newPackage.Save();
            }
        }
        SpreadsheetInfo.SetLicense("SN-2023Jun03-AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
        ExcelFile excelFile = ExcelFile.Load(aPathNew);
        excelFile.Worksheets[0].Cells["A1"].Value = "Тест";
        excelFile.Save(aPathNew);
    }
}


#endif

#if test16
using GemBox.Spreadsheet;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Указываем путь к файлу Excel
        SpreadsheetInfo.SetLicense("SN-2023Jun03-AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
        //var aPath = "C:\\Users\\SChichil\\Desktop\\УПД-№84.xlsm";
        var aPath = "C:\\Users\\SChichil\\Desktop\\Реестр_авиа_01.02-15.02.23_.xlsx";
        Stream stream = File.Open(aPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        
            if (aPath != null)
        {
            try
            {
                ExcelFile excelFile = ExcelFile.Load(aPath);
                ExcelWorksheet worksheetd = excelFile.Worksheets[0];

                // Устанавливаем текст в верхний колонтитул
                worksheetd.HeadersFooters.DefaultPage.Header.CenterSection.Content = "Верхушка айсберга";

                // Устанавливаем текст в нижний колонтитул
                worksheetd.HeadersFooters.DefaultPage.Footer.CenterSection.Content = "Низина";
                excelFile.Save ( "C:\\Users\\SChichil\\Desktop\\Sample1.xlsx");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при открытии файла: " + ex.Message);
            }

            // продолжайте работу с объектом
        }
        else
        {
            Console.WriteLine("dd");
        }

        var workbook = ExcelFile.Load("C:\\Users\\SChichil\\Desktop\\Sample1.xlsx");

        var worksheet = workbook.Worksheets[0];

        int columnCount = worksheet.CalculateMaxUsedColumns(); // Получение количества столбцов

        Console.WriteLine("Количество столбцов на странице: {0}", columnCount);
    }
}

#endif

#if test15 //S3.MINIO Рабочий

using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        string accessKey = "uwQsos03bO3HsNpQkrP9";
        string secretKey = "6vTri2vczKN39vLCFEDXm0JzUxGDIscvmCB4lKVl";
        string bucketName = "test";
        string key = "Hello5.txt";
        string serverUrl = "http://172.23.46.22:9000"; // Укажите правильный URL вашего локального сервера Minio

        var config = new Amazon.S3.AmazonS3Config
        {
            ServiceURL = serverUrl,
            ForcePathStyle = true
        };

        using (var client = new Amazon.S3.AmazonS3Client(accessKey, secretKey, config))
        {
            Amazon.S3.Model.GetObjectRequest request = new Amazon.S3.Model.GetObjectRequest
            {
                BucketName = bucketName,
                Key = key
            };

            using (Amazon.S3.Model.GetObjectResponse response = client.GetObject(request))
            {
                using (Stream responseStream = response.ResponseStream)
                {
                    using (StreamReader reader = new StreamReader(responseStream))
                    {
                        string data = reader.ReadToEnd();
                        Console.WriteLine("File content:" + data);
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
#endif

#if test14
using System;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        string accessKey = "uwQsos03bO3HsNpQkrP9";
        string secretKey = "6vTri2vczKN39vLCFEDXm0JzUxGDIscvmCB4lKVl";

        string region = "us-east-1";
        string service = "s3";
        string host = "http://172.23.46.103:9000";
        string url = "http://172.23.46.103:9000/test/Hello5.txt"; // Укажите путь к файлу

        string date = DateTime.UtcNow.AddHours(-3).ToString("yyyyMMddTHHmmssZ");
        string dateStamp = DateTime.UtcNow.AddHours(-3).ToString("yyyyMMdd");

        string canonicalRequest = "GET\n/test/Hello5.txt\nhost:" + host + "\n" + CalculateHash("");
        string stringToSign = "AWS4-HMAC-SHA256\n" + dateStamp + "/" + region + "/" + service + "/aws4_request\n" + CalculateHash(secretKey);

        byte[] signingKey = GetSignatureKey(secretKey, dateStamp, region, service);
        byte[] signature = HmacSHA256(signingKey, Encoding.UTF8.GetBytes(stringToSign));
        string signatureHex = BitConverter.ToString(signature).Replace("-", "").ToLower();

        Console.WriteLine("Signature: " + signatureHex);
        string authorizationHeader = $"AWS4-HMAC-SHA256 Credential={accessKey}/{dateStamp}/{region}/{service}/aws4_request, SignedHeaders=host, Signature={signatureHex}";

        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("x-amz-date", date);
            client.DefaultRequestHeaders.Add("Authorization", authorizationHeader);

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("Error: " + response.StatusCode);
            }
        }

    }

    private static byte[] HmacSHA256(byte[] key, byte[] data)
    {
        using (var hmac = new HMACSHA256(key))
        {
            return hmac.ComputeHash(data);
        }
    }

    private static byte[] GetSignatureKey(string key, string dateStamp, string regionName, string serviceName)
    {
        byte[] kSecret = Encoding.UTF8.GetBytes("AWS4" + key);
        byte[] kDate = HmacSHA256(kSecret, Encoding.UTF8.GetBytes(dateStamp));
        byte[] kRegion = HmacSHA256(kDate, Encoding.UTF8.GetBytes(regionName));
        byte[] kService = HmacSHA256(kRegion, Encoding.UTF8.GetBytes(serviceName));
        byte[] kSigning = HmacSHA256(kService, Encoding.UTF8.GetBytes("aws4_request"));
        return kSigning;
    }

    private static string CalculateHash(string text)
    {
        using (SHA256 sha256 = SHA256Managed.Create())
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            byte[] hash = sha256.ComputeHash(bytes);
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }
    }
}

#endif

#if test13
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        string accessKey = "uwQsos03bO3HsNpQkrP9";
        string secretKey = "6vTri2vczKN39vLCFEDXm0JzUxGDIscvmCB4lKVl";

        string region = "us-east-1"; // Укажите корректный регион AWS
        string service = "s3"; // Укажите соответствующий сервис AWS
        string endpoint = "http://172.23.46.103:9000"; // Укажите конечную точку AWS

        string url = "http://172.23.46.103:9000/test/Hello5.txt"; // Укажите путь к файлу

        string dateTime = DateTime.UtcNow.ToString("yyyyMMddTHHmmssZ");
        string date = dateTime.Substring(0, 8);
        string canonicalRequest = "GET\n/test/Hello5.txt\n\nhost:" + "172.23.46.103:9000" + "\n\nhost\n" + CalculateHash("");
        string stringToSign = "AWS4-HMAC-SHA256\n" + date + "/" + region + "/" + service + "/aws4_request\n" + CalculateHash(canonicalRequest);
        string signingKey = GetSignatureKey(secretKey, date, region, service);

        byte[] signature = HmacSHA256(Encoding.UTF8.GetBytes(signingKey), Encoding.UTF8.GetBytes(stringToSign));
        string signatureHex = ToHexString(signature);

        string authorizationHeader = $"AWS4-HMAC-SHA256 Credential={accessKey}/{date}/{region}/{service}/aws4_request, SignedHeaders=host, Signature={signatureHex}";

        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("x-amz-date", dateTime);
            client.DefaultRequestHeaders.Add("Authorization", authorizationHeader);

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("Error: " + response.StatusCode);
            }
        }
    }

    private static byte[] HmacSHA256(byte[] key, byte[] data)
    {
        using (var hmac = new HMACSHA256(key))
        {
            return hmac.ComputeHash(data);
        }
    }

    private static string GetSignatureKey(string key, string dateStamp, string regionName, string serviceName)
    {
        byte[] kDate = HmacSHA256(Encoding.UTF8.GetBytes("AWS4" + key), Encoding.UTF8.GetBytes(dateStamp));
        byte[] kRegion = HmacSHA256(kDate, Encoding.UTF8.GetBytes(regionName));
        byte[] kService = HmacSHA256(kRegion, Encoding.UTF8.GetBytes(serviceName));
        byte[] kSigning = HmacSHA256(kService, Encoding.UTF8.GetBytes("aws4_request"));
        return ToHexString(kSigning);
    }

    private static string CalculateHash(string text)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(text);
        using (SHA256 sha256 = SHA256Managed.Create())
        {
            byte[] hashedBytes = sha256.ComputeHash(bytes);
            return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
        }
    }

    private static string ToHexString(byte[] bytes)
    {
        StringBuilder hex = new StringBuilder(bytes.Length * 2);
        foreach (byte b in bytes)
        {
            hex.AppendFormat("{0:x2}", b);
        }
        return hex.ToString();
    }
}


#endif

#if test12

using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using System;
using System.IO;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        string accessKey = "uwQsos03bO3HsNpQkrP9";
        string secretKey = "6vTri2vczKN39vLCFEDXm0JzUxGDIscvmCB4lKVl";
        string bucketName = "test";
        string localMinioEndpoint = "http://172.23.46.103:9000";

        // Создаем credentials объект с вашими ключами доступа
        var credentials = new BasicAWSCredentials(accessKey, secretKey);

        // Создаем клиент AmazonS3 с использованием ваших ключей и локальным URL сервера Minio
        var config = new AmazonS3Config
        {
            ServiceURL = localMinioEndpoint,
            SignatureVersion = "2" // Укажите версию сигнатуры, если требуется
        };
        var s3Client = new AmazonS3Client(credentials, config);

        // Выполняем запрос для получения списка объектов (файлов) в бакете
        GetObjectRequest request = new GetObjectRequest
        {
            Key = "HelloWorld",
            BucketName = bucketName
        };

        GetObjectResponse response = s3Client.GetObject(request);

    //    foreach (S3Object entry in response)
    //    {
    //        GetObjectRequest getObjectRequest = new GetObjectRequest
    //        {
    //            BucketName = bucketName,
    //            Key = entry.Key
    //        };

    //        GetObjectResponse getObjectResponse = await s3Client.GetObjectAsync(getObjectRequest);

    //        using (var responseStream = getObjectResponse.ResponseStream)
    //        {
    //            using (var reader = new StreamReader(responseStream))
    //            {
    //                string data = reader.ReadToEnd();
    //                Console.WriteLine($"File: {entry.Key}");
    //                Console.WriteLine($"Content: {data}");
    //            }
    //        }
    //    }
    }
}

#endif

#if test11
using System;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        string url = "http://172.23.46.103:9000/test/Hello5.txt";
        string accessKey = "uwQsos03bO3HsNpQkrP9";
        string secretKey = "AWS4" + "6vTri2vczKN39vLCFEDXm0JzUxGDIscvmCB4lKVl";

        string serviceName = "s3";
        string region = "e.g. us-east-1";
        string date     = DateTime.UtcNow.ToString("yyyyMMddTHHmmssZ");
        string dateOnly = DateTime.UtcNow.ToString("yyyyMMdd");
        string contType = "aws4_request";
        string stringToSign = $"\n{dateOnly}\n{region}\n{serviceName}\n/{contType}";

        byte[] secretKeyBytes = Encoding.UTF8.GetBytes(secretKey);
        byte[] stringToSignBytes = Encoding.UTF8.GetBytes(stringToSign);
        using (var hmac = new HMACSHA256(secretKeyBytes))
        {
            byte[] hashValue = hmac.ComputeHash(stringToSignBytes);
            string signature = BitConverter.ToString(hashValue).Replace("-", "").ToLower();

            string authorizationHeader = $"AWS4-HMAC-SHA256 Credential={accessKey}/{dateOnly}/{region}/{serviceName}/{contType}, SignedHeaders=host, Signature={signature}";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", authorizationHeader);
                client.DefaultRequestHeaders.Add("x-amz-date", date);

                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(data);
                }
                else
                {
                    Console.WriteLine("Error: " + response.StatusCode);
                }
            }
        }
    }
}




#endif

#if test10

using IronBarCode;
using System;

class Program
{
    static void Main()
    {
        // Строка для создания QR кода
        string text = "Hello, World!";

        // Создание QR кода
        var barcode = BarcodeWriter.CreateBarcode(text, BarcodeWriterEncoding.QRCode);

        // Сохранение QR кода в файл
        barcode.SaveAsJpeg("D:\\barcode.jpg");

        Console.WriteLine("QR code saved to: barcode.jpg");
    }
}

#endif

#if test1
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using GemBox.Spreadsheet;
//using PdfSharp;
//using ClosedXML.Excel;
//using ExcelWorksheet = GemBox.Spreadsheet.ExcelWorksheet;

namespace TestExcel
{
    class TestExcel
    {
        //string fullPath;
        //ExcelPackage package;
        //List<ExcelWorksheet> sheets;
        //public TestExcel(string fullPath)
        //{
        //    this.fullPath = fullPath;
        //    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;//LicenseContext.Commercial;
        //    package = new ExcelPackage(new FileInfo("newdoc.xlsx"));
        //    sheets = new List<ExcelWorksheet>();
        //}
        //public void AddSheet(string sheetName)
        //{
        //    //package.Workbook.Worksheets.
        //    //sheets.Add(package.Workbook.Worksheets.Add(sheetName));
        //}
        //public void AddValueCell(int sheetsNumber,  int aRow, int aCol, string aValue)
        //{
        //    sheets[sheetsNumber].Cells[aRow, aCol].Value = aValue;
        //}
        //public void SaveExcel()
        //{
        //    File.WriteAllBytes(fullPath, package.GetAsByteArray());
        //}
    }
public class ExcelToPdfConverter
    {
        public void ConvertExcelToPdf(string excelFilePath, string pdfFilePath)
        {
            //using (var workbook = new XLWorkbook(excelFilePath))
            //{
                //var converter = new ClosedXML.Pdf.PdfConverter(workbook);
                //converter.ConvertToPdf(pdfFilePath);
            //}
        }

        public void Convert(string inputFilePath, string outputFilePath)
        {
            try
            {
                // Загрузка файла Excel
                var workbook = new Aspose.Cells.Workbook(inputFilePath);

                // Сохранение файла в формате PDF
                workbook.Save(outputFilePath, Aspose.Cells.SaveFormat.Pdf);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при конвертации файла: " + ex.Message);
            }
        }

    }
    //public class ExcelToPdfConverter
    //{
    //    public void Convert(string inputFilePath, string outputFilePath)
    //    {
    //        try
    //        {
    //            // Открытие файла Excel
    //            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;//LicenseContext.Commercial;
    //            using (var package = new ExcelPackage(new System.IO.FileInfo(inputFilePath)))
    //            {
    //                // Создание документа PDF
    //                var document = new iTextSharp.text.Document();

    //                // Создание экземпляра класса PdfWriter
    //                var writer = PdfWriter.GetInstance(document, new System.IO.FileStream(outputFilePath, System.IO.FileMode.Create));

    //                // Открытие документа PDF
    //                document.Open();

    //                // Конвертация каждого листа Excel
    //                foreach (var sheet in package.Workbook.Worksheets)
    //                {
    //                    if (sheet.Dimension == null)
    //                    {
    //                        break;
    //                    }
    //                    // Начало новой страницы
    //                    document.NewPage();

    //                    // Создание таблицы PDF
    //                    var pdfTable = new PdfPTable(sheet.Dimension.Columns);
    //                    pdfTable.DefaultCell.Padding = 3;
    //                    pdfTable.WidthPercentage = 100;
    //                    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

    //                    // Заполнение таблицы PDF данными из Excel
    //                    for (int i = sheet.Dimension.Start.Row; i <= sheet.Dimension.End.Row; i++)
    //                    {
    //                        for (int j = sheet.Dimension.Start.Column; j <= sheet.Dimension.End.Column; j++)
    //                        {
    //                            var cell = sheet.Cells[i, j].Text;
    //                            pdfTable.AddCell(cell);
    //                        }
    //                    }

    //                    // Добавление таблицы PDF в документ
    //                    document.Add(pdfTable);
    //                }

    //                // Закрытие документа PDF
    //                document.Close();
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Ошибка при конвертации файла: " + ex.Message);
    //        }
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
#region Test6
            //var excelToPdfConverter = new ExcelToPdfConverter();
            //excelToPdfConverter.Convert("C:\\Users\\SChichil\\Downloads\\Ком карта BIND.xlsx", "C:\\Users\\SChichil\\Downloads\\путь_к_результирующему_файлу.pdf");


            //If using the Professional version, put your serial key below.
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
           //string key = "SN-2023Jun03-AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            //int d = key.Length;
           //SpreadsheetInfo.SetLicense(key);
                        // Load Excel file.
           ExcelFile workbook = ExcelFile.Load("C:\\Users\\SChichil\\Downloads\\Ком карта BIND.xlsx");

            // Get Excel sheet you want to export.
            //ExcelWorksheet worksheet = workbook.Worksheets[0];

            // Set targeted sheet as active.
            //workbook.Worksheets.ActiveWorksheet = worksheet;

            // Get cell range that you want to export.
            //CellRange range = worksheet.Cells.GetSubrange("A1:I14");

            // Set targeted range as print area.
            //worksheet.NamedRanges.SetPrintArea(range);

            // Save to PDF file.
            // By default, the SelectionType.ActiveSheet is used.
            workbook.Save("C:\\Users\\SChichil\\Downloads\\Convert.pdf");
        }
#endregion
        //#region Test5
        //var excelToPdfConverter = new ExcelToPdfConverter();
        //excelToPdfConverter.Convert("C:\\Users\\SChichil\\Downloads\\Акт cверки взаимных расчетов № 00ИН000001 от 7 сентября 2023 г..xlsx", "C:\\Users\\SChichil\\Downloads\\путь_к_результирующему_файлу.pdf");
        //#endregion
#region Test1
        //////Создание нового файла .xlsx:
        //string file = "D:\\куча документов\\Нокиан\\ДОТнет\\newdoc2.pdf";
        //string fileSave = "D:\\куча документов\\Нокиан\\ДОТнет\\Save.xlsx";
        //string fileSavePDF = "D:\\куча документов\\Нокиан\\ДОТнет\\Save.pdf";
        //ExcelPackage.LicenseContext = LicenseContext.NonCommercial;//LicenseContext.Commercial;
        //ExcelPackage package = new ExcelPackage(new FileInfo(file));
        ////package.Workbook.Worksheets.Add("d");
        ////package.Workbook.Worksheets.Add("d2");
        //ExcelWorksheet sheet1 = package.Workbook.Worksheets[0];
        //ExcelWorksheet sheet = package.Workbook.Worksheets[1];
        ////int uuu = sheet.Dimension.End.Row;
        ////int uu = sheet.Dimension.End.Column;
        //sheet.Name = "Петухbbbb";// .Add("Market1 Report");
        //sheet.View.FreezePanes(2, 1);
        //int t = package.Workbook.Worksheets["Петухbbbb"].Index;
        //sheet.Cells["A1:B8"].Style.WrapText = true;
        //sheet.Columns.AutoFit();
        //DateTime d = new DateTime(2, 04, 12, 12, 22, 11);
        //sheet1.Cells[1, 10].Value = "2005";
        //sheet.Cells[2, 3].Value = "1";
        //sheet.Cells["B3"].Value = "Location:";
        //sheet.Cells["C3"].Value = $"2 " + $"2, " + $"2";
        //sheet1.Cells["C4"].Value = 435345345434534.44;
        //sheet1.Cells["C5"].Value = "efefe efewgew eferefgerrg";
        //sheet1.Cells["C5"].Style.Font.Name = "Times New Roman";
        //sheet.Cells["B4"].Value = "Sector:";
        //sheet.Cells["C3"].Style.Numberformat.Format = "#,##0.00";
        //sheet1.Cells["C4"].Style.Numberformat.Format = "#,##0.00";
        //sheet.Cells[1, 1, 5, 5].Style.Numberformat.Format = DateTimeFormatInfo.CurrentInfo.FullDateTimePattern;
        //sheet.Cells[1, 1, 5, 5].Style.Numberformat.Format = "dd.MM.yyyy HH:mm:ss";
        //sheet.Cells[1, 1, 5, 5].Style.Numberformat.Format = "@";
        //sheet.Cells[1, 1, 5, 5].Style.Numberformat.Format = "0";
        //sheet.Cells[1, 1, 5, 5].Style.Numberformat.Format = "#";
        //sheet.Names.Add("RangeName", sheet.Cells[1, 1, 5, 5]);
        //ExcelNamedRange namedRangeOld = sheet.Names["RangeName"];
        //namedRangeOld.Address = sheet.Cells[3, 3, 7, 7].Address;


        //// Создание нового именованного диапазона с новым именем и тем же адресом
        //ExcelNamedRange namedRange = sheet.Names["RangeName"];
        //string address = namedRange.Address;
        //string newName = "Новое_имя_диапазона";
        //ExcelNamedRange newNamedRange = sheet.Names.Add(newName, sheet.Cells[address]);
        ////sheet.Names.Remove(namedRange.Name);
        //package.Workbook.Names.Add("Боря", package.Workbook.Worksheets[0].Cells[address]);
        //ExcelNamedRange namedRangeOld1 = package.Workbook.Names["Боря"];
        //namedRangeOld1.Address = package.Workbook.Worksheets[0].Cells[1, 1, 22, 22].Address;

        //var t2 = package.Workbook.Names.ContainsKey("wqdqwd");
        ////sheet.Names["RangeName"].Delete(eShiftTypeDelete.Left);
        ////ExcelRange namedRange = sheet.Cells[1, 1, 5, 5];
        ////namedRange.StyleName = "12";
        ////{
        ////    for (int rowIndex = namedRange.Start.Row; rowIndex <= namedRange.End.Row; rowIndex++)
        ////    {
        ////        for (int columnIndex = namedRange.Start.Column; columnIndex <= namedRange.End.Column; columnIndex++)
        ////        {
        ////            sheet.Cells[1, 1, 5, 5].Value = "no more hair pulling";
        ////        }
        ////    }
        ////}
        //sheet.Cells[1, 1, 5, 5].Style.Numberformat.Format = "dd.MM.yyyy";
        //sheet.Cells["B3"].Value = "12-03-2055 15:22:33";
        //string temp = (string)sheet1.Cells[1, 1].Value;
        //string temp2 = sheet1.Cells[100, 5].Value?.ToString();

        //sheet1.Cells[1, 2].Value = temp;
        //AddValueCell(ref sheet, 1, 1, "Пиз\n\rда");
        //sheet.Cells[8, 2, 13, 1].LoadFromArrays(new object[][] { new[] { "Capital ization", "SharePrice", "Date", "Жопа" } });
        //var row = 9;
        //var column = 2;

        //// sheet.Cells[1, 1, row, column + 2].AutoFitColumns();
        ////sheet.Column(2).Width = 14;
        ////sheet.Column(3).Width = 12;
        //sheet.Cells["B11"].Value = "хуй";
        ////sheet.Cells[9, 4, 9 + report.History.Length, 4].Style.Numberformat.Format = "yyyy";
        ////sheet.Cells[9, 2, 9 + report.History.Length, 2].Style.Numberformat.Format = "### ### ### ##0";
        ////sheet.Column(2).Style.Numberformat = ExcelNumberFormat.
        //sheet.Column(2).Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
        //sheet.Cells[8, 3, 8 + 1, 3].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
        //sheet.Column(4).Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;

        //sheet.Cells[8, 2, 8, 4].Style.Font.Bold = true;
        //sheet.Cells["B2:C4"].Style.Font.Bold = true;
        //sheet.Cells[8, 2, 8, 4].CopyStyles(sheet.Cells["B2:C4"]);
        //Color colFromHexBack = System.Drawing.ColorTranslator.FromHtml("#BC1205");
        //Color colFromHexFont = System.Drawing.ColorTranslator.FromHtml("#000000");
        //sheet.Cells["B2:C4"].Style.Fill.PatternType = ExcelFillStyle.Solid;
        //sheet.Cells["B2:C4"].Style.Fill.BackgroundColor.SetColor(colFromHexBack);
        //sheet.Cells["B2:C4"].Style.Font.Color.SetColor(colFromHexFont);
        //sheet.Cells[8, 2, 8, 4].AutoFilter = true;
        //sheet.Cells[5, 2, 6, 2].Merge = true;
        //;
        //sheet.Cells["B2:C4"].Style.Font.Strike = true;

        //sheet.Cells[8, 2, 8 + 21, 4].Style.Border.BorderAround(ExcelBorderStyle.Double);
        //sheet.Cells[8, 2, 8 + 21, 2].Style.Border.BorderAround(ExcelBorderStyle.Double);
        //sheet.Cells[8, 2, 8, 4].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;

        ////var capitalizationChart = sheet.Drawings.AddChart("Findings4Chart", OfficeOpenXml.Drawing.Chart.eChartType.Line);
        ////capitalizationChart.Title.Text = "Capitalization";
        ////capitalizationChart.SetPosition(7, 0, 5, 0);
        ////capitalizationChart.SetSize(800, 400);
        ////var capitalizationData = (ExcelChartSerie)(capitalizationChart.Series.Add(sheet.Cells["B9:B28"], sheet.Cells["D9:D28"]));
        ////capitalizationData.Header = "руб";

        ////sheet.Protection.IsProtected = false;

        //File.WriteAllBytes(fileSave, package.GetAsByteArray());

        //Excel.Application app = new Excel.Application();
        //app.Visible = true;
        //Excel.Workbook workbook = app.Workbooks.Open(fileSave); //к вашей книге
        //app.ActiveWorkbook.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, fileSavePDF);//куда сохраняете
        //workbook.Close();
        //app.Quit();


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


        //// Производим конвертацию в PDF
        ////PdfImageConversionResult pdfResult;
        ////worksheet.ConvertToPdf(out pdfResult);
        ////byte[] pdfBytes = pdfResult.PdfStream.ToArray();

        //// Сохраняем PDF-файл
        ////File.WriteAllBytes(@"D:\\куча документов\\Нокиан\\ДОТнет\\newdoc2.pdf", pdfBytes);

        ////платная хуйня
        ////Workbook workbook = new Workbook();
        //////Load excel file  
        ////workbook.LoadFromFile("D:\\куча документов\\Нокиан\\ДОТнет\\newdoc2.xlsx");
        //////Save excel file to pdf file.  
        ////workbook.SaveToFile("D:\\куча документов\\Нокиан\\ДОТнет\\newdoc2.pdf", Spire.Xls.FileFormat.PDF);
#endregion Test2
#region Test3
        //string file = "C:\\Users\\SChichil\\Downloads\\ОтчетПоЯрлыкам_Шаблон.xlsx";
        //string fileSave = "C:\\Users\\SChichil\\Downloads\\newdoc.xlsx";
        //ExcelPackage.LicenseContext = LicenseContext.NonCommercial;//LicenseContext.Commercial;
        //ExcelPackage package = new ExcelPackage(new FileInfo(file));
        //ExcelWorksheet p = package.Workbook.Worksheets[1];
        ////package.Workbook.Worksheets[3].Tables["d"].AddRow(); 
        //var dd2 = package.Workbook.Worksheets[3].Tables.Add(package.Workbook.Worksheets[3].Cells[3, 3, 7, 7], "Вася");
        //var rr = package.Workbook.Worksheets[3].Tables["Вася"].Address.Rows;
        //var gdgd = package.Workbook.Worksheets[3].Tables["Table2"].Address.Address;
        //package.Workbook.Worksheets[3].Tables["Table2"].AddRow(2);
        //package.Workbook.Worksheets[3].Cells[4,2].Value = "Уровень";
        //package.Workbook.Worksheets[3].Tables["Table2"].AddRow(2);
        ////var r = p.Dimension.End;
        ////ExcelWorksheet sheet1 = package.Workbook.Worksheets[0];
        ////ExcelWorksheet sheet = package.Workbook.Worksheets[1];
        ////int uuu = sheet.Dimension.End.Row;
        ////int uu = sheet.Dimension.End.Column;
        ////sheet.Name = "Петухbbbb";// .Add("Market1 Report");
        ////sheet.View.FreezePanes(2, 1);
        ////int t = package.Workbook.Worksheets["Петухbbbb"].Index;
        ////sheet.Cells["A1:B8"].Style.WrapText = true;
        ////sheet.Columns.AutoFit();
        ////DateTime d = new DateTime(2, 04, 12, 12, 22, 11);
        ////sheet.Cells[1, 10].Value = "2005";
        ////sheet.Cells[2, 3].Value = "1";
        ////sheet.Cells["B3"].Value = "Location:";
        ////sheet.Cells["C3"].Value = $"2 " + $"2, " + $"2";
        ////sheet.Cells["B4"].Value = "Sector:";
        ////sheet.Cells["C3"].Style.Numberformat.Format = "#,##0.00";
        ////sheet.Cells["C3"].Style.Numberformat.Format = "#,##0.00";
        ////sheet.Cells[1, 1, 5, 5].Style.Numberformat.Format = DateTimeFormatInfo.CurrentInfo.FullDateTimePattern;
        ////sheet.Cells[1, 1, 5, 5].Style.Numberformat.Format = "dd.MM.yyyy HH:mm:ss";
        ////sheet.Cells[1, 1, 5, 5].Style.Numberformat.Format = "@";
        ////sheet.Cells[1, 1, 5, 5].Style.Numberformat.Format = "0";
        ////sheet.Cells[1, 1, 5, 5].Style.Numberformat.Format = "#";
        ////sheet.Names.Add("RangeName", sheet.Cells[1, 1, 5, 5]);
        ////ExcelNamedRange namedRangeOld = sheet.Names["RangeName"];
        ////namedRangeOld.Address = sheet.Cells[3, 3, 7, 7].Address;

        //File.WriteAllBytes(fileSave, package.GetAsByteArray());
        //Workbook workbook = new Workbook();
        ////Load excel file  
        //workbook.LoadFromFile(fileSave);
        ////Save excel file to pdf file.  
        //workbook.SaveToFile("result.pdf", Spire.Xls.FileFormat.PDF);
#endregion Test3
#region Test4
        //Excel.Application app = new Excel.Application();
        //app.Visible = true;
        //Excel.Workbook workbook = app.Workbooks.Open("C:\\Users\\SChichil\\Downloads\\Акт cверки взаимных расчетов № 00ИН000002 от 7 сентября 2023 г..xlsx"); //к вашей книге
        //app.ActiveWorkbook.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, "C:\\Users\\SChichil\\Downloads\\Акт cверки взаимных расчетов № 00ИН000002 от 7 сентября 2023 г..pdf");//куда сохраняете
        //workbook.Close();
        //app.Quit();

#endregion
    

        //static void AddValueCell(ref ExcelWorksheet sheet, int aCol, int aRow, string aValue)
        //{
        //    sheet.Cells[aCol, aRow].Value = aValue;
        //}


    }

}
#endif

#if test2

using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using iTextSharp.text;
using iTextSharp.text.pdf;
using GemBox.Spreadsheet;

class Program
{
    //static void AutoFitRowHeight(ExcelWorksheet worksheet, int rowNumber)
    //{
    //    ExcelRow row = worksheet.Row(rowNumber);
    //    row.Height = worksheet.DefaultRowHeight;

    //    for (int col = 1; col <= worksheet.Cells.Columns; col++)
    //    {
    //        ExcelRangeBase cell = worksheet.Cells[rowNumber, col];
    //        if (cell.Value != null)
    //        {
    //        int lineCount = cell.Value.ToString().Split('\n').Length;
    //        if (lineCount > 1)
    //        {
    //            row = worksheet.Row(rowNumber);
    //            row.Height = row.Height * lineCount;
    //        }
    //        }
    //    }
    //}
    public static double GetHeightRowByText(OfficeOpenXml.Style.ExcelFont aFont, double aWidth, object aValue = null)
    {
        if (aValue == null) return 0.0;
        SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
        ExcelFile workbook = new ExcelFile();
        GemBox.Spreadsheet.ExcelWorksheet worksheet = workbook.Worksheets.Add("Sheet1");
        worksheet.Columns[0].SetWidth(aWidth, LengthUnit.CharacterWidth);
        //workbook.Save("C:\\Users\\SChichil\\Downloads\\tempp2.xlsx");
        var tempCell = worksheet.Cells["A1"];
        tempCell.Style.WrapText = true;
        tempCell.Style.Font.Name = aFont.Name;
        tempCell.Style.Font.Size = (int)aFont.Size*20;
        tempCell.Value = aValue;
        workbook.Save("C:\\Users\\SChichil\\Downloads\\tempp2.xlsx");
        var rr = worksheet.Rows[0];
        rr.AutoFit();
        workbook.Save("C:\\Users\\SChichil\\Downloads\\tempp2.xlsx");
        var firstv = rr.GetHeight(LengthUnit.Pixel);
        var dpo = (Math.Round(firstv, 0)+7) * 3/4;
        return dpo;
    }

    //public static double GetHeightRowByText(OfficeOpenXml.Style.ExcelFont aFont, double aWidth, object aValue = null)
    //{
    //    if (aValue == null) return 0.0;
    //    string tempSheetName = "_~TempSheet~_";
    //    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;//LicenseContext.Commercial;
    //    OfficeOpenXml.ExcelPackage p = new ExcelPackage(new FileInfo("temp.xlsx"));
    //    //OfficeOpenXml.ExcelWorksheet tempSheet = p.Workbook.Worksheets[0];
    //    OfficeOpenXml.ExcelWorksheet tempSheet = p.Workbook.Worksheets.Add(tempSheetName);
    //    ExcelRange tempCell = tempSheet.Cells["A1"];
    //    tempCell.Value = aValue;
    //    tempSheet.Column(1).Width = aWidth; // Устанавливаем ширину столбца
    //    tempSheet.Cells.Style.Font = aFont;
    //    tempSheet.Cells.Style.WrapText = true; // Ячейка автоматически адаптируется к размеру
    //    tempSheet.Row(1).CustomHeight = false; // Автоматически настраивать высоту строки
    //    AutoFitRowHeight(tempSheet, 1);
    //    tempCell.Value += "1";
    //    ExcelRow ds = tempSheet.Row(1);
    //    double result = ds.Height;
        
    //    p.SaveAs(new System.IO.FileInfo("C:\\Users\\SChichil\\Downloads\\temp.xlsx"));

    //    return result;
    //}
    static void Main()
{
    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;//LicenseContext.Commercial;
    //ExcelPackage package = new ExcelPackage(new FileInfo("C:\\Users\\SChichil\\Downloads\\ExcelWithGrouping2.xlsx"));
    ExcelPackage package = new ExcelPackage(new FileInfo("NewFile2.xlsx"));
    //ExcelPackage package = new ExcelPackage(new FileInfo("C:\\Users\\SChichil\\Downloads\\temp.xlsx"));
    //var gg = package.Workbook.Worksheets[0].Row(1).Height;
    {
        //var worksheet = package.Workbook.Worksheets[0];
        var worksheet = package.Workbook.Worksheets.Add("Sheet1");

        // Задаем данные для примера
        worksheet.Cells["A1"].Value = "Группа 1";
        worksheet.Cells["A2"].Value = "Данные 1.1";
        worksheet.Cells["A3"].Value = "Данные 1.2";
        worksheet.Cells["A4"].Value = "Группа 2";
        worksheet.Cells["A6"].Value = "Данные 2.1";
        worksheet.Cells["A7"].Value = "Данные 2.2";
        worksheet.Cells["A8"].Value = "Данные222222222222222222222222222222222222222222222222222222222222222222222222222222222222222 2.3";

        // Устанавливаем группировку строк
        //worksheet.Row(2).OutlineLevel = 1;
        worksheet.Row(3).OutlineLevel = 1;
        worksheet.Row(6).OutlineLevel = 0;
        worksheet.Row(8).OutlineLevel = 1;
            var cc = worksheet.Column(1);
            cc.BestFit = true;
            cc.Width = 30;
        worksheet.Column(2).OutlineLevel = 1;
        worksheet.Column(3).OutlineLevel = 1;
        worksheet.OutLineSummaryBelow = false;
        worksheet.OutLineSummaryRight = true;
        worksheet.OutLineApplyStyle = false;
        var dd = GetHeightRowByText(worksheet.Cells["A8"].Style.Font, worksheet.Column(1).Width, worksheet.Cells["A8"].Value);
            worksheet.Cells["A8"].Style.WrapText = true;
            worksheet.Cells["A8"].Style.Font.Name = "Times New Roman";
            worksheet.Row(8).Height = dd;
        // Группируем строки
        //worksheet.Column(3) Group(1, 1); // Группа 1
        //worksheet.Cells["A4:A6"].Group(1, 1); // Группа 2

            // Сохраняем в файл
            package.SaveAs(new System.IO.FileInfo("C:\\Users\\SChichil\\Downloads\\ExcelWithGrouping2.xlsx"));
    }
}
}
#endif

#if test3
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using GemBox.Spreadsheet;
class Program
{
    static void Main(string[] args)
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;//LicenseContext.Commercial;
        ExcelPackage package = new ExcelPackage(new FileInfo("C:\\Users\\SChichil\\Downloads\\ExcelWithGrouping2.xlsx"));

        {
            //var worksheet = package.Workbook.Worksheets[0];
            if (package.Workbook.Worksheets.Count > 0)
            package.Workbook.Worksheets.Delete(0);
            var worksheet = package.Workbook.Worksheets.Add("Sheet1");

            // Задаем данные для примера
            worksheet.Cells["A1"].Value = "Группа 1";
            worksheet.Cells["A2"].Value = "Данные 1.1";
            worksheet.Cells["A3"].Value = "Данные 1.2";
            worksheet.Cells["A4"].Value = "Группа 2";
            worksheet.Cells["A6"].Value = "Данные 2.1";
            worksheet.Cells["A7"].Value = "Данные 2.2";
            worksheet.Cells["A8"].Value = "Данные 2.3";

            worksheet.Names.Add("Диапазон", worksheet.Cells[1, 1, 1, 6]);
            string d = worksheet.Cells["A1"].Address;
            worksheet.Cells["A8"].Value = d;
            worksheet.Cells["A7"].Style.WrapText = true;
            // Сохраняем в файл
            package.SaveAs(new System.IO.FileInfo("C:\\Users\\SChichil\\Downloads\\ExcelWithGrouping2.xlsx"));
        }
    }
}
#endif

#if test4

using NPOI.XWPF.UserModel;
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Создаем новый документ Word
        XWPFDocument document = new XWPFDocument(NPOI.POIXMLDocument.OpenPackage("C:\\Users\\SChichil\\Downloads\\Акт_на_списание — копия.docx"));
        XWPFRun run = document.Paragraphs[1].CreateRun();
        var num = document.GetRelationById("НомерАкта");

        run.SetText("Пример заполнения данных в документ Word");

        //// Создаем параграф и добавляем его в документ
        //XWPFParagraph paragraph = document.CreateParagraph();

        //// Создаем текстовый ран и добавляем его в параграф
        //XWPFRun run = paragraph.CreateRun();
        //run.SetText("Пример заполнения данных в документ Word");

        // Сохраняем документ в файл
        using (FileStream fs = new FileStream("C:\\Users\\SChichil\\Downloads\\А1.docx", FileMode.Create, FileAccess.Write))
        {
            document.Write(fs);
        }
        Console.WriteLine("Документ успешно создан!");
    }
}
#endif

#if test5

using NPOI.XWPF.UserModel;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Путь к вашему шаблону Word
        string templatePath = "C:\\Users\\SChichil\\Downloads\\Акт на списание — копия.docx";

        // Загрузите шаблон Word
        XWPFDocument document;
        using (FileStream fs = new FileStream(templatePath, FileMode.Open, FileAccess.Read))
        {
            document = new XWPFDocument(fs);
        }

        // Получите все параграфы в документе
        foreach (XWPFParagraph paragraph in document.Paragraphs)
        {
            // Проходит по каждому рану в параграфе
            foreach (XWPFRun run in paragraph.Runs)
            {
                // Если текстовый ран содержит маркер DOCVARIABLE, замените его на нужное значение
                if (run.Text.Contains("НомерАкта  "))
                {
                    run.SetText(run.Text.Replace("НомерАкта  ", "1"));
                }
            }
        }

        // Сохраните заполненный документ в новый файл
        using (FileStream fs = new FileStream("C:\\Users\\SChichil\\Downloads\\А1.docx", FileMode.Create, FileAccess.Write))
        {
            document.Write(fs);
        }

        // Закрыть документ
        document.Close();

        //Console.WriteLine("Документ успешно заполнен!");
    }
}
#endif

#if test6
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Linq;
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Путь к вашему документу Word
        string filePath = "C:\\Users\\SChichil\\Downloads\\Акт на списание — копия.docx";

        using (WordprocessingDocument doc = WordprocessingDocument.Open(filePath, false))
        {
            // Получаем все переменные DOCVARIABLE в документе
            var docVariables = doc.MainDocumentPart.Document.Descendants<FieldCode>()
                .Where(fc => fc.Text.Contains("DOCVARIABLE")).ToList();

            // Перебираем каждую переменную DOCVARIABLE и получаем ее значение
            foreach (var docVariable in docVariables)
            {
                if (docVariable != null)
                {
                    var r = docVariable.Parent.Parent.Descendants<Run>();
                    var run = r.LastOrDefault();
                    if (run != null)
                    {

                    }
                }
                string fieldValue = GetDocVariableValue(docVariable);
                Console.WriteLine($"Значение переменной {docVariable.Text}: {fieldValue}");
            }
            doc.SaveAs("C:\\Users\\SChichil\\Downloads\\А2.docx");
        }
    }

    // Метод для получения значения переменной DOCVARIABLE
    static string GetDocVariableValue(FieldCode docVariable)
    {
        Run fieldCodeRun = docVariable.Parent as Run;
        Run fieldResultRun = fieldCodeRun?.NextSibling<Run>();

        if (fieldResultRun != null)
        {
            return fieldResultRun.GetFirstChild<Text>()?.Text;
        }

        return null;
    }
}
#endif

#if test7
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Linq;
using System;
using System.IO;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.CustomProperties;
using DocumentFormat.OpenXml.VariantTypes;

class Program
{
    static void Main(string[] args)
    {
        using (WordprocessingDocument doc = WordprocessingDocument.Open("C:\\Users\\SChichil\\Downloads\\Акт на списание — копия.docx", true))
        {
            var r = doc.SaveAs("C:\\Users\\SChichil\\Downloads\\А2.docx");
            doc.Close();
            doc.Dispose();
            r.Close();
            r.Dispose();
        }
        AddVariableToDocument("C:\\Users\\SChichil\\Downloads\\А2.docx", "НомерАкта", "1");
    }

public static void AddVariableToDocument(string docPath, string variableName, string variableValue)
{
    using (WordprocessingDocument document = WordprocessingDocument.Open(docPath, true))
    {
        // Получаем список переменных документа
        var customPropertiesPart = document.CustomFilePropertiesPart;
        if (customPropertiesPart == null)
        {
            customPropertiesPart = document.AddCustomFilePropertiesPart();
            customPropertiesPart.Properties = new Properties();
        }

        // Проверяем, существует ли уже указанная переменная
        bool variableExists = false;
        foreach (var customProperty in customPropertiesPart.Properties.Elements<CustomDocumentProperty>())
        {
            if (customProperty.Name.Value.Equals(variableName, StringComparison.OrdinalIgnoreCase))
            {
                variableExists = true;
                customProperty.VTLPSTR = new VTLPSTR(variableValue);
                break;
            }
        }

        if (!variableExists)
        {
            // Если переменной еще нет, создаем ее
            CustomDocumentProperty newCustomProperty = new CustomDocumentProperty();
            newCustomProperty.FormatId = "{D5CDD505-2E9C-101B-9397-08002B2CF9AE}";
            newCustomProperty.PropertyId = (customPropertiesPart.Properties.Elements<CustomDocumentProperty>().Count() + 1);
            newCustomProperty.Name = new StringValue(variableName);
            newCustomProperty.VTLPSTR = new VTLPSTR(variableValue);

            customPropertiesPart.Properties.AppendChild(newCustomProperty);
        }
        customPropertiesPart.Properties.Save();
        document.Save();
    }
}
}

#endif

#if test8 //DocWord Рабочая версия
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Linq;
using System.Collections.Generic;
using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using DocumentFormat.OpenXml.Drawing;
using System.IO;
using RunProperties = DocumentFormat.OpenXml.Wordprocessing.RunProperties;
using Run = DocumentFormat.OpenXml.Wordprocessing.Run;
using Text = DocumentFormat.OpenXml.Wordprocessing.Text;
using Table = DocumentFormat.OpenXml.Wordprocessing.Table;
using TableRow = DocumentFormat.OpenXml.Wordprocessing.TableRow;
using Underline = DocumentFormat.OpenXml.Wordprocessing.Underline;
using Paragraph = DocumentFormat.OpenXml.Wordprocessing.Paragraph;
using System;
using A = DocumentFormat.OpenXml.Drawing;
using DW = DocumentFormat.OpenXml.Drawing.Wordprocessing;
using PIC = DocumentFormat.OpenXml.Drawing.Pictures;

class DocWord
{
    WordprocessingDocument document;
    public static DocWord CreateEx(string pathTemplate, bool isEditable = false)
    {
        if (isEditable)
        {
          return new DocWord() { document = WordprocessingDocument.Open(pathTemplate, isEditable) };
        }
        else
        {
          return new DocWord() { document = WordprocessingDocument.CreateFromTemplate(pathTemplate) };
        };
    }

    public void AddPicture(string variableName, string pathPicture,string name = "Picture 1")
    {
        SetDocVariableRun(variableName, CreateRunImage(pathPicture, name)); 
    }
    Run CreateRunImage(string pathPicture, string name = "Picture 1")
    {
        MainDocumentPart mainPart = document.MainDocumentPart;
        ImagePart imagePart = mainPart.AddImagePart(ImagePartType.Jpeg);
        using (FileStream stream = new FileStream(pathPicture, FileMode.Open))
        {
            imagePart.FeedData(stream);
        }
        return new Run(GetElementImage(mainPart.GetIdOfPart(imagePart), name));
    }

    Drawing GetElementImage(string relationshipId,string name)
    {
        // Define the reference of the image.
        var element =
             new Drawing(
                 new DW.Inline(
                     new DW.Extent() { Cx = 990000L, Cy = 792000L },
                     new DW.EffectExtent()
                     {
                         LeftEdge = 0L,
                         TopEdge = 0L,
                         RightEdge = 0L,
                         BottomEdge = 0L
                     },
                     new DW.DocProperties()
                     {
                         Id = (UInt32Value)1U,
                         Name = name
                     },
                     new DW.NonVisualGraphicFrameDrawingProperties(
                         new A.GraphicFrameLocks() { NoChangeAspect = true }),
                     new A.Graphic(
                         new A.GraphicData(
                             new PIC.Picture(
                                 new PIC.NonVisualPictureProperties(
                                     new PIC.NonVisualDrawingProperties()
                                     {
                                         Id = (UInt32Value)0U,
                                         Name = "Bitmap Image.jpg"
                                     },
                                     new PIC.NonVisualPictureDrawingProperties()),
                                 new PIC.BlipFill(
                                     new A.Blip(
                                         new A.BlipExtensionList(
                                             new A.BlipExtension()
                                             {
                                                 Uri =
                                                    "{28A0092B-C50C-407E-A947-70E740481C1C}"
                                             })
                                     )
                                     {
                                         Embed = relationshipId,
                                         CompressionState =
                                         A.BlipCompressionValues.Print
                                     },
                                     new A.Stretch(
                                         new A.FillRectangle())),
                                 new PIC.ShapeProperties(
                                     new A.Transform2D(
                                         new A.Offset() { X = 0L, Y = 0L },
                                         new A.Extents() { Cx = 990000L, Cy = 792000L }),
                                     new A.PresetGeometry(
                                         new A.AdjustValueList()
                                     )
                                     { Preset = A.ShapeTypeValues.Rectangle }))
                         )
                         { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" })
                 )
                 {
                     DistanceFromTop = (UInt32Value)0U,
                     DistanceFromBottom = (UInt32Value)0U,
                     DistanceFromLeft = (UInt32Value)0U,
                     DistanceFromRight = (UInt32Value)0U,
                     EditId = "50D07946"
                 });
        return element;
    }

    void SetDocVariableRun(string variableName, Run run)
    {
        foreach (var field in document.MainDocumentPart.RootElement.Descendants<FieldCode>())
        {
            if (field.Text.Contains(variableName))
            {
                field.Parent.NextSibling().InsertAfterSelf<Run>(run);
                field.Parent.NextSibling().Remove();
                field.Parent.PreviousSibling().Remove();
                field.Parent.Remove();
                break;
            }
        }
    }

    Run CreateRunText (string variableValue,string aFont = "Arial", float aFontSize = 14,
                                 bool isBold = false, bool isItalic = false, bool isUnderline = false)
    {
        RunProperties runProperties = new RunProperties();
        if (isBold) runProperties.Append(new Bold());
        if (isItalic) runProperties.Append(new Italic());
        if (isUnderline) runProperties.Append(new Underline() { Val = new EnumValue<UnderlineValues>(UnderlineValues.Single) });
        runProperties.Append(new RunFonts() { Ascii = aFont, HighAnsi = aFont });
        runProperties.Append(new FontSize() { Val = new StringValue((aFontSize * 2).ToString()) });
        Run result = new Run(new Text(variableValue));
        result.PrependChild(runProperties);
        return result;
    }

    public void SetDocVariableValue(string variableName, string variableValue, 
                                    string aFont = "Arial",float aFontSize = 14, 
                                    bool isBold = false, bool isItalic = false, bool isUnderline = false)
    {
        SetDocVariableRun(variableName, CreateRunText(variableValue, aFont, aFontSize, isBold, isItalic, isUnderline)); 
    }

    public void AddRowTable(int idx,int aCount, int idxLastRow = -1)
    {
        IEnumerable<Table> tables = document.MainDocumentPart.Document.Body.Elements<Table>();
        int i = 0;
        foreach (Table table in tables)
        {
            if (i == idx)
            {
                TableRow row;
                row = (idxLastRow == -1) ? table.Elements<TableRow>().Last() : table.Elements<TableRow>().ElementAt(idxLastRow);

                while (aCount > 0)
                {
                    TableRow newRow = (TableRow)row.Clone();
                    table.InsertAfter<TableRow>(newRow, row);
                    --aCount;
                }
                break;
            }
            else
            {
                ++i;
            }
        }
    }


    public void Save(string path = null)
    {
        if (path == null)
        {
            document.Save();
        }
        else
        {
            document.SaveAs(path).Dispose();
        }
        document.Dispose();
    }
}   

class Program
{
    public static void AddVariableToDocument(string docPath, string variableName, string variableValue)
    {
        using (WordprocessingDocument document = WordprocessingDocument.Open(docPath,true))
        {
            // Ищем все поля в документе
            var fields = document.MainDocumentPart.RootElement.Descendants<FieldCode>();
            foreach (var field in fields)
            {
                // Проверяем, содержит ли поле указанное имя переменной
                if (field.Text.Contains(variableName))
                {
                    // Заменяем значение DOCVARIABLE
                    var root = field.Parent.Parent;
                    Run r = new Run(new Text(variableValue));
                    
                    var cj = field.Parent.NextSibling().NextSibling();
                    //RunFonts runFonts = new RunFonts() { Ascii = "Times New Roman" };
                    RunFonts runFonts = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial" };
                    var fontSize = new FontSize { Val = new StringValue("28") };
                    RunProperties runProperties = new RunProperties(); 
                    runProperties.Append(runFonts);
                    runProperties.Append(fontSize);
                    r.PrependChild(runProperties);
                    root.InsertAfter<Run>(r, field.Parent.NextSibling());
                    field.Parent.NextSibling().Remove();
                    field.Parent.PreviousSibling().Remove();
                    field.Parent.Remove();
                }
            }
            // Сохраняем изменения в документе

            var f = document.SaveAs("C:\\Users\\SChichil\\Downloads\\А34.docx");
            f.Dispose();

        }
    }
    static void Main(string[] args)
    {
        DocWord dw = DocWord.CreateEx("C:\\Users\\SChichil\\Downloads\\А1.docx");
        dw.SetDocVariableValue("КПП", "2", "Times New Roman",14,true);
        dw.SetDocVariableValue("ИНН", "Русский", "Times New Roman", 14, true, true, true);
        //dw.SetDocVariableValue("ОчерПлат", "12.12.2024", "Times New Roman", 14, true, true, true);
        dw.AddRowTable(1, 3);
        dw.AddPicture("Code","C:\\Users\\SChichil\\Downloads\\Снимок6.jpg","Имя_не_обязательно");
        dw.AddPicture("ОчерПлат", "C:\\Users\\SChichil\\Downloads\\Служба печати LDP.PNG", "Тест");
        dw.Save("C:\\Users\\SChichil\\Downloads\\А34.docx");
        //using (WordprocessingDocument document = WordprocessingDocument.Open("C:\\Users\\SChichil\\Downloads\\А2.docx", true))
        //{
        // Добавляем значение в пользовательское свойство
        //CustomPropertiesHelper.AddCustomProperty(document, "НомерАкта", "1");
        //AddVariableToDocument("C:\\Users\\SChichil\\Downloads\\А1.docx", "НомерАкта", "1");
        //AddVariableToDocument("C:\\Users\\SChichil\\Downloads\\А1.docx", "НазваниеАкта", "Текст");
        //AddVariableToDocument("C:\\Users\\SChichil\\Downloads\\А1.docx", "ДатаАкта", "12.12.2024");
        // Получаем значение из пользовательского свойства
        //string value = CustomPropertiesHelper.GetCustomProperty(document, "НомерАкта");

        //Console.WriteLine("Значение переменной: " + value);
        //}
    }
}



#endif

#if test9
using GemBox.Spreadsheet;

class Program
{
    public static double MeasureTextHeight(ExcelFile workbook, int sheetsNumber, CellRange[] aCellRangeArr)
    {
        ExcelWorksheetCollection sheets = workbook.Worksheets;
        ExcelWorksheet sheet = sheets[sheetsNumber];
        string tempSheetName = "_~TempSheet~_";
        ExcelWorksheet tempSheet = sheets.Add(tempSheetName);
        for (int i = 0; i < aCellRangeArr.Length; i++)
        {
            CellRange aCellRange = aCellRangeArr[i];
            ExcelCell c = sheet.Cells[aCellRange.LastRowIndex, aCellRange.FirstColumnIndex];
            double vWidth = 0;
            for (int j = aCellRange.FirstColumnIndex; j < aCellRange.LastColumnIndex+1; j++)
                vWidth += sheet.Columns[j].GetWidth(LengthUnit.CharacterWidth);
            tempSheet.Columns[i].SetWidth(vWidth, LengthUnit.CharacterWidth);
            ExcelCell tempCell = tempSheet.Cells[0,i];
            tempCell.Style.WrapText = true;
            tempCell.Style.Font = aCellRange.Style.Font;
            tempCell.Value = c.Value;
        }
        tempSheet.Rows[0].AutoFit();
        double result = tempSheet.Rows[0].GetHeight(LengthUnit.Point);
        sheets.Remove(tempSheetName);
        return result;
    }
    static void Main(string[] args)
    {
        // Установка лицензии GemBox.Spreadsheet
        SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

        // Создание нового документа Excel
        ExcelFile workbook = ExcelFile.Load("C:\\Users\\SChichil\\Downloads\\УПД.xlsx");

        // Добавление нового листа
        ExcelWorksheet worksheet = workbook.Worksheets[0];
        NamedRange nr = worksheet.NamedRanges["table_НоменклатураКод"];
        NamedRange nr2 = worksheet.NamedRanges["table_ПредставлениеНоменклатуры"];
        // Установка текста в объединенную ячейку
        CellRange[] Arr = { worksheet.Cells.GetSubrangeAbsolute(nr.Range.FirstRowIndex, nr.Range.FirstColumnIndex, nr.Range.LastRowIndex, nr.Range.LastColumnIndex),
                            worksheet.Cells.GetSubrangeAbsolute(nr2.Range.FirstRowIndex, nr2.Range.FirstColumnIndex, nr2.Range.LastRowIndex, nr2.Range.LastColumnIndex) };
        double h = MeasureTextHeight(workbook,0, Arr);
        worksheet.Rows[nr.Range.LastRowIndex].SetHeight(h, LengthUnit.Point);
        // Сохранение документа в файл
        workbook.Save("C:\\Users\\SChichil\\Downloads\\temp.xlsx");
    }
}
#endif