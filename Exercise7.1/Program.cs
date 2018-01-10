using System;

namespace Exercise7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            CViereck v = new CViereck("Viereck 1");
            CKreis k = new CKreis("Kreis 1");

            CPunkt p1 = new CPunkt(1, 3);
            CPunkt p2 = new CPunkt(4, 3);
            CPunkt p3 = new CPunkt(5, 8);
            CPunkt p4 = new CPunkt(1, 8);
            double radius = 2.5;

            v.SetPunkte(p1, p2, p3, p4);
            k.SetPunktRadius(p1, radius);

            v.Ausgabe();
            Console.WriteLine();

            k.Ausgabe();
            Console.WriteLine();
        }
    }
}
