namespace ForKillKoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Eelnevaid teadmisi kasutades kirjuta programm, mis väljastaks:
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //VIHJE: for loop for loopi sees

            string arv = Console.ReadLine();
            int arvS = int.Parse(arv);

            for (int i = 0; i < arvS; i++)
            {

                Console.WriteLine("See on rida nr {0}", i);
                string a = "kill-koll";
                string b = "killadi-koll";

                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(a);
                }

                for (int k = 1; k < 2; k++)
                {
                    Console.WriteLine(b);
                }    
            }
            Console.WriteLine("kill - koll");
        }
    }
}