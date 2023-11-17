namespace IfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teha if ja else konsoolirakendus, kus " +
                "kontrollitakse stringi abil värvi vastavust");

            Console.WriteLine("Värvide valikuks on: red, blue, green ja white");

            Console.WriteLine("Peab käsitlema juhust, kus vastaja ei sisesta " +
                "eelpool sisestatud värvi");

            Console.WriteLine("Sisesta värv");
            string varv = Console.ReadLine();

            if (varv == "red")
            {
                Console.WriteLine("See on punane värv");
            }
            else if (varv == "blue")
            {
                Console.WriteLine("See on sinine");
            }
            else if (varv == "green")
            {
                Console.WriteLine("See on roheline");
            }
            else if (varv == "white")
            {
                Console.WriteLine("See on valge");
            }
            else
            {
                Console.WriteLine("Sisestasid suvalise värvi");
            }
        }
    }
}