using Newtonsoft.Json;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
//using System.Xml;

namespace CSharpBook
{
    public class WorkOut
    {
        public WorkOut()
        {

        }

        public void WorkoutSample3()
        {
            try
            {
                string sample = "Yogeshh";
                int count = 0;
                Dictionary<char, int> outDic = new Dictionary<char, int>();
                for (int i = 0; i < sample.Count(); i++)
                {
                    if (outDic.ContainsKey(sample[i]))
                    {
                        continue;
                    }
                    else
                    {
                        count = 0;
                        for (int j = i; j < sample.Count(); j++)
                        {
                            if (sample[i] == sample[j])
                            {
                                count++;
                            }
                        }
                        outDic.Add(sample[i], count);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void workOutSample2()
        {
            int a = 1;
            int count = a.IntegerExtensionMethod();
        }
        /// <summary>
        /// Return type is int but we are returning double
        /// </summary>
        /// <returns></returns>
        public int WorkOutSample1()
        {
            return 1 + 2;//+ 0.0;
        }
        public (int value, bool status, int value2) WorkOutSample4TupleExample()
        {
            return (1, true, 2);
        }
        public void WorkoutSample4()
        {
            (int value, bool status, int value2) work = WorkOutSample4TupleExample();

            int value = work.value;
            bool status = work.status;
            int value2 = work.value2;
        }
        public void GetDirectoriesAndFiles(string root)
        {
            try
            {
                // Retrieve all directories in the current directory
                string[] directories = Directory.GetDirectories(root);

                // Display all files in the current directory
                string[] files = Directory.GetFiles(root);
                foreach (string file in files)
                {
                    Console.WriteLine("File: " + file);
                }

                // Recursively call the method for each directory found
                foreach (string directory in directories)
                {
                    GetDirectoriesAndFiles(directory);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
        public List<int> FindByteCountsBetweenPattern(string filePath, byte[] pattern)
        {
            List<int> byteCounts = new List<int>();
            bool patternFound = false;

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    byte[] buffer = new byte[pattern.Length];
                    int bytesRead;
                    int byteCount = 0;

                    while ((bytesRead = reader.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        for (int i = 0; i < bytesRead - pattern.Length + 1; i++)
                        {
                            if (buffer[i] == pattern[0])
                            {
                                bool match = true;

                                for (int j = 1; j < pattern.Length; j++)
                                {
                                    if (buffer[i + j] != pattern[j])
                                    {
                                        match = false;
                                        break;
                                    }
                                }

                                if (match)
                                {
                                    patternFound = true;
                                    byteCounts.Add(byteCount);
                                    byteCount = 0;
                                    break;
                                }
                            }

                            byteCount++;
                        }

                        if (patternFound)
                        {
                            patternFound = false;
                        }
                        else
                        {
                            byteCount += bytesRead;
                        }
                    }
                }
            }

            return byteCounts;
        }
        static async Task KeepRunningAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                Console.WriteLine("You are inside a dead loop");
                Console.WriteLine("Press Ctrl + C");
                Thread.Sleep(1000);
            }
        }
        public async void cancellationTokenExample()
        {
            try
            {
                Console.Clear();
                CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

                Console.CancelKeyPress += (sender, eventArgs) =>
                {
                    eventArgs.Cancel = true;
                    cancellationTokenSource.Cancel();
                };

                await KeepRunningAsync(cancellationTokenSource.Token);

                Console.WriteLine("Outside loop");
            }
            catch (Exception ex)
            {
            }
        }

        public void CSVToJSON()
        {

            string csvFilePath = @"E:\Projects\Sample\GITHUB Data.xlsx";
            string jsonFilePath = @"E:\\Projects\\Sample\\GRLGITHubData.json";

            List<UserModel> userList = new List<UserModel>();

            using (var package = new ExcelPackage(new FileInfo(csvFilePath)))
            {
                var worksheet = package.Workbook.Worksheets[0]; // Assuming data is in the first worksheet

                // Assuming the Excel columns are in the same order as the UserModel properties
                for (int row = 2; row <= worksheet.Dimension.Rows; row++)
                {
                    var user = new UserModel
                    {
                        UserID = int.Parse(worksheet.Cells[row, 1].Value.ToString()),
                        UserName = worksheet.Cells[row, 2].Value.ToString(),
                        Team = worksheet.Cells[row, 3].Value.ToString(),
                        EmailID = worksheet.Cells[row, 4].Value.ToString()
                    };

                    userList.Add(user);
                }
            }


            string jsonContent = JsonConvert.SerializeObject(userList, Formatting.Indented);

            File.WriteAllText(jsonFilePath, jsonContent);
        }

        public void StringExplore()
        {
            string x = "String1";
            string Y = "String1";
            if(x.SequenceEqual(Y))
            {

            }
            if(x == Y)
            {

            }
        }
    }

    public class UserModel
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Team { get; set; }
        public string EmailID { get; set; }
    }
}

