namespace SwitchMethodCalling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Teha swicth rakendus, kus on mitu
            //case-i meetodi välja kutsumiseks

            string carTypes = Console.ReadLine();

            switch (carTypes)
            {
                case "coupe":
                    CarCoupe(); //meetodi v'lja kutsumine
                    break;

                case "truck":
                    Truck();//meetodi v'lja kutsumine
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }

        static void CarCoupe() //uus meetod nimega CarCoupe()
        {
            Console.WriteLine("You have a coupe car"); //meetodi sisu
        }

        static void Truck()
        {
            Console.WriteLine("You have a truck");
        }
    }
}