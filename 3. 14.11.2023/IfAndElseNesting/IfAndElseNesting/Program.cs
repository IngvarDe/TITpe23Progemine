namespace IfAndElseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If ja else nesting");

            //arvuti otsib alati, et kas väärtus vastab tõele või ei vasta

            //muutuja nimega y on defineeritud e määratud
            double y;

            //andsime väärtuse
            y = 9;

            //sulgude sees olevat väärtust kontrollitakse, et kas vastab tõele või mitte
            if (y < 20)
            {
                //kui ma panen if-i sisse if-i
                if (y == 11)
                {
                    Console.WriteLine("Vastus on 11");
                }
                else
                {
                    Console.WriteLine("Vastus oli 0 kuni 10 ja 12 kuni 19");
                }
            }
            else if (y == 20.5)
            {
                Console.WriteLine("Vastus on 20.5. Teine tingimus vastab tõele");
            }
            else if(y == 30)
            {
                Console.WriteLine("Vastus on 30. Kolmas tingimus vastab tõele");
            }
            //kõik ülejäänud väärtused
            else
            {
                Console.WriteLine("Mitte ükski väärtus, mida on kirja pandud koodi");
            }
        }
    }
}