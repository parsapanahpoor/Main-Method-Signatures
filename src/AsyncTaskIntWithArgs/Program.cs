using System;
using System.Threading.Tasks;

namespace AsyncTaskIntWithArgs
{
    internal class Program
    {
        static async Task<int> Main(string[] args)
        {
            Console.WriteLine("Example 8: static async Task<int> Main(string[] args)");

            if (args.Length == 0)
            {
                Console.Error.WriteLine("Error: Please provide a URL");
                Console.WriteLine("Usage: dotnet run -- <url>");
                return 1;
            }

            string url = args[0];

            try
            {
                await DownloadAsync(url);
                Console.WriteLine("Download completed successfully!");
                return 0; // Success
            }
            catch (HttpRequestException ex)
            {
                Console.Error.WriteLine($"Network error: {ex.Message}");
                return 2; // Network error
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error: {ex.Message}");
                return 99; // General error
            }
        }

        static async Task DownloadAsync(string url)
        {
            Console.WriteLine($"Downloading from: {url}");
            await Task.Delay(1500); // Simulate download
            Console.WriteLine("Download finished");
        }
    }
}
