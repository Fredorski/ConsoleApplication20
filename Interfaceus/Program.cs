using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceus
{
    class Program
    {
        static void Main(string[] args)
        {
            IInterface iInterface = new MyClass();
            iInterface.Method();
        }
    }
}
