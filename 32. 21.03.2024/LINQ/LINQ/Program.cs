namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("1. ThenBy LINQ");
            Console.WriteLine("2. ThenBydDescending LINQ");


            Console.WriteLine("Tee valik numbrina");

            //switchi saame kutsuda esile erinevaid meetoteid
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ThenByLINQ();
                    break;

                case 2:
                    ThenByDescendingLINQ();
                    break;

                case 3:
                    SelectLINQ();
                    break;

                default:
                    Console.WriteLine("vale valik");
                    break;
            }
        }

        public static void ThenByLINQ()
        {
            //Mida teeb ThenBy
            //Sorteerib t'hestiku järjekorras
            var thenByResult = PeopleList.peoples
                .OrderBy(p => p.Name)
                .ThenBy(y => y.Age);

            Console.WriteLine("ThenBy järgi");
            foreach (var people in thenByResult)
            {
                Console.WriteLine(people.Name + " " + people.Age);
            }
        }

        //Teha järgmine meetod, kus kasutatakse ThenByDescending
        //Mida teeb ThenByDescending?
        public static void ThenByDescendingLINQ()
        {
            //Mida teeb ThenBy
            //Sorteerib t'hestiku järjekorras
            var thenByResult = PeopleList.peoples
                .OrderBy(p => p.Name)
                .ThenByDescending(y => y.Age);

            Console.WriteLine("ThenByDescending järgi");
            foreach (var people in thenByResult)
            {
                Console.WriteLine(people.Name + " " + people.Age);
            }
        }

        //tuleb teha meetod, kus kasutate LINQ Selecti
        public static void SelectLINQ()
        {
            var selectResult = PeopleList.peoples
                .Select(p => new
                {
                    Name = p.Name,
                    Age = p.Age
                });

            foreach (var people in selectResult)
            {
                Console.WriteLine(people.Name + " " + people.Age);
            }
        }
    }
}