using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Virtualis();
            Vehicle vehicle = new Car();
            vehicle.Print();
                
            Console.ReadLine();

        }

        private static void Virtualis()
        {
            Cyckel cyckel = new Cyckel();
            Fordon fordon = (Fordon)cyckel;
            Bil bil = new Bil();
            Fordon[] fordonare = new Fordon[3] { cyckel, fordon, bil };
            foreach (var item in fordonare)
            {
                item.Print();
            }
        }
    }
}
