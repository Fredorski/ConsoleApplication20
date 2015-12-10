using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structisar
{
    class Program
    {
        static void Main(string[] args)
        {
            //StructDemo1();

            Console.ReadLine();
        }

        private static void StructDemo1()
        {
            Koordinat koordinat;
            koordinat.X = 66;
            koordinat.Y = 88;

            Koordinat origo = new Koordinat() {X = 50, Y = 50};
            origo.Z = "19";
            origo = new Koordinat();
            /*Nollställer strukten
            alla fält får defaultvärdet för respektive datatyp
            observera att string fick null i sig nu*/
            Console.WriteLine(origo);
        }
    }
}
