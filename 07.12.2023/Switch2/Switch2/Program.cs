namespace Switch2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number string andmetüübina");

            string number = Console.ReadLine();

            //case 1 ja case 2 puhul on üks ja sama väljund
            //kus annab vastuseks: Valisid 1 või 2
            //Ülejäänud juhtumid annab vastuseks:
            //Valisid midagi muud
            switch (number)
            {
                case "1":
                case "2":
                    Console.WriteLine("Valisid 1 või 2");
                    break;

                default: 
                    Console.WriteLine("Valisid midagi muud");
                    break;
            }

        }
    }
}