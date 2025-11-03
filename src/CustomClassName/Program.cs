namespace CustomClassName
{
    internal class MyApplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example 10: Custom Class Name");
            Console.WriteLine("Class name: MyApplication (not Program)");
            Console.WriteLine("The class name can be anything you want!");
            
            Console.WriteLine($"\nCurrent class: {nameof(MyApplication)}");
            Console.WriteLine($"Namespace: {typeof(MyApplication).Namespace}");
        }
    }
}
