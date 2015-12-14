using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IConparableNgnting
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Skapa en POCO-klass med 3 attribut (3min)
            //2. Lägg 5 instanser av klassen i en collection (3min)
            //3. Använd sort() på collectinen
            //4. Skriv ut collectionen

            var lista = new List<RGB>();
            lista.Add(new RGB(33,34,35));
            lista.Add(new RGB(0, 34, 45));
            lista.Add(new RGB(22, 0, 35));
            lista.Add(new RGB(133, 34, 0));
            lista.Add(new RGB(34, 0, 78));
            lista.Sort();
        }
    }
}
