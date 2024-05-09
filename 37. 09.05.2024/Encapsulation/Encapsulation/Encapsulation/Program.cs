using Encapsulation.Service;


namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kapseldamine");

            Student student = new Student();

            //ei saa kasutada kuna asub teises libarys e teegis
            //Student2 student = new Student2();

            student.Id = 101;
            student.Name = "Test";
            student.Email = "Test@Test.com";

            Console.WriteLine("Id = " + student.Id);
            Console.WriteLine("Name = " + student.Name);
            Console.WriteLine("Email = " + student.Email);


            //kasutame Protected klassi
            ProtectedStudent protectedStudent = new ProtectedStudent();
            //protectedStudent.DoSomething();
            //kui DoSomething on protected ja teises classis,
            //siis ei saa seda kasutada

            Console.WriteLine("------------------");
            Program program = new Program();
            program.DoSomethingInProgramClass();

            Console.WriteLine("---------Private Protected---------");
            Program pp = new Program();
            Console.WriteLine(pp.privateProtectedInProgramClass
                = "privateProtectedInProgramClassMainMethod");

            //ei saa kasutada kuna on private protected tasemel
            var privateProtectedStudent = new PrivateProtectedStudent();
            //alumine rida annab errorit
            //privateProtectedStudent.PrivateProtectedStudent1 = "asdasdasd";

            Console.WriteLine("---------Sealed Class---------");
            //sealed classi kasutamine
            var sc = new SealedStudent();
            sc.Id = 123;
            sc.Name = "Test";
            sc.Email = "Test@test.com";
            Console.WriteLine($"Id on {sc.Id}, Name on {sc.Name} ja Email on {sc.Email}");

        }

        protected void DoSomethingInProgramClass()
        {
            Console.WriteLine("DoSomethingInProgramClass");
        }

        private protected string privateProtectedInProgramClass =
            "privateProtectedInProgramClass";
    }
}