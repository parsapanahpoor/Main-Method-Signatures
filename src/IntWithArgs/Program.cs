namespace IntWithArgs
{
    internal class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Example 4: static int Main(string[] args)");
            
            if (args.Length == 0)
            {
                Console.Error.WriteLine("Error: No arguments provided");
                Console.WriteLine("Usage: dotnet run -- <number>");
                return 1; // Error code: Missing arguments
            }
            
            if (!int.TryParse(args[0], out int number))
            {
                Console.Error.WriteLine($"Error: '{args[0]}' is not a valid number");
                return 2; // Error code: Invalid input
            }
            
            if (number < 0)
            {
                Console.Error.WriteLine("Error: Number must be positive");
                return 3; // Error code: Invalid value
            }
            
            Console.WriteLine($"Processing number: {number}");
            Console.WriteLine($"Square: {number * number}");
            return 0; // Success
        }
    }
}
