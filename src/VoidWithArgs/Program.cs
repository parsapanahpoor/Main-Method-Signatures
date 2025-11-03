namespace VoidWithArgs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example 2: static void Main(string[] args)");
            Console.WriteLine($"Number of arguments: {args.Length}");
            
            if (args.Length > 0)
            {
                Console.WriteLine("Arguments received:");
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine($"  args[{i}] = {args[i]}");
                }
            }
            else
            {
                Console.WriteLine("No arguments provided");
                Console.WriteLine("Try: dotnet run -- arg1 arg2 arg3");
            }
        }
    }
}
