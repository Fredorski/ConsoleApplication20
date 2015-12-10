using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StruktOperatorOverlagring
{
    class Program
    {
        static void Main(string[] args)
        {
            Cycle timCycle = new Cycle(3,21);
            Cycle zebbeCycle = new Cycle(1,2);
            zebbeCycle += 12;
            int tal = 12 + zebbeCycle;
            Console.WriteLine("tal+cycle="+ tal);
            zebbeCycle = zebbeCycle - 7;
            zebbeCycle -= 7;
            Console.WriteLine(zebbeCycle);
            Console.ReadLine();
        }
    }
}
