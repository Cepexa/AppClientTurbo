#define GetObjectMetadataResponse
using System;
using System.Text;
using System.IO;
using System.Configuration;
using System.Threading.Tasks;
using Amazon.S3.Model;
using Amazon.S3;
using System.Net;
using System.Threading;
using System.Net.NetworkInformation;
using System.Collections.Generic;
using System.Linq;

namespace MinIO_TEST
{

    public class FtpHelper
    {
        public DateTime GetLastModifiedTime(string ftpUrl, string ftpUsername, string ftpPassword)
        {
            // Create FtpWebRequest with the specified URL
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpUrl);

            // Set credentials
            request.Credentials = new NetworkCredential(ftpUsername, ftpPassword);

            // Specify the command to be executed: MDTM
            request.Method = WebRequestMethods.Ftp.GetDateTimestamp;

            try
            {
                // Get the response
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    // Check if the response status is OK
                    if (response.StatusCode == FtpStatusCode.FileStatus)
                    {
                        // Parse the last modified date from the response
                        DateTime lastModified = response.LastModified;
                        return lastModified;
                    }
                    else
                    {
                        throw new Exception($"FTP Error: {response.StatusCode} {response.StatusDescription}");
                    }
                }
            }
            catch (WebException ex)
            {
                throw new Exception($"FTP Error: {ex.Message}", ex);
            }
        }
    }

#if down

    class Program
    {
        static void Main()
        {
            string ftpServerUrl = "ftp://127.0.0.1:21";
            string userName = "test";
            string password = "1";
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpServerUrl + "/F/Описание взаимодействия 1С_ДО и Турбо ERP.docx");
            request.Credentials = new NetworkCredential(userName, password);
            request.Method = WebRequestMethods.Ftp.DeleteFile;

            try
            {
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Console.WriteLine("Файл успешно удален с FTP-сервера.");
                response.Close();
            }
            catch (WebException e)
            {
                Console.WriteLine("Произошла ошибка: " + e.Message);
            }
        }
        public static void Main231()
        {
            string ftpServer = "ftp://127.0.0.1:21";
            string ftpUsername = "test";
            string ftpPassword = "1";
            using (WebClient client = new WebClient())
            {
                client.Credentials = new NetworkCredential(ftpUsername, ftpPassword);
                client.UploadFile(ftpServer + "/F/check.txt", "STOR", "C:\\Users\\SChichil\\Downloads\\Example.xml");

                Console.WriteLine("File uploaded successfully.");
            }
        }
    static void Main311()
        {
            // FTP сервер и учетные данные
            string ftpServer = "ftp://127.0.0.1:21";
            string userName = "test";
            string password = "1";

            // Подключение к FTP серверу
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpServer+"/F");
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            request.Credentials = new NetworkCredential(userName, password);

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            // Получение списка файлов на FTP сервере
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            string fileList = reader.ReadToEnd();
            Console.WriteLine(fileList);

            reader.Close();
            response.Close();

            // Скачивание файла с FTP сервера
            string fileName = "Message_БП_СБ.xml";
            string localFilePath = "C:\\Users\\SChichil\\Downloads\\тест\\" + fileName;
            request = (FtpWebRequest)WebRequest.Create(ftpServer +"/F/"+ fileName);
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.Credentials = new NetworkCredential(userName, password);

            response = (FtpWebResponse)request.GetResponse();
            responseStream = response.GetResponseStream();
            FileStream fileStream = new FileStream(localFilePath, FileMode.Create);
            IEnumerable<byte> repeatedBytes = Enumerable.Repeat(new byte(), 1024);
            byte[] buffer = repeatedBytes.ToArray();
            int bytesRead = responseStream.Read(buffer, 0, 1024);

            while (bytesRead > 0)
            {
                fileStream.Write(buffer, 0, bytesRead);
                bytesRead = responseStream.Read(buffer, 0, 1024);
            }

            fileStream.Close();
            response.Close();
            Console.WriteLine("Файл скачан по пути: " + localFilePath);
        }
    }
