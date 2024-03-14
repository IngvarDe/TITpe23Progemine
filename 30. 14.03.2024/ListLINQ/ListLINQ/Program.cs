namespace ListLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List and LINQ!");

            IList<Person> person = new List<Person>()
            {
                new Person() {Id = 1, Name = "Juku", Age = 10},
                new Person() {Id = 2, Name = "Juhan", Age = 11},
                new Person() {Id = 3, Name = "Maali", Age = 9},
                new Person() {Id = 4, Name = "Aksel", Age = 10},
            };

            var persons = from s in person
                          select new
                          {
                              Id = s.Id,
                              Name = s.Name,
                              Age = s.Age,
                          };

            //kasutada foreachi ja peab n'gema 4 rida andmeid
            foreach (var item in persons)
            {
                Console.WriteLine("Id on " + item.Id + " ja nimi on " + item.Name);
            }

            Console.WriteLine("LINQ Select e teine variant teha LINQ päringut");

            var result = person
                //.Where(p => p.Id == 1) //saan t'psemat otsingut teha, kui tahan ainult Id 1 isikut saada
                //.Where(p => p.Id == 1 || p.Age == 9) //näen ainult Id 1-ga isikut ja kellel on vanus 9 a
                .OrderBy(p => p.Name) //järjestab isikud nime järgi ära
                .Select(x => new
                {
                    Id = x.Id,
                    Name = x.Name,
                    Age = x.Age
                });

            foreach (var item in result)
            {
                Console.WriteLine("Id on " + item.Id + " ja nimi on " + item.Name);
            }

            Console.WriteLine("Kasutame GroupBy-d sorteerimiseks");

            var groupBy = person
                .GroupBy(x => x.Age);
            //kuvab gruppide kaupa ja antud juhul paneb vanused gruppidese
            // e tulemuseks on kolm rida andmeid kuna kaks isikut on 9 a

            foreach (var item in groupBy)
            {
                Console.WriteLine("Vanuse grupp on: {0}", item.Key);
            }
        }
    }
}