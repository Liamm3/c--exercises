using System;

namespace Exercise7._1
{
    class CViereck : CGrundForm
    {
        private CPunkt p1 { get; set; }        
        private CPunkt p2 { get; set; }   
        private CPunkt p3 { get; set; }   
        private CPunkt p4 { get; set; }

        public CViereck(string name) : base(name) {}

        public void SetPunkte(CPunkt p1, CPunkt p2, CPunkt p3, CPunkt p4)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
        }

        override public void Ausgabe()
        {
            Console.WriteLine("Das Viereck hat die Bezeichnung: " + name);
            Console.WriteLine("Die Punkte lauten:");
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p3.ToString());
            Console.WriteLine(p4.ToString());            
        }
    }
}
