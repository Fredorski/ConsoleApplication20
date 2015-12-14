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
        Add = 1, Substract, Multiply, Devide, End
    }
    class Program
    {
        static void Main(string[] args)
        {
            StartMathProgram();
            Console.ReadLine();
        }

        private static void StartMathProgram()
        {
            bool loopa = true;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                PrintMenuWithEnums();
                loopa = MenuChoice(loopa);
            } while (loopa);
        }

        private static bool MenuChoice(bool loopa)
        {
            int tal;
            if (int.TryParse(Console.ReadLine(), out tal))
            {
                Menu menu = (Menu) tal;
                switch (menu)
                {
                    case Menu.Add:
                        AddMethod();
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
                        Console.WriteLine("Something went wrong... Please try again");
                        break;
                }
                System.Threading.Thread.Sleep(3000);
            }
            return loopa;
        }

        private static void AddMethod()
        {
            Console.WriteLine(Menu.Add);
            int tal1;
            int tal2;
            Console.WriteLine("Skriv in 2 tal som du vill addera:");
            if (int.TryParse(Console.ReadLine(), out tal1)
                && int.TryParse(Console.ReadLine(), out tal2))
            {
                Console.WriteLine("{0}+{1}={2}", tal1, tal2, tal1 + tal2);
            }
        }

        private static void PrintMenuWithEnums()
        {
            int counter = 1;
            foreach (var item in Enum.GetNames(typeof(Menu)))
            {
                Console.WriteLine("{0}: {1}", counter++, item);
            }
            Console.WriteLine("Please enter a number from the list above:");
        }
    }
}
