using System;
using System.IO;
using System.Threading;

namespace Update
{
    class Update
    {
        string pathUpdate = @"\\172.17.18.50\Users\Public\AppClientTurbo\Update";
        string pathTempUpdate = Directory.GetCurrentDirectory() + @"\Update";
        public void start()
        {
            if (Directory.Exists(pathTempUpdate)) Directory.Delete(pathTempUpdate, true);
            copyDir(pathUpdate, pathTempUpdate);

            string[] files = Directory.GetFiles(pathTempUpdate);
            string[] dirs = Directory.GetDirectories(pathTempUpdate);
            foreach (string dir in dirs)
            {
                string[] splited = dir.Split('\\');
                string dirName = splited[splited.Length - 1];
                string toDir = Directory.GetCurrentDirectory() + "\\" + dirName;
                if (Directory.Exists(toDir)) Directory.Delete(toDir, true);
                copyDir(dir, Directory.GetCurrentDirectory() + "\\" + dirName);
            }
            foreach (string file in files)
            {
                string[] splited = file.Split('\\');
                string fileName = splited[splited.Length - 1];
                string toDir = Directory.GetCurrentDirectory() + "\\" + fileName;
                if (File.Exists(toDir)) File.Delete(toDir);
                File.Move(file, toDir);
            }
            Directory.Delete(pathTempUpdate, true);
        }
        void copyDir(string fromDir, string toDir)
        {
            Directory.CreateDirectory(toDir);
            string[] files = Directory.GetFiles(fromDir);
            string[] dirs = Directory.GetDirectories(fromDir);
            foreach (string dir in dirs)
            {
                string[] splited = dir.Split('\\');
                string dirName = splited[splited.Length - 1];
                copyDir(dir, toDir + "\\" + dirName);
            }
            foreach (string file in files)
            {
                string[] splited = file.Split('\\');
                string fileName = splited[splited.Length - 1];
                File.Copy(file, toDir + "\\" + fileName);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Thread.Sleep(100);
                Console.WriteLine("Обновление Началось!");

                Update update = new Update();
                for (int i = 12; i > 0; i--)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write('.');
                    }
                    Console.WriteLine('.');
                }
                update.start();
                Console.WriteLine("Обновление Завершено Успешно!");
                string pathExeClient = Directory.GetCurrentDirectory() + @"\AppClientTurbo.exe";
                if (File.Exists(pathExeClient))
                    System.Diagnostics.Process.Start(pathExeClient);
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
