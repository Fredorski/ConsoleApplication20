using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    class Program :IChildInterface
    {
        static void Main(string[] args)
        {
           Program program = new Program();
            program.ChildMethod();
            program.ParentMethod();
            Console.ReadLine();
        }

        public void ParentMethod()
        {
            Console.WriteLine("Parent");
        }

        public void ChildMethod()
        {
            Console.WriteLine("child");
        }
    }
}
