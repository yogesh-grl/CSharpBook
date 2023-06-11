using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook
{

    internal class AsyncAwaitExample
    {
        public AsyncAwaitExample() { }

        public void PrepareCoffee()
        {
            Console.WriteLine("Coffee Preparation Start....");

            Thread.Sleep(5000);

            Console.WriteLine("Coffee Ready!");
        }
        public void CutVegetables()
        {
            Console.WriteLine("Veg Cutting Start....");

            Thread.Sleep(3000);

            Console.WriteLine("Veg Ready!");
        }
        public void CookRice()
        {
            Console.WriteLine("Rice Cooking Start....");

            Thread.Sleep(2000);

            Console.WriteLine("Rice Ready!");
        }
        public void PrepareCurry()
        {
            Console.WriteLine("Curry Preparation Start....");

            Thread.Sleep(5000);

            Console.WriteLine("Curry Ready!");
        }
        public void NormalCooking()
        {
            var time = System.Diagnostics.Stopwatch.StartNew();

            PrepareCoffee();
            CutVegetables();
            CookRice();
            PrepareCurry();

            time.Stop();

            Console.WriteLine($"Total Time {time.ElapsedMilliseconds}");
            Console.ReadLine();
        }


        public async Task CutVegAsync()
        {
            Console.WriteLine("Veg Cutting Start....");

            Thread.Sleep(3000);

            Console.WriteLine("Veg Ready!");
        }

        public async Task CookRiceAsync()
        {
            Console.WriteLine("Rice Cooking Start....");

            Thread.Sleep(2000);

            Console.WriteLine("Rice Ready!");
        }

        public async Task PrepareCurryAsync()
        {
            Console.WriteLine("Curry Preparation Start....");

            Thread.Sleep(5000);

            Console.WriteLine("Curry Ready!");
        }


        public async Task AsyncCooking()
        {
            var time = System.Diagnostics.Stopwatch.StartNew();

            PrepareCoffee();
            Task vegCuttingTask = Task.Run(() => CutVegAsync());
            Task cookRiceTask = Task.Run(() => CookRiceAsync());
            await PrepareCurryAsync();

            time.Stop();

            Console.WriteLine($"Total Time {time.ElapsedMilliseconds}");
            Console.ReadLine();
        }
        public void MainMethod()
        {
            Console.WriteLine("Normal Cooking");
            NormalCooking();

            Console.WriteLine("Async Cooking");
            AsyncCooking();
        }
    }
}
