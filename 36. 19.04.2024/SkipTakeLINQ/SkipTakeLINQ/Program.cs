namespace SkipTakeLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tee valik");
            Console.WriteLine("1. Skip");
            Console.WriteLine("2. SkipWhile");
            Console.WriteLine("3. Take");
            Console.WriteLine("4. TakeWhile");
            Console.WriteLine("5. FirstOrDefault");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Skip();
                    break;

                case "2":
                    SkipWhile();
                    break;
                case "3":
                    Take();
                    break;
                case "4":
                    TakeWhile();
                    break;
                case "5":
                    FirstOrDefault();
                    break;
            }

        }

        public static void Skip()
        {
            Console.WriteLine("\n\n----------------Skip------------");
            var skip = PeopleList.people.Skip(3);

            foreach (var item in skip)
            {
                Console.WriteLine(item.Id);
            }
        }

        public static void SkipWhile()
        {
            Console.WriteLine("\n\n----------------SkipWhile------------");
            var skip = PeopleList.people.SkipWhile(x => x.Age > 18);

            foreach (var item in skip)
            { 
                Console.WriteLine(item.Id + " " + item.Name); 
            }
        }

        public static void Take()
        {
            Console.WriteLine("\n\n----------------Take------------");
            //n'itab kolme esimest

            var take = PeopleList.people.Take(3);

            foreach (var item in take)
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }
        }

        public static void TakeWhile()
        {
            Console.WriteLine("\n\n----------------TakeWhile------------");

            var takeWhile = PeopleList.people.TakeWhile(x => x.Age > 18);

            foreach (var item in takeWhile)
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }
        }

        public static void FirstOrDefault()
        {
            string firstLongName = PeopleList.people
                .FirstOrDefault(person => person.Name.Length > 5)?.Name;

            Console.WriteLine("The first long name is '{0}'.", firstLongName);
        }
    }
}