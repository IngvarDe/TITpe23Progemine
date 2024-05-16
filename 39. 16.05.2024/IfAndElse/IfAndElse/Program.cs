using System.Threading.Channels;

namespace IfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta arv");

            int number = int.Parse(Console.ReadLine());

            if (number < 5)
            {
                Console.WriteLine("Number on ühe kuni viie vahel");
            }
            else
            {
                Console.WriteLine("Number on viiest suurem");
            }
        }
    }
}