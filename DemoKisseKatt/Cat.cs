using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKisseKatt
{
    class Cat : Animal
    {
        private string djur = "katt";

        public override void PrintInfo() //Sometimes prononced as productInfo.. ihihi
        {
            Console.WriteLine($"Djur: {djur}, Name: {Name}");
        }
    }
    class Dog : Animal
    {
        private string djur = "hund";

        public override void PrintInfo()
        {
            Console.WriteLine($"Djur: {djur}, Name: {Name}");
        }
    }
}
