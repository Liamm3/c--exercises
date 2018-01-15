namespace Exercise8._2
{
    class CKonto
    {
        private string nummer;
        private double saldo;

        public string NUMMER { get => nummer; set => nummer = value; }
        public double SALDO { get => saldo; set => saldo = value; }

        public override string ToString()
        {
            return "Kontonummer: " + NUMMER + "\nSaldo: " + SALDO; 
        }

        public static CKonto operator +(CKonto konto, double d)
        {
            konto.SALDO += d;
            return konto;
        }

        public static CKonto operator -(CKonto konto, double d)
        {
            konto.SALDO -= d;
            return konto;
        }

        public static explicit operator double(CKonto konto)
        {
            return konto.SALDO;
        }
    }
}