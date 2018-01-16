using System;

namespace Exercise8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            CPerson einePerson = new CPerson("Hans", "Kaiser", "1121", "20.10.1990");
            CPerson zweitePerson = new CPerson("Karl", "Hansen", "1121", "31.12.1983");
            
            if (einePerson == zweitePerson)
            {
                Console.WriteLine("Die Personen sind gleich");
            }

            if (einePerson != zweitePerson)
            {
                Console.WriteLine("Die Personen sind nicht gleich");
            }

            einePerson--;
            Console.WriteLine(einePerson);
            zweitePerson++;
            Console.WriteLine(zweitePerson);
        }
    }
}
