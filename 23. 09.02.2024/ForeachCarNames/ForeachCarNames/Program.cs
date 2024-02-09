namespace ForeachCarNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kuvada konsoolis nelja auto nime ja " +
                "kasutada foreachi");

            string[] cars = {"Volvo", "BMW", "Ford", "Mazda" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}