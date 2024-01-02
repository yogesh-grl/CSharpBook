using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
    }
}