#endif
    class Program22
    {
#if Ping
        static void Main()
        {
            Ping ping = new Ping();
            PingReply reply = ping.Send("172.17.18.25");
            
            if (reply.Status.Equals(IPStatus.Success))
            {
                Console.WriteLine("Пропингование успешно. Задержка: " + reply.RoundtripTime + " мс");
            }
            else
            {
                Console.WriteLine("Не удалось пропинговать сервер. Статус: " + reply.Status);
            }
        }
#endif
#if DirOrFiles
        static void Main229()
        {
            string ftpUrl = "ftp://127.0.0.1:21";
            string username = "test";
            string password = "1";

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpUrl + "/F");
            request.Credentials = new NetworkCredential(username, password);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            using (Stream responseStream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(responseStream))
            {
                string listing = reader.ReadToEnd();
                string[] lines = listing.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string line in lines)
                {
                    if (!line.StartsWith("d"))
                    {
                        string[] tokens = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        string fileName = tokens[tokens.Length - 1];
                        Console.WriteLine(fileName);
                    }
                }
            }
        }
        static void Main228()//только каталоги
        {
            string ftpUrl = "ftp://127.0.0.1:21";
            string username = "test";
            string password = "1";

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpUrl + "/F");
            request.Credentials = new NetworkCredential(username, password);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            using (Stream responseStream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(responseStream))
            {
                string listing = reader.ReadToEnd();
                string[] lines = listing.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string line in lines)
                {
                    if (line.StartsWith("d"))
                    {
                        string[] tokens = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        string directoryName = tokens[tokens.Length - 1];
                        Console.WriteLine(directoryName);
                    }
                }
            }
        }
