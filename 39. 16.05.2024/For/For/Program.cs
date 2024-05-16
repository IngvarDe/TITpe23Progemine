namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //teha uus meetod for loopi jaoks
            //sinna meetodi sisse teha for loopi tsükkel
            //For loopist peab saama teha maja kuju
            //maja suuruse saab valida
            House();
        }

        static void House()
        {
            int suurus = Convert.ToInt32(Console.ReadLine());
            string n = "";
            string n2 = "";
            int n1 = suurus;
            for (int i = 0; i < suurus; i++)
            {
                for (int j = 0; j < n1; j++)
                {
                    n += " ";
                }
                n1--;
                Console.WriteLine(n + "*" + n2 + n2);
                n2 += "*";
                n = "";

            }
            for (int i = 0; i < suurus; i++)
            {
                for (int j = 0; j < suurus * 2 + 1; j++)
                {
                    string n3 = "*";
                    if (i > suurus / 3)
                    {
                        if (j > (suurus * 2 + 1) / 6 && j < (suurus * 2 + 1) / 2 || (i < suurus / 1.5 && j > (suurus * 2 + 1) / 1.75 && j < (suurus * 2 + 1) / 1.2))
                        {
                            n3 = " ";
                        }
                        else
                        {
                            n3 = "*";
                        }
                    }
                    Console.Write(n3);
                }
                Console.WriteLine();
            }
        }
    }
}