using System;

namespace EnumMeny
{
    enum Menu {AddItem, LoseItem, CreateSome, Awsome, Avsluta }
    class Program
    {
        static void Main(string[] args)
        {
            int tal;
            Console.WriteLine("Skriv 0-4:");
            if (int.TryParse(Console.ReadLine(), out tal))
            {
                Menu menu = (Menu) tal;
                switch (menu)
                {
                    case Menu.AddItem:
                        Console.WriteLine(Menu.AddItem);
                        break;
                    case Menu.LoseItem:
                        Console.WriteLine(Menu.LoseItem);
                        break;
                    case Menu.CreateSome:
                        Console.WriteLine(Menu.CreateSome);
                        break;
                    case Menu.Awsome:
                        Console.WriteLine(Menu.Awsome);
                        break;
                    case Menu.Avsluta:
                        Console.WriteLine(Menu.Avsluta);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                Console.ReadLine();
            }
        }
    }
}
