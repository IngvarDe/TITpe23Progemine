namespace IaAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string muutuja = Console.ReadLine();

            if (muutuja == "")
            {
                Console.WriteLine("Ei sisestanud nime");
            }
            else
            {
                Console.WriteLine("Sisestasid enda nime: " + muutuja);
            }
        }
    }
}