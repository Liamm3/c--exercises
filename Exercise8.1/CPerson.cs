using System;

namespace Exercise8._1
{
    class CPerson
    {
        private string name;
        private string vorname;
        private string telefon;
        private string geburtsdatum;

        public string Name { get => name; private set => name = value; }
        public string Vorname { get => vorname; private set => vorname = value; }
        public string Telefon { get => telefon; private set => telefon = value; }
        public string Geburtsdatum { get => geburtsdatum; private set => geburtsdatum = value; }

        public CPerson(string vorname, string name, string telefon, string geburtsdatum)
        {
            Name = name;
            Vorname = vorname;
            Telefon = telefon;
            Geburtsdatum = geburtsdatum;
        }

        public static bool operator ==(CPerson p1, CPerson p2)
        {
            if (p1.Name != p2.Name || p1.Vorname != p2.Vorname || p1.Telefon != p2.Telefon || p1.Geburtsdatum != p2.Geburtsdatum)
            {
                return false;
            }

            return true;
        }

        public static bool operator !=(CPerson p1, CPerson p2)
        {
            if (p1.Name == p2.Name || p1.Vorname == p2.Vorname || p1.Telefon == p2.Telefon || p1.Geburtsdatum == p2.Geburtsdatum)
            {
                return false;
            }

            return true;
        }

        public static CPerson operator ++(CPerson p)
        {
            DateTime result = DateTime.Parse(p.Geburtsdatum); 
            result = result.AddDays(1);
            p.Geburtsdatum = result.ToShortDateString().ToString();
            return p;
        }

        public static CPerson operator --(CPerson p)
        {
            DateTime result = DateTime.Parse(p.Geburtsdatum); 
            result = result.AddDays(-1);
            p.Geburtsdatum = result.ToShortDateString().ToString();
            return p;
        }

        public override string ToString()
        {
            return Name + " " + Vorname + " " + Telefon + " " + Geburtsdatum;
        }
    }
}