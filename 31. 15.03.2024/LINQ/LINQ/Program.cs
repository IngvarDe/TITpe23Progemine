namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kutsume esile LINQ läbi switchi");
            Console.WriteLine("Vali vastav link numbriga");
            Console.WriteLine("1. Where");

            int choice = int.Parse(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    WhereLINQ();

                    break;

                default:
                    Console.WriteLine("Valikut ei tehtud");
                    break;
            }
        }

        public static void WhereLINQ()
        {
            var peopleAge = PeopleList.peoples
                .Where(x => x.Age > 20 && x.Age < 23);

            foreach (var people in peopleAge)
            {
                Console.WriteLine(people.Name);
            }
        }

        public static void WhereByNameLINQ()
        {
            Console.WriteLine("Kirjuta inimese nimi:");
            string name = Console.ReadLine();

            var peopleAge = PeopleList.peoples
                .Where(x => x.Name == name);

            foreach (var people in peopleAge)
            {
                Console.WriteLine(people.Name);
            }
        }

        //nime p]hjal teha filtreerimine ja kasutada where
        //kutsuda see meetod esile Main meetodi switchi sees

        public static void ThenByLINQ()
        {

        }

    }
}