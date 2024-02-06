namespace ForLoopMultiplicationTabel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta number, et kui pikk peaks olema korrutustabel");
            Console.WriteLine("-----------------------------------------------------");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Korrutustabel 1 kuni {0}", n);

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j <= n - 1)
                    {
                        Console.Write("{0}x{1} = {2}; ", j, i, i * j);
                    }
                    else
                    {
                        Console.WriteLine("{0}x{1} = {2}; ", j, i, i * j);
                    }
                    //Console.Write("\n");
                }
                Console.Write("\n");
            }
        }
    }
}