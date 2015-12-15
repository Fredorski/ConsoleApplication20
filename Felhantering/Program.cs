using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Felhantering
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //FirstTryCatch();
                Class2.Method();
            }
            catch (Exception)
            {
                Console.WriteLine("Hanterat här i MAIN!!!");
                //throw new Exception();
            }
           
                //Oavsett vad som skett om det gick bra eller om vi hamnade i en catch
                //så kommer det som står här att göras efter
                Console.WriteLine("Efter allt");
            
         
            Console.ReadLine();
        }

        private static void FirstTryCatch()
        {
            Class1 class1 = new Class1();
            class1.Method();
        }
    }
}
