using System;

namespace Exercise7._2
{
    class CDelfin : CTier, IWassertier
    {
        private int tauchzeit;
        public int TAUCHZEIT { get => tauchzeit; set => tauchzeit = value; }

        public CDelfin(string name, int tauchzeit) : base(name)
        {
            TAUCHZEIT = tauchzeit;
        }

        override public void Steckbrief()
        {
            Console.WriteLine("Name des Tiers: " + Name);
            Console.WriteLine("Tauchzeit: " + TAUCHZEIT);
        }
    }
}
