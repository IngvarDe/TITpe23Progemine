namespace LINQAvarage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //switchiga kutsuda esile average meetod
            Console.WriteLine("Tee valik numbritega");
            Console.WriteLine("1. Average LINQ");
            Console.WriteLine("2. Count LINQ");
            Console.WriteLine("3. Sum LINQ");
            Console.WriteLine("4. Max LINQ");
            Console.WriteLine("5. Aggregate LINQ");
            Console.WriteLine("6. Min LINQ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AverageLINQ();
                    break;

                case "2":
                    CountLINQ();
                    break;

                case "3":
                    SumLINQ();
                    break;

                case "4":
                    MaxLinq();
                    break;

                case "5":
                    AggregateLinq();
                    break;

                case "6":
                    MinLinq();
                    break;
            }
        }

        public static void AverageLINQ()
        {
            Console.WriteLine("Average LINQ");

            var averageResult = PeopleList.people
                .Average(x => x.Age);

            Console.WriteLine(averageResult);
        }


        public static void CountLINQ()
        {
            var totalPersons = PeopleList.people.Count();

            Console.WriteLine("Inimesi on kokku: " + totalPersons);

            var adultPerson = PeopleList.people.Count(x => x.Age >= 18);

            Console.WriteLine("Täisealisi inimesi on: " + adultPerson);
        }


        public static void SumLINQ()
        {
            //start
            var sumAge = PeopleList.people.Sum(x => x.Age);

            Console.WriteLine(sumAge);
            Console.WriteLine("------------------------------");

            Console.WriteLine("Täisealiste isikute koondarv");

            var sumAdults = 0;

            var numAdults = PeopleList.people.Sum(x =>
                {
                    if(x.Age >= 18)
                    {
                        return 1;
                    }
                    else
                    {

                        return 0;
                    }
                });

            Console.WriteLine("T'iskasvanud isikute koondarv " + numAdults);
            //end
        }

        public static void MaxLinq()
        {
            var oldestPerson = PeopleList.people
                .Max(x => x.Age);

            Console.WriteLine("Oldest person age is " + oldestPerson);
        }

        public static void AggregateLinq()
        {
            string commaSeparatedPersonNames = PeopleList.people
                .Aggregate<People, string>(
                "People names: ",
                (str, y) => str += y.Name + ", "
                );

            Console.WriteLine(commaSeparatedPersonNames);
        }

        public static void MinLinq()
        {
            var youngestPerson = PeopleList.people
                .Min(x => x.Age);

            Console.WriteLine("Youngest person age is " + youngestPerson);
        }
    }
}