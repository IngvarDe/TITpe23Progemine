﻿namespace InheritanceVINCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance");
            //Teha pärilus
            //On olemas class nimega Machine
            //See pärib Cars classi
            //Saab sisestada masina numbri 
            //konsool annab vastuse: Edukalt sisestatud
            // VIN kood: VIN koodi nr
            Console.WriteLine("Enter VIN code:");
            int vinCode = Convert.ToInt32(Console.ReadLine());

            Machine machine = new Machine();
            machine.SetVinCode(vinCode);

            Console.WriteLine("Vin code is: " + machine.GetVinCode());


        }
    }

    class Car
    {
        public void SetVinCode(int vinCode) 
        {
            vin = vinCode;
        }

        protected int vin;
    }

    class Machine : Car
    {
        public int GetVinCode()
        {
            return vin;
        }
    }
}