namespace Massiiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //n'ide 1 Tuple
            string sentence = "Euroopa üks pealinnadest on ";
            Console.WriteLine("Tuple");
            var cities = Tuple.Create("Tallinn", "Pariis", "Rooma", "London", "Helsingi");
            //tuple all on viis erinevat väärtust ja sellepärast saab maksimaalselt 5 item-t sisestada
            Console.WriteLine(sentence + cities.Item5);
            Console.WriteLine("--------------------------------------");
            //n'ide 2 massiiv
            string[] city = { "Tallinn", "Pariis", "Rooma", "London", "Helsingi" };
            //
            for (int i = 0; i < city.Length; i++)
            {
                Console.WriteLine(sentence + city[i]);
            }
            Console.WriteLine("--------------------------------------");

            //n'ide 3
            Console.WriteLine(sentence + city[2]);
            Console.WriteLine("--------------------------------------");

            //n'ide 4
            Random number = new Random();
            int randomNumber = number.Next(0, 4);
            Console.WriteLine(sentence + city[randomNumber]);
        }
    }
}