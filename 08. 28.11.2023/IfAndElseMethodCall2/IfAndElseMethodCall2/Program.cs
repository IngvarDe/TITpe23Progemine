namespace IfAndElseMethodCall2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");

            string nr = Console.ReadLine();
            int number = Convert.ToInt32(nr);

            if (number %2 == 0)
            {
                //siia tuleb kutsuda esile meetod, kus on kirjas: sisestasid paaris arvu
                EvenNumber();
            }
            else
            {
                //siia tuleb kutsuda esile meetod, kus on kirjas: sisestasid paaritu arvu
                OddNumber();
            }
        }

        static void EvenNumber()
        {
            Console.WriteLine("Tegemist on paaris numbriga");
        }

        static void OddNumber()
        {
            Console.WriteLine("Tegemist on paaritu numbriga");
        }
    }
}