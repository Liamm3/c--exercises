using System;

namespace Exercise8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            CKonto einKonto = new CKonto();
            einKonto.NUMMER = "174562322";
            einKonto.SALDO = 50;

            Console.WriteLine(einKonto);

            Console.WriteLine("250 Euro einzahlen:");
            einKonto += 250;
            Console.WriteLine(einKonto);
            Console.WriteLine();

            Console.WriteLine("30 Euro abheben:");
            einKonto -= 30;

            double s = (double)einKonto;
            Console.WriteLine("Das Saldo beträgt: " + s);
            Console.WriteLine();
        }
    }
}
