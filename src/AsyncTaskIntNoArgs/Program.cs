using System;
using System.Threading.Tasks;

namespace AsyncTaskIntNoArgs
{
    internal class Program
    {
        static async Task<int> Main()
        {
            Console.WriteLine("Example 7: static async Task<int> Main()");

            try
            {
                Console.WriteLine("Starting async operation...");
                await Task.Delay(1000);

                int result = await CalculateAsync();
                Console.WriteLine($"Calculation result: {result}");
                Console.WriteLine("Success!");

                return 0; // Success
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error: {ex.Message}");
                return 1; // Failure
            }
        }

        static async Task<int> CalculateAsync()
        {
            await Task.Delay(500);
            return 42;
        }
    }
}