#endif

        static void Main3()
        {
             string fileUrl = "http://172.17.117.200:9000/vedro/%D0%9E%D1%87%D0%B5%D1%80%D0%B5%D0%B4%D1%8C.docx?AWSAccessKeyId=O5nnKcYiiUr0Y2gEHLqu&Expires=1712734867&Signature=ZmY%2BHxYAhT%2BuoED%2FsRNA5Rn9TI4%3D"; // Замените на ссылку на файл

            // Извлекаем название и расширение файла из URL
            Uri uri = new Uri(fileUrl);
            string fileName = System.IO.Path.GetFileName(uri.LocalPath); // Получаем название файла
            string fileExtension = System.IO.Path.GetExtension(fileName); // Получаем расширение файла

            Console.WriteLine("File Name: " + fileName);
            Console.WriteLine("File Extension: " + fileExtension);
        }
    }
    namespace DownloadFileExample
    {
        class Program3
        {
            static void Main2(string[] args)
            {
                string url = "http://172.17.117.200:9000/vedro/%D0%9E%D1%87%D0%B5%D1%80%D0%B5%D0%B4%D1%8C.docx?AWSAccessKeyId=O5nnKcYiiUr0Y2gEHLqu&Expires=1712734867&Signature=ZmY%2BHxYAhT%2BuoED%2FsRNA5Rn9TI4%3D";
                WebClient client = new WebClient();
                try
                {
                    byte[] fileData = client.DownloadData(url);

                    Console.WriteLine("File downloaded successfully!");
                    // Выводим бинарные данные на экран (для примера)
                    //string str = Encoding.UTF8.GetString(fileData);
                    string str = Convert.ToBase64String(fileData);
                    Console.WriteLine("Binary data: " + str);//BitConverter.ToString(fileData));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while downloading the file: " + ex.Message);
                }
            }
        }
    }
    public class Program2
    {
        public static async Task Main22()
        {

            string accessKey = "uwQsos03bO3HsNpQkrP9";
            string secretKey = "6vTri2vczKN39vLCFEDXm0JzUxGDIscvmCB4lKVl";
            string bucketName = "test";
            string key = "Hello2222.txt";
            string filePath = "C:\\Users\\SChichil\\Downloads\\Организации (пример JSON).txt";
            string serverUrl = "http://127.0.0.1:9000"; // Укажите правильный URL вашего локального сервера Minio
            var config = new Amazon.S3.AmazonS3Config
            {
                ServiceURL = serverUrl,
                ForcePathStyle = true,
                //Timeout = new TimeSpan(),               
            };
            using (var client = new Amazon.S3.AmazonS3Client(accessKey, secretKey, config))
            {
#if binaryLoad
                string Hello = "Hekko";
                var fileData = Convert.FromBase64String(Hello); //Encoding.UTF8.GetBytes(Hello);
                //byte[] fileData = { 0x48, 0x65, 0x6C, 0x6C, 0x6F, 0x20, 0x57, 0x6F, 0x72, 0x6C, 0x64 };
                using (MemoryStream stream = new MemoryStream(fileData))
                {
                    PutObjectRequest request = new PutObjectRequest
                    {
                        BucketName = bucketName,
                        Key = key,
                        InputStream = stream,
                        ContentType = "application/octet-stream"
                    };
                    PutObjectResponse response = client.PutObjectAsync(request).Result;
                }
#endif
#if Url
                GetPreSignedUrlRequest urlRequest = new GetPreSignedUrlRequest
        {
            BucketName = bucketName,
            Key = key,
            Expires = DateTime.Now.AddHours(1) // Устанавливаем срок действия ссылки
        };

        string url = client.GetPreSignedURL(urlRequest);
        var  tempurl = url;
#endif
#if PutBucket
                PutBucketRequest request = new PutBucketRequest
            {
                BucketName = bucketName
            };
                PutBucketResponse b = client.PutBucketAsync(request).Result;


                DeleteBucketRequest requestDel = new DeleteBucketRequest
                {
                    BucketName = bucketName
                };

                DeleteBucketResponse db = client.DeleteBucketAsync(requestDel).Result;

#endif
#if DeleteObj
                DeleteObjectRequest request = new DeleteObjectRequest
            {
                BucketName = bucketName,
                Key = key
            };

                DeleteObjectResponse resp = client.DeleteObjectAsync(request).Result;
                Console.WriteLine("File with key {0} has been deleted from bucket {1}", key, bucketName);
#endif
#if GetObjectMetadataResponse
                GetObjectMetadataRequest request = new GetObjectMetadataRequest
                {
                    BucketName = bucketName,
                    Key = key
                };
                GetObjectMetadataResponse response = await client.GetObjectMetadataAsync(request);
                var r = response.LastModified.ToString();
#endif
#if PutObject
                var putObjectRequest = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = Path.GetFileName(filePath),
                    FilePath = filePath
                };
                PutObjectResponse response = client.PutObjectAsync(putObjectRequest).Result;
                Console.WriteLine("File uploaded successfully");
#endif
#if DownloadFile
             string localFilePath = "C:\\Users\\SChichil\\Downloads\\Hello5.txt";
            GetObjectRequest getObjectRequest = new GetObjectRequest
            {
                BucketName = bucketName,
                Key = key
            };

            using (GetObjectResponse response = await client.GetObjectAsync(getObjectRequest))
            {
                using (Stream responseStream = response.ResponseStream)
                {
                    using (FileStream fileStream = File.Create(localFilePath))
                    {
                        responseStream.CopyToAsync(fileStream).Wait();
                            fileStream.Dispose();
                    }
                }
            }
            Console.WriteLine("Файл успешно скачан и сохранен по пути: " + localFilePath);
#endif
#if GetObjectAsync
                Amazon.S3.Model.GetObjectRequest request = new Amazon.S3.Model.GetObjectRequest
                {
                    BucketName = bucketName,
                    Key = key
                };
                using (var response = client.GetObjectAsync(request))
                {
                    Amazon.S3.Model.GetObjectResponse response2 = response.Result;
                    using (Stream responseStream = response2.ResponseStream)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            string data = reader.ReadToEnd();
                            Console.WriteLine("StatusCode: " + response2.HttpStatusCode);
                            Console.WriteLine("File content:" + data);

                            Console.ReadLine();
                        }
                    }
                } 
#endif
#if ListObjectsV2Async
                ListObjectsV2Request request = new ListObjectsV2Request
                {
                    BucketName = bucketName
                };

                ListObjectsV2Response response = await client.ListObjectsV2Async(request);

                foreach (S3Object s3Object in response.S3Objects)
                {
                    Console.WriteLine(s3Object.Key);
                }
#endif
#if ListBuckets
                ListBucketsResponse response = await client.ListBucketsAsync();
                foreach (S3Bucket bucket in response.Buckets)
                {
                    Console.WriteLine(bucket.BucketName);
                }
#endif
            }
        }
    }
}
