namespace ForEndless
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lõputu for loop");

            //1. hakkab itereerima lõputult
            //kasutada for loopi

            //2. aga kui nr jõuab 10 peale, siis lõpetab ära
            //VIHJE: kasutage break-i
            ushort i = 0;

            for (; ; )
            {
                if (i < 10)
                {
                    Console.WriteLine("i v''rtus on: {0}", i);
                    i++;
                }
                else
                {
                    break;
                }

            }

        }
    }
}