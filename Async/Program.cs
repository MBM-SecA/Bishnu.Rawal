using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static void Main1()
        {
            // TPL - Parallel Programming
            Stopwatch stopwatch = new Stopwatch();

            int[] numbers = { 15, 6, 17, 12, 7, 5 };

            // Sequential      
            stopwatch.Start();
            Console.WriteLine("Sequential Execution:");
            foreach (var num in numbers)
            {
                var f = Factorial(num);
                Console.WriteLine($"{num}! = {f}");
            }
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds} ms");

            // Parallel
            stopwatch.Restart();
            Console.WriteLine("Parallel Execution:");
            Parallel.ForEach(numbers, num =>
            {
                var f = Factorial(num);
                Console.WriteLine($"{num}! = {f}");
            });
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds} ms");
        }
        static long Factorial(long number)
        {
            Thread.Sleep(100);
            return 0;
        }
        static void Main2()
        {
            // Making breakfast

            // Make Tea
            // - Turn on burner (2s)
            // - Place kettle on burner (3s)
            // - Pour water (5s)
            // - Let it boil (5min)
            // - Grind masalas (1min)
            // - Put sugar and masalas (5s)
            // - Pour milk(5s)
            // - Let it boil (3min)

            // - Turn on burner (2s)
            // - Put pan on and oil it (30s)
            // - Crack eggs and whisk it(3min)
            // - Fry (3min) 

            Stopwatch stopwatch = new Stopwatch();
            //Async Programming            

            stopwatch.Start();
            // Sequential version: Expected completion time = 56 sec
            TrunOnBurner();
            PutOnBurner("Kettle");
            Add("Water");
            Boil("Water");
            GrindTeaMasala();
            PutSugarAndMasala();
            Add("Milk");
            Boil("Milk");
            TrunOnBurner();
            PutOnBurner("Pan");
            AddOil();
            WhiskEggs();
            Fry();
            Serve();
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds} ms");
        }

        static async Task Main()
        {
            Stopwatch stopwatch = new Stopwatch();
            //Async Programming            

            stopwatch.Start();
            // Sequential version: Expected completion time = 56 sec
            Task turnOnBurner1 = TrunOnBurner();
            Task PutOnKettle = PutOnBurner("Kettle");
            Task addWater = Add("Water");
            Task boilWater = Boil("Water");
            Task gridTeaMasala = GrindTeaMasala();
            Task addSugarAndMasala = PutSugarAndMasala();
            Task addMilk = Add("Milk");
            Task boilMilk = Boil("Milk");
            Task turnOnBurner2 = TrunOnBurner();
            Task putOnPan = PutOnBurner("Pan");
            Task addOil = AddOil();
            Task whiskEggs = WhiskEggs();
            Task fry = Fry();
            Task serve = Serve();

            await turnOnBurner1;
            Console.WriteLine("Turning on gas");

            await PutOnKettle;
            Console.WriteLine("Putting kettle on stove");

            await addWater;
            Console.WriteLine("Adding water on kettle");

            await boilWater;
            Console.WriteLine("Boiling water");

            await gridTeaMasala;
            Console.WriteLine("Grindng masalas");

            await addSugarAndMasala;
            Console.WriteLine("adding sugar and masalas");

            await addMilk;
            Console.WriteLine("Added milk");

            await boilMilk;
            Console.WriteLine("Boiled milk");

            await turnOnBurner2;
            Console.WriteLine("Turned on anothe burner");

            await putOnPan;
            Console.WriteLine("Put pan on burner 2");

            await addOil;
            Console.WriteLine("Added oil on pan");

            await whiskEggs;
            Console.WriteLine("Cracked and mixed eggs");

            await fry;
            Console.WriteLine("Fried eggs");

            await serve;
            Console.WriteLine("Serving");

            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds} ms");
        }

        private static async Task Serve()
        {
            await Task.Delay(5000);
        }

        private static async Task Fry()
        {
            await Task.Delay(10000);
        }

        private static async Task WhiskEggs()
        {
            await Task.Delay(10000);
        }

        private static async Task AddOil()
        {
            await Task.Delay(2000);
        }

        private static async Task PutSugarAndMasala()
        {
            await Task.Delay(2000);
        }

        private static async Task GrindTeaMasala()
        {
            await Task.Delay(5000);
        }

        private static async Task Boil(string item)
        {
            await Task.Delay(10000);
        }

        private static async Task Add(string item)
        {
            await Task.Delay(2000);
        }

        private static async Task PutOnBurner(string pot)
        {
            await Task.Delay(3000);
        }

        private static async Task TrunOnBurner()
        {
            await Task.Delay(2000);
        }
    }
}
