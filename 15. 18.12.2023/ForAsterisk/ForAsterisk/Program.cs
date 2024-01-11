namespace ForAsterisk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta tärnide arv ->");

            //saab sisestada tärnide arvu
            //ja kuvab neid ühes reas
            //kasutada for loopi

            int nr = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < nr; i++)
            {
                Console.Write("*");
            }

        }
    }
}