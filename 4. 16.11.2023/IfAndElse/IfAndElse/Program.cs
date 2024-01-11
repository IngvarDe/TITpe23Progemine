namespace IfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teha if ja else konsoolirakendus");

            int arv = 189;
            //muutuja arv on täisarv ja võrdub 20

            //kontrollitakse, kas arv on suurem, kui 189
            if (arv > 189)
            {
                //kui vastab if tingimusele, siis näiab konsoolis seda arvu
                Console.WriteLine("number on suurem");

                //hakkab if ja else nestimine
                if (arv > 190 && arv < 200)
                {
                    Console.WriteLine("Arv on 190 ja 200 vahel");
                }
                else
                {
                    Console.WriteLine("Arv on suurem, kui 200");
                }
            }
            //kui muutuja arv on väiksem, kui 189, siis kuvab allpool olevat stringi
            else
            {
                Console.WriteLine("number on väiksem");
            }
        }
    }
}