using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKisseKatt
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public abstract void PrintInfo();
        public override string ToString() => $"Name: {Name}, Age:{Age}";
    }
    class Cat : Animal
    {
        private string djur = "katt";

        public override void PrintInfo() //Sometimes prononced as productInfo.. ihihi
        {
            Console.WriteLine($"Djur: {djur}, Name: {Name}");
        }
        public override string ToString() => $"Djur: {djur}" + base.ToString();
    }
    class Dog : Animal
    {
        private string djur = "hund";

        public override void PrintInfo()
        {
            Console.WriteLine($"Djur: {djur}, Name: {Name}");
        }
        public override string ToString() => $"Djur: {djur} {base.ToString()}";
    }
}
