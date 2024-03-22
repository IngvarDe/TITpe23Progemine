namespace LINQGroupBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //meetodi v'lja kutsumine
            GroupByLINQ();
        }

        static void GroupByLINQ()
        {
            //start
            var result = PeopleList.peoples
                .GroupBy(x => x.Age);

            foreach (var age in result)
            {
                Console.WriteLine("Age group " + age.Key);

                foreach (var p in age)
                {
                    Console.WriteLine("People name: " + p.Name);
                }
            }
            //end
        }

        static void ToLookUpLINQ()
        {
            var result = PeopleList.peoples
                .ToLookup(x => x.Age);

            foreach(var age in result)
            {
                Console.WriteLine("Age group: " + age.Key);

                foreach(var p in age)
                {
                    Console.WriteLine("Person name " + p.Name);
                }
            }
        }

        //teete ToLookup jaoks uue meetodi
        //kutsute selle esile Main meetodis
    }
}