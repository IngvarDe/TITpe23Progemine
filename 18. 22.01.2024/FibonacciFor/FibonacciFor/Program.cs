namespace FibonacciFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prv = 0, pre = 1, trm, i, n;  

            Console.Write("\n\n");
            Console.Write("Display the first n terms of Fibonacci series:\n");
            Console.Write("------------------------------------------------\n\n");
            Console.Write("Input number of terms to be displayed: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Here is the Fibonacci series up to {0} terms: \n", n);

            Console.Write("{0}    {1}", prv, pre);

            for (i = 3; i <= n; i++)
            {
                trm = prv + pre;
                Console.Write("  {0}  ", trm);
                prv = pre;
                pre = trm;
            }
            Console.Write("\n");
        }
    }
}