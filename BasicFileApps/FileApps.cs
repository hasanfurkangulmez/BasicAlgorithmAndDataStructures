using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BasicAlgorithmAndDataStructures.BasicFileApps
{
    internal class FileApps
    {
        public FileApps()
        {
            //string Source = PhysicalRoad(@"BasicFileApps\Names.txt");
            string Destination = PhysicalRoad(@"BasicFileApps\Namess.txt");
            //FileCopy(Source, Destination);
            FileDelete(Destination);
        }
        public static void FileReader()
        {
            try
            {
                //Dynamic Location
                string[] DirectoryRoad = Directory.GetCurrentDirectory().Split('\\');
                string FileRoad = "";
                for (int i = 0; i < DirectoryRoad.Length - 3; i++)
                {
                    FileRoad += DirectoryRoad[i] + '\\';
                }
                FileRoad += @"BasicFileApps\Numbers.txt";

                //File Read And Write IDispossible
                using (StreamReader SR = new StreamReader(FileRoad))
                {
                    string Line;
                    while ((Line = SR.ReadLine()) != null)
                    {
                        Console.WriteLine(Line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void FileWriter()
        {
            try
            {
                // Dynamic Road Definition
                string[] DirectoryRoad = Directory.GetCurrentDirectory().Split('\\');
                string FileRoad = "";
                for (int i = 0; i < DirectoryRoad.Length - 3; i++)
                {
                    FileRoad += DirectoryRoad[i] + "\\";
                }
                FileRoad += @"BasicFileApps\Names.txt";
                string[] Names = new string[] { "Zara", "Ayca", "Mehmet", "Selim", "Kaan" };
                using (StreamWriter SW = new StreamWriter(FileRoad))
                {
                    foreach (string Name in Names)
                    {
                        SW.WriteLine(Name);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static string PhysicalRoad(string FileName)
        {
            //Dynamic Road Definition
            string[] DirectoryRoad = Directory.GetCurrentDirectory().Split('\\');
            string FileRoad = "";
            for (int i = 0; i < DirectoryRoad.Length - 3; i++)
                FileRoad += DirectoryRoad[i] + '\\';
            FileRoad += FileName;
            return FileRoad;
        }
        public static void FileAdd()
        {
            string Name = "";
            string FileRoad = PhysicalRoad("BasicFileApps\\Names.Txt");
            try
            {
                FileStream FS = new FileStream(FileRoad, FileMode.Append, FileAccess.Write, FileShare.None);
                while (Name != "Çıkış")
                {
                    Console.Write("\n Dosyaya kaydetmek üzere bir isim giriniz: ");
                    Name = Console.ReadLine();
                    if (Name != "Çıkış")
                    {
                        if (FS.CanWrite)
                        {
                            byte[] Write = Encoding.UTF8.GetBytes(Name);
                            FS.Write(Write, 0, Write.Length);
                            FS.WriteByte(13);//13=Enter
                        }
                        else
                        {
                            Console.WriteLine("Yazma yetkisi yok!");
                        }
                    }
                }
                FS.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void FileInfo()
        {
            string FileRoad = PhysicalRoad("BasicFileApps\\Names.txt");
            var FI = new FileInfo(FileRoad);
            Console.WriteLine(FI.FullName);
            Console.WriteLine(FI.Length);
            Console.WriteLine(FI.Extension);
            Console.WriteLine(FI.CreationTime);
            Console.WriteLine(FI.LastAccessTime);
            Console.WriteLine(FI.Name);
        }
        public static void FileCopy(string src, string dest)
        {
            try
            {
                FileInfo FI = new FileInfo(src);
                FI.CopyTo(dest);
                Console.WriteLine("{0} kaynaklı dosya {1} kopyalandi.", src, dest);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void FileDelete(string Source)
        {
            try
            {
                FileInfo FI = new FileInfo(Source);
                FI.Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                throw;
            }
        }
    }
}
