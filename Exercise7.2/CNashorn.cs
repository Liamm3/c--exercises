using System;

namespace Exercise7._2
{
    class CNashorn : CTier, ILandtier
    {
        private int geschwindigkeit;
        public int GESCHWINDIGKEIT { get => geschwindigkeit; set => geschwindigkeit = value; }

        public CNashorn(string name, int geschwindigkeit) : base(name)
        {
            GESCHWINDIGKEIT = geschwindigkeit;
        }

        override public void Steckbrief()
        {
            Console.WriteLine("Name des Tiers: " + Name);
            Console.WriteLine("Geschwindigkeit: " + GESCHWINDIGKEIT);
        }
    }
}
