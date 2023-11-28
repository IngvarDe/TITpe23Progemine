namespace IfAndElseEvenAndOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta nr!");
            //konsool küsib nr ja siin muudetakse see int andmetüübiks
            string nr = Console.ReadLine();
            int number = int.Parse(nr);

            //teha if ja else-ga kontroll, kus saame teada, et kas nr on paaris või paaritu
            if (number %2 == 0 )
            {
                Console.WriteLine("Sisestasid paaris arvu: " + number);
            }
            else
            {
                Console.WriteLine("Sisestasid paaritu arvu: " + number);
            }
        }
    }
}