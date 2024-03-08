namespace FileWordReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Luuletus");

            FileWordReading();
        }

        static void FileWordReading()
        {
            string line; //s]na muutuja deklareerimine
            try
            {
                using (StreamReader sr = new StreamReader("C:/Users/Ingvar/Desktop/luuletus.txt"))
                {
                    int cnt = 0; //rea muutuja
                    while (sr.EndOfStream == false)
                    {
                        ++cnt; // rea nr suurendamine 1 [hiku v]rra
                        line = sr.ReadLine(); //teksti lugemine txt failist
                        int pikkus = line.Length; //s]na lugemine, kui s]ne pikkusena
                        Console.WriteLine(cnt + " " + line + " " + pikkus); //kogu
                    }
                    sr.Close(); //faili lugemise l]petamine
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Faili ei saa lugeda");
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}