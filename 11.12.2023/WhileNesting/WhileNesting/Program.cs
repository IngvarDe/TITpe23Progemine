namespace WhileNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While nesting");

            int a = 1;
            //kasutada while while sees

            while (a <= 5)
            {
                int b = 1;
                while(b <= 5)
                {
                    Console.Write(b + " ");
                    b++;
                }
                Console.WriteLine();
                a++;
            }

            Console.ReadKey();
        }
    }
}