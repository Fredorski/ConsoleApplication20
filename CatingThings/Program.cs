using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatingThings
{
    /*Uppgift 
    skapa en Point med X och Y
    skapa en Point3D med X Y Z
    casta mellan point och point3d -> båda hållen...
    
        
        */
    class Program
    {
        static void Main(string[] args)
        {
            Farenheit farenheit = new Farenheit(100.0f);
            Console.WriteLine($"Farenheit:{farenheit.Temp}");

            //Casta farenheit -> Celsius
            Celsius celsius = (Celsius) farenheit;
            Console.WriteLine($"Celcius:{celsius.Temp}");

            //Casta celsius -> Farenheit
            Farenheit farenheit2 = (Farenheit) celsius;
            Console.WriteLine($"Farenheit:{farenheit2.Temp}");

        }
    }
}
