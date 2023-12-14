namespace SulgudeKasutamine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sulgude kasutamine!");
            Console.WriteLine("Kui palju on: 3 + 8 / (4 - 2) * 4 = ?");

            double calculation1 = 3 + 8 / (4 - 2) * 4;
            double calculation2 = 3 + 8 / 4 - 2 * 4;
            double calculation3 = (3 + 8) / (4 - 2) * 4;
            double calculation4 = 3 + 8 / ((4 - 2) * 4);

            Console.WriteLine("Vastus: " + calculation1);
            Console.WriteLine("Vastus: " + calculation2);
            Console.WriteLine("Vastus: " + calculation3);
            Console.WriteLine("Vastus: " + calculation4);
        }
    }
}