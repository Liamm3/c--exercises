using System;

namespace Exercise7._2
{
    class CWal : CTier, IWassertier 
    {
        private int tauchzeit;
        public int TAUCHZEIT { get => tauchzeit; set => tauchzeit = value; }

        public CWal(string name, int tauchzeit) : base(name)
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
