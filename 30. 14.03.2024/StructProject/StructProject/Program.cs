namespace StructProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Struct");

            Coordinate point = new Coordinate();
            Console.WriteLine(point.X);
            Console.WriteLine(point.Y);

            Console.WriteLine("-----------------------------");
            InsertedIntANdTallinn insertedIntANdTallinn = new();
            Console.WriteLine(insertedIntANdTallinn.PostalCode);
            Console.WriteLine(insertedIntANdTallinn.City);

        }
    }

    struct Coordinate
    {
        public int X;
        public int Y;

        //konstruktor teha
        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    struct IntAndString
    {
        public string Name;
        public int Age;

        public IntAndString(string name, int age)
        {
            //teha see korda
            Name = name;
            Age = age;
        }
    }

    struct InsertedIntANdTallinn
    {
        public int PostalCode;
        public string City;

        public InsertedIntANdTallinn()
        {
            PostalCode = 11;
            City = "Tallinn";
        }
    }
}