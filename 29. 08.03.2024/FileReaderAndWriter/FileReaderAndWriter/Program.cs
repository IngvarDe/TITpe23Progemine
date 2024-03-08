﻿namespace FileReaderAndWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /*
            >>>>>>>>>>
            Loo fail tuttavad.txt ja lisa sinna vähemalt 6 tuttava perekonna- 
            ja eesnimed(iga tuttav uuele reale, perekonna- ja eesnimi 
            tühikuga eraldatult). Koosta programm, mis loeb failist 
            andmed ja väljastab need ekraanile tähestikulises järjekorras.
            Mõistlik on ilmselt kasutada järjendit ja sellega
            seonduvaid võimalusi(järjestamist). Tähestikulises 
            järjekorras salvestage tuttavate nimed ka uude faili tuttavad1.txt.
            */
            ReaderAndWriter();
        }

        static void ReaderAndWriter()
        {
            try 
            {
                using (StreamReader sr = new StreamReader("C:/Users/Ingvar/Desktop/tuttavad.txt"))
                {
                    string rida = sr.ReadToEnd();
                    string[] nimed = rida.Split('\n');
                    foreach (string name in nimed)
                    {
                        Console.WriteLine(name);
                    }

                    Array.Sort(nimed);
                    //sorteerida nimed t'hestikulises j'rjestus
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Sorteeritud....");
                    foreach (string name in nimed)
                    {
                        Console.WriteLine(name);
                    }
                    sr.Close();

                    //kirjutada kogu see info failile, mille nimi on tuttavad1

                    using (StreamWriter kirjuta = new StreamWriter("C:/Users/Ingvar/Desktop/tuttavad1.txt", true))
                    {
                        int i = 1;
                        Console.WriteLine("Sorteeritud fail nimekirja");
                        foreach (string name in nimed)
                        {
                            kirjuta.WriteLine(i + " " + name);
                            i++;
                        }
                        //kirjuta.WriteLine("");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Mingi error");
                Console.WriteLine(e.Message);
            }
        }

    }
}