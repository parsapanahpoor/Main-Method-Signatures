// Example 13: Top-Level Statements (C# 9+)
// No class, no Main method needed!
// Compiler automatically generates: static void Main(string[] args)

Console.WriteLine("Example 13: Top-Level Statements");
Console.WriteLine("No explicit class or Main method!");
Console.WriteLine("This is the modern C# way (C# 9+)");

// You can still access args
if (args.Length > 0)
{
    Console.WriteLine($"\nArguments received: {string.Join(", ", args)}");
}

// You can use await directly
await Task.Delay(1000);
Console.WriteLine("\nAsync operation completed!");

// You can return an exit code
if (args.Length > 5)
{
    Console.Error.WriteLine("Too many arguments!");
    return 1;
}

return 0; // Success
