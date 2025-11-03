namespace ParamsModifier
{
    internal class Program
    {
        static void Main(params string[] args)
        {
            Console.WriteLine("Example 9: static void Main(params string[] args)");
            Console.WriteLine("Using 'params' modifier (rarely used but valid)");
            
            Console.WriteLine($"Arguments count: {args.Length}");
            
            if (args.Length > 0)
            {
                Console.WriteLine("Arguments:");
                foreach (var arg in args)
                {
                    Console.WriteLine($"  - {arg}");
                }
            }
            else
            {
                Console.WriteLine("No arguments provided");
            }
        }
    }
}
