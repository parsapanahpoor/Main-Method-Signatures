using System;
using System.Threading.Tasks;

namespace AsyncTaskNoArgs
{
    internal class Program
    {
        static async Task Main()
        {
            Console.WriteLine("Example 5: static async Task Main()");
            Console.WriteLine("Performing async operation...");

            await Task.Delay(1000);
            Console.WriteLine("Async operation completed!");

            // Simulating async web request
            await FetchDataAsync();
        }

        static async Task FetchDataAsync()
        {
            Console.WriteLine("Fetching data...");
            await Task.Delay(500);
            Console.WriteLine("Data received: Sample Data");
        }
    }
}
