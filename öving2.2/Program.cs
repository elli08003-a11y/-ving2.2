using System;
using System.ComponentModel;
namespace Övning2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elin hoppade längre en Alma. Hur långt hoppade Elin i meter");
            string Elin = Console.ReadLine();
            Console.WriteLine("Hur långt hoppade Alma i meter");
            string Alma = Console.ReadLine();
            Double Elinnummer = Convert.ToDouble(Elin);
            Double Almanummer = Convert.ToDouble(Alma);
            Double skilnad = (Elinnummer - Almanummer);
            Console.WriteLine("Elin hoppade " + skilnad + " meter längre en Alma");
        }
    }
}