using System;

namespace Exercise3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double startkapital;
            double zinssatz;
            double endkapital;

            Console.WriteLine("Gib das Startkapital ein:");
            startkapital = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Gib den Zinssatz in Prozent ein:");
            zinssatz = Convert.ToDouble(Console.ReadLine());

            endkapital = startkapital * Math.Pow(1 + zinssatz / 100.0, 3);

            Console.WriteLine("Das Endkapital beträgt: " + endkapital);
        }
    }
}
