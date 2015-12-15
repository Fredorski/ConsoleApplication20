using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felhantering
{
    static class Class2
    {
        internal static void Method()
        {
            try
            {
                Console.WriteLine("Skriv ett tal som 6 ska delas på:");
                var tal = 2; // /int.Parse(Console.ReadLine());
                var overflow = new List<int>();
                switch (tal)
                {
                    case 1:
                        overflow.Add(123456);
                        goto case 2;
                        break;
                    case 2:
                        overflow.Add(123456);
                        goto case 1;
                        break;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hanterar allt");
                throw ex;

            }
            finally
            {
                Console.WriteLine("STÄNG Databasen!!!");
            }
            Console.WriteLine("Eftersläntare");
        }
    }
}
