using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    abstract class Vehicle
    {
        //abstract innebär att vi lämnar över allt ansvar till underliggande subklasser.
        public abstract void Print();
    }
    class Car : Vehicle
    {
        public override void Print() {
            Console.WriteLine("tjihoo abstract-override");
        }
    }
    class Bike : Vehicle
    {
        public override void Print()
        {
            Console.WriteLine("Bike");        }
    }
}
