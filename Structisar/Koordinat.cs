using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structisar
{
    /*
    * en struct är en egendefinierad värdetyp
    * har inga referenser till heapen
    * är implicit sealed
    * är public per default
    * skrivs som vi skriver en klass men har nyckelordet struct
    * alla de primitiva typerna är structar:
          ex, bool, int, long, double, float, char, DateTime
    * ungefär 3ggr snabbare än en class om 5 fält finns
    * kan inte vara null, pga kan inte referera till heapen

        */


    public struct Koordinat 
    {
        public int X;
        public int Y;
        public string Z;

     
        //public int Z = 9; //Does not compute, vi får inte sätta värde på fält i en struct
        public override string ToString()
        {
            return $"X:{X}, Y:{Y}, Z:{Z}";
        }
    }

    //class StructXYZ: koordinat
    //{
    //    //Kan och får inte ärva från en struct 
    //}
}
