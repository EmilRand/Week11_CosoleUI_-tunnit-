using System;
using System.IO;

namespace TimCoFilesAndFolders
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\opilane\source\repos\LOGITpe21";

            //string[] dirs = Directory.GetDirectories(rootPath, "", SearchOption.AllDirectories);

            //foreach (string dir in dirs)
            //{
            //    Console.WriteLine($"{dir}");
            //}

            //var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            /*
            foreach (string file in files)
            {
                Console.WriteLine($"{file}");                                           
                Console.WriteLine($"{Path.GetFileName(file)}");                         
                Console.WriteLine($"{Path.GetFileNameWithoutExtension(file)}");         
                Console.WriteLine($"{Path.GetFullPath(file)}");                         
                Console.WriteLine($"{Path.GetDirectoryName(file)}");                    
                var info = new FileInfo(file);
                Console.WriteLine($"{Path.GetFileName(file)} {info.Length} bytes");     
            }*/

            //string newDirectoryPath = mingi sugune asukoht 

            /*
            bool directoryExists = Directory.Exists(newDirectoryPath);
            if (directoryExists)                                                      
            {
                Console.WriteLine("Exists");
            }
            else
            {
                Console.WriteLine("Nope.avi");
                Directory.CreateDirectory(newDirectoryPath);
            }
            */

            //string[] files = Directory.GetFiles(rootPath);
            //string destinationFolder = @"D:\FileSystem\SubFolderPlayer\";

            //foreach (string file in files)
            //{
            //File.Copy(file, $"{destinationFolder}{Path.GetFileName(file)}"/*, true*/); 
            //}

            //for (int i = 0; i < files.Length; i++)
            //{
            //    File.Copy(files[i], $"{destinationFolder}{i}.txt", false);
            //}

            //foreach (string file in files)
            //{
            //    File.Move(file, $"{destinationFolder}{Path.GetFileName(file)}");
            //}

            var files = Directory.GetFiles(rootPath, "*.txt", SearchOption.AllDirectories);     

            foreach (string file in files)
            {
                Console.WriteLine($"{file}");                                          
                //Console.WriteLine($"{Path.GetFileName(file)}");                         
                //Console.WriteLine($"{Path.GetFileNameWithoutExtension(file)}");         
                //Console.WriteLine($"{Path.GetFullPath(file)}");                         
                //Console.WriteLine($"{Path.GetDirectoryName(file)}");                    
                //var info = new FileInfo(file);
                //Console.WriteLine($"{Path.GetFileName(file)} {info.Length} bytes");     
            }


            Console.ReadLine();

        }
    }
}