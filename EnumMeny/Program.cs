using System;

namespace EnumMeny
{
    enum Menu { AddItem, LoseItem, CreateSome, Awsome, Hejsan, Avsluta }
    class Program
    {
        static void Main(string[] args)
        {
            bool loopa = true;
            do
            {
                PrintMenuFromEnums();
                int tal;
                Console.WriteLine("Skriv 0-4:");



                if (int.TryParse(Console.ReadLine(), out tal))
                {
                    Menu menu = (Menu)tal;
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
                            loopa = false;
                            break;
                        case Menu.Hejsan: //Nytt enum inlaggt tjihoo, 
                            break;
                        default:
                            Console.WriteLine("Something went wrong... Try again to write a number corresponding to the menu choises!");
                            //throw new ArgumentOutOfRangeException();
                            break;
                    }
                }
            } while (loopa);
            Console.WriteLine("Program has stoped! Press ENTER!");
            Console.ReadLine();
        }

        private static void PrintMenuFromEnums()
        {
            int counter = 0;
            foreach (string item in Enum.GetNames(typeof(Menu)))
            {
                Console.WriteLine("{0}: {1}", counter++, item);
            }
        }
    }
}
