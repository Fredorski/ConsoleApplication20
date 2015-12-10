using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://msdn.microsoft.com/en-us/library/xhbhezf4.aspx
namespace CatingThings
{
    class Farenheit
    {
        public float Temp { get; set; }

        public Farenheit(float temp)
        {
            Temp = temp;
        }

        //Explicit innebär förlust av data (oftast en property som inte finns i retur-klassen)
        //Implicit brukar innebära att returklassen har en delmängd från ursprungliga
        public static implicit operator Celsius(Farenheit farenheit)
        {
            return new Celsius(5.0f / 9.0f * farenheit.Temp - 32);
        }
    }
}
