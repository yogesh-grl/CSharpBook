using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook
{
    internal class ThreadSample
    {
        public ThreadSample()
        {
        }

        public void Method1()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Method 1 - {i}");
                Thread.Sleep(10);
            }
        }

        public void Method2()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Method 2 - {i}");
                Thread.Sleep(100);
            }
        }

        public void MainMethod()
        {
            Console.WriteLine($"Main Start");

            Thread T1 = new Thread(Method1);
            Thread T2 = new Thread(Method2);

            //T1.Priority = ThreadPriority.Highest;
            T2.IsBackground = true;

            T1.Start();
            T2.Start();

            T1.Join();
            T2.Join();

            Console.WriteLine("Main Stop");
        }
    }
}
