namespace NumberIfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number12 = 0;

            Console.WriteLine("Kirjuta enda vanus");
            //konsoolis on ainult string andmetüüp
            //see tuleb muuta int-ks ja Convert.ToInt16 saab seda teha
            
            //siin on viga
            string number = Console.ReadLine();
            //number12 = Convert.ToInt32(number);

            if (number != null && number != "")
            {
                //+ number tähendab seda, et lisab teksti järele sisestatud numbri
                Console.WriteLine("Sisestasid enda vanuse: " + number);
            }
            //ei sisesta mitte ühtegi numbrit ja saan kirja:
            //Ei sisestanud enda vanust
            else
            {
                Console.WriteLine("Ei sisestanud enda vanust");
            }
        }
    }
}