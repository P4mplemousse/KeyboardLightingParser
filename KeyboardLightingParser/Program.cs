using System;
using System.IO;

namespace KeyboardLightingParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Keyboard lighting effects file(s) path (file or folder): ");
            var path = Console.ReadLine();

            if (File.Exists(path))
            {
                try
                {
                    FileParser parser = new FileParser();
                    parser.Parse(path);

                    Console.Write(path + " results : \n");
                    Console.Write(parser.ToString() + "\n");
                }
                catch (Exception ex)
                {
                    Console.Write(path + " : \n" + ex.Message + "\n\n");
                }

                Console.Write("Complete. Press any key to quit\n");
                Console.Read();
            }
            else if (Directory.Exists(path))
            {
                var files = Directory.EnumerateFiles(path);
                foreach(var filePath in files)
                {
                    try
                    {
                        FileParser parser = new FileParser();
                        parser.Parse(filePath);

                        Console.Write(filePath + " results : \n");
                        Console.Write(parser.ToString() + "\n");
                    }
                    catch (Exception ex)
                    {
                        Console.Write(filePath + " : \n" + ex.Message + "\n\n");
                    }
                }

                Console.Write("Complete. Press any key to quit\n");
                Console.Read();
            }
            else
            {
                Console.Write("File does not exist !!!\n Press any key to quit\n");
                Console.Read();
            }
        }
    }
}
