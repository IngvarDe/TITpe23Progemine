namespace ForeachArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "H", "e", "l", "l", "o" };

            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}