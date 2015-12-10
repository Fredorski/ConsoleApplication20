using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatingThings
{
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
