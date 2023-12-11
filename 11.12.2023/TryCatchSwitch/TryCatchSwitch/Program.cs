namespace TryCatchSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Try ja Catch";
            Console.WriteLine("Sisesta number");

            //string number = Console.ReadLine();
            int nr = int.Parse(Console.ReadLine());

            try
            {
                switch (nr)
                {
                    case 1:
                        Console.WriteLine("Sisestasid nr 1");
                        break;

                    case 2:
                        Console.WriteLine("Sisestasid nr 2");
                        break;

                    default:
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ei sisestanud numbri formaati");
            }
            catch (OverflowException)
            {
                Console.WriteLine("ERROR. Sisestatud number on liiga suur");
            }
        }
    }
}