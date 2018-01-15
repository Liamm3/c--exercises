using System;

namespace Exercise7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            CElefant e = new CElefant("Elefant", 30);
            CNashorn n = new CNashorn("Nashorn", 20);
            CDelfin d = new CDelfin("Delfin", 500);
            CWal w = new CWal("Wal", 800);

            CTier t;
            t = e;
            t.Steckbrief();
            Console.WriteLine();
            
            t = n;
            t.Steckbrief();
            Console.WriteLine();

            t = d;
            t.Steckbrief();
            Console.WriteLine();

            t = w;
            t.Steckbrief();
            Console.WriteLine();
        }
    }
}
