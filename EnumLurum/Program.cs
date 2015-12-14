using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EnumLurum
{
    enum Menu
    {
        Add=1, Substract, Multiply, Devide, End
    }
    class Program
    {
        static void Main(string[] args)
        {
            PrintMenuWithEnums();
            bool loopa = true;
            do
            {
                int tal;
                if (int.TryParse(Console.ReadLine(), out tal))
                {
                    Menu menu = (Menu) tal;
                    switch (menu)
                    {
                        case Menu.Add:
                            Console.WriteLine(Menu.Add);
                            break;
                        case Menu.Substract:
                            Console.WriteLine(Menu.Substract);
                            break;
                        case Menu.Multiply:
                            Console.WriteLine(Menu.Multiply);
                            break;
                        case Menu.Devide:
                            Console.WriteLine(Menu.Devide);
                            break;
                        case Menu.End:
                            Console.WriteLine(Menu.End);
                            loopa = false;
                            break;
                        default:
                            //throw new ArgumentOutOfRangeException();
                            Console.WriteLine("Something wnt wrong... Please try again");
                            break;
                    }
                }
            } while (loopa); 
            Console.ReadLine();
        }

        private static void PrintMenuWithEnums()
        {
            int counter = 1;
            foreach (var item in Enum.GetNames(typeof (Menu)))
            {
                Console.WriteLine("{0}: {1}", counter++, item);
            }
            Console.WriteLine("Please enter a number from the list above:");
        }
    }
}
