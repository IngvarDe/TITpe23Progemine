namespace SwitchWithNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number ja vajuta enter");
            //Teie töö on teha switch rakendus,
            //kus on kolm case (1, 2, 3).
            //Iga case puhul teeb erinev arv beep-e
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1: 
                    Console.Beep();
                    Console.WriteLine("1");
                    break;

                case 2:
                    Console.Beep();
                    Console.Beep();
                    Console.WriteLine("2");
                    break;

                case 3:
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.WriteLine("3");
                    break;

                default: 
                    Console.WriteLine("Mingi muu number");
                    break;
            }
        }
    }
}