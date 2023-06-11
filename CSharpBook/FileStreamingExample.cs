using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook
{
    internal class FileStreamingExample
    {
        public FileStreamingExample() { }

        public void ReadWordFile()
        {
            string FilePath = @"C:\GRL\AppData\DebugLogger_DetailLogger.txt";
            string fileLineData = "";
            try
            {
                if (File.Exists(FilePath))
                {
                    using (StreamReader sr = new StreamReader(FilePath))
                    {
                        fileLineData = sr.ReadToEnd();
                        Console.WriteLine(fileLineData);
                    }
                }
                else
                {
                    Console.WriteLine($"Check the file in path {FilePath}");
                }
            }
            catch (Exception e)
            {

            }
        }

        public void MainMethod()
        {

        }
    }
}
