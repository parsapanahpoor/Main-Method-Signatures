namespace PublicAccessModifier
{
    public class Program
    {
        public static int Main(string[] args)
        {
            Console.WriteLine("Example 11: Public Access Modifier");
            Console.WriteLine("Both class and Main method are public");
            Console.WriteLine("(Usually internal or private, but public is valid)");
            
            Console.WriteLine($"\nClass is public: {typeof(Program).IsPublic}");
            Console.WriteLine("Method is public: true");
            
            return 0;
        }
    }
}
