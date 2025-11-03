namespace IntNoArgs
{
    internal class Program
    {
        static int Main()
        {
            Console.WriteLine("Example 3: static int Main()");
            Console.WriteLine("Returns explicit exit code");
            
            try
            {
                Console.WriteLine("Performing some operation...");
                Console.WriteLine("Operation completed successfully!");
                return 0; // Success
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error: {ex.Message}");
                return 1; // Failure
            }
        }
    }
}
