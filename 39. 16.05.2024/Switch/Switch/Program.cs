namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");
            Console.WriteLine("1. SwitchMethod");
            //Teha switch rakendus
            //Kokku on kolm case
            //Teema valite ise

            //teete uue meetodi
            //tõstate kogu switchi osa sinna ümber
            //main meetodis kutsute if ja else-ga selle meetodi välja
            int number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                SwitchMethod();
            }
            else
            {
                Console.WriteLine("vale valik");
            }


        }

        static void SwitchMethod()
        {
            Console.WriteLine("Tee valik 1-st kuni 3-ni");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("esimene");
                    break;
                case 2:
                    Console.WriteLine("teine");
                    break;
                case 3:
                    Console.WriteLine("kolmas");
                    break;

                default:
                    Console.WriteLine("end");
                    break;
            }
        }
    }
}