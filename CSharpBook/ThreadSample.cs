using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook
{
    internal class ThreadSample
    {
        static Mutex mutex = new Mutex();
        static Semaphore semaphore = new Semaphore(2, 2);
        public ThreadSample()
        {
        }

        public void Method1()
        {
            try
            {
                mutex.WaitOne();
                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine($"Method 1 - {i}");
                    Thread.Sleep(10);
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                mutex.ReleaseMutex();
            }
        }

        public void Method2()
        {
            try
            {
                semaphore.WaitOne();
                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine($"Method 2 - {i}");
                    Thread.Sleep(100);
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                semaphore.Release();
            }

        }

        public void Method3(object data)
        {
            Console.Write(data);
        }

        public void MainMethod()
        {
            Console.WriteLine($"Main Start");

            Thread T1 = new Thread(Method1);
            Thread T2 = new Thread(Method2);

            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(Method3);
            Thread T3 = new Thread(parameterizedThreadStart);

            //T1.Priority = ThreadPriority.Highest;
            T2.IsBackground = true;

            T1.Start();
            T2.Start();
            T3.Start("SampleData");

            T1.Join();
            T2.Join();

            Console.WriteLine("Main Stop");
        }
    }
}
