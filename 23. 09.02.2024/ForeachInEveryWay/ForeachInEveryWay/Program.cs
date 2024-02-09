namespace ForeachInEveryWay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Tuleb teha rakendus, kus on list
            //ja seal sees on 5 string väärtust.
            //Need omakorda tuleb kuvada konsoolis
            //ning kasutada foreachi.
            //see tuleb l'bi meetodi esile kutsuda ja
            //sina saad valida, et kumba meetodi kasutada

            //2 harjutus. Kasutate foreachi listi
            //kuvamisel, aga kui jõuab kolmanda 
            //nimeni, siis lõpetab loopi.

            Console.WriteLine("Foreach harjutused");
            Console.WriteLine("1. List, kus on foreach");
            Console.WriteLine("2. List, kus on foreach ja break");
            //kui valin nr 1, siis allpool
            //olev meetod kutsutakse esile
            int choice = Convert.ToInt16(Console.ReadLine());

            if (choice == 1 )
            {
                ForeachWithList();
            }
            else if (choice == 2 )
            {
                ForeachWithBreak();
            }
            
        }

        static void ForeachWithList() 
        { 
            var names = new List<string>()
            {"John", "Tom", "Anu", "Villu", "James"};

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void ForeachWithBreak()
        {
            var names = new List<string>()
            {"John", "Tom", "Anu", "Villu", "James"};

            foreach (var name in names)
            {
                if (name == "Anu")
                {
                    break;
                }
                Console.WriteLine(name);
            }
        }

    }
}