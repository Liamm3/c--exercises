using System;

namespace Exercise6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            CPunkt a = new CPunkt(10, 20);
            CPunkt b = new CPunkt(a);
            CPunkt c = new CPunkt();

            c.X = 30;
            c.X = 40;

            Console.WriteLine("Punkt B <" + b.X + "|" + b.Y + ">");
            Console.WriteLine("Abstand von Punkt B zyu <0|0>: " + b.Abstand());
        }
    }
}
