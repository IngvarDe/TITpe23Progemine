namespace IfAndElseWithColors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta nimi!");
            string name = Console.ReadLine();

            Console.WriteLine("Nimi on sisestatud ja nüüd hakkab kontroll");

            if (name != "")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.White;

                Console.WriteLine("Tere, " + name + " !");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.White;

                Console.WriteLine("Nime ei sisestatud.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
            }
        }
    }
}