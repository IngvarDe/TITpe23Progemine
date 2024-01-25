namespace MethodCall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            SayHello();
            SayGoodbye();
        }
        //kutsuda meetod SayHello ja Goodbye välja
        static void SayHello()
        {
            Console.WriteLine("Hello");
        }

        static void SayGoodbye()
        {
            Console.WriteLine("Goodbye");
        }
    }
}