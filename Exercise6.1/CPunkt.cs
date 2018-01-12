using System;

namespace Exercise6._1
{
    class CPunkt
    {
        private double x;
        private double y;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

    public CPunkt()
        {
            X = 0;
            Y = 0;
        }

        public CPunkt(double a, double b)
        {
            X = a;
            Y = b;
        }

        public CPunkt(CPunkt p)
        {
            X = p.X;
            Y = p.Y;
        }

        public double Abstand()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
    }
}
