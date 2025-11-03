namespace AsyncTaskWithArgs
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Example 6: static async Task Main(string[] args)");
            
            int delay = 1000;
            if (args.Length > 0 && int.TryParse(args[0], out int customDelay))
            {
                delay = customDelay;
            }
            
            Console.WriteLine($"Waiting for {delay}ms...");
            await Task.Delay(delay);
            Console.WriteLine("Wait completed!");
            
            await ProcessDataAsync(args);
        }
        
        static async Task ProcessDataAsync(string[] data)
        {
            Console.WriteLine("Processing data asynchronously...");
            await Task.Delay(500);
            Console.WriteLine($"Processed {data.Length} items");
        }
    }
}
