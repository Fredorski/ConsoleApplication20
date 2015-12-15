using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felhantering
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstTryCatch();
            Class2.Method();
            Console.ReadLine();
        }

        private static void FirstTryCatch()
        {
            Class1 class1 = new Class1();
            class1.Method();
        }
    }
}
