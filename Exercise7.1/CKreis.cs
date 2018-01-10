using System;

namespace Exercise7._1
{
    class CKreis : CGrundForm
    {
        private CPunkt p1 { get; set; }
        private double radius { get; set; }

        public CKreis(string name) : base(name) {}

        public void SetPunktRadius(CPunkt p1, double radius)
        {
            this.p1 = p1;
            this.radius = radius;
        }

        override public void Ausgabe()
        {
            Console.WriteLine("Der Kreis hat die Bezeichnung: " + name);
            Console.WriteLine("Der Punkt lautet:");
            Console.WriteLine(p1.ToString());
            Console.WriteLine("Der Radius lautet: " + radius);
        }
    }
}
