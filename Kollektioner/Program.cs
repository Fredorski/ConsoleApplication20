using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Kollektioner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista1();
            //Lista2();
            //ListaBus();
            //FlyLista();
            //ClearList();
            //ArraySyntaxIntisar();
            // IndexOfMethod();
            //System.Threading.Thread.Sleep(4000);
            //Uppgift skapa 3 flygplan och sortera dem med sort()
            var planes = new List<AirPlane>()
            {
                new AirPlane(seats: 2, pilots: 1),
                new AirPlane(seats: 4, pilots: 2),
                new AirPlane(seats: 88, pilots: 3),
                new AirPlane(seats: 29, pilots: 4),
                new AirPlane(seats: 212, pilots: 5),
                new AirPlane(seats: 12, pilots: 2),
                new AirPlane(seats: 232, pilots: 3),
                new AirPlane(seats: 32, pilots: 3),
                new AirPlane(seats: 882, pilots: 5),
                new AirPlane(seats: 82, pilots: 10),
            };
            planes.Sort();
            planes.Reverse();
            foreach (var airPlane in planes)
            {
                Console.WriteLine(airPlane);
            }
            Console.ReadLine();
        }

        private static void IndexOfMethod()
        {
            List<int> tal = new List<int>
                (new int[] {3, 2, 3, 2, 29, 33, 32});
            int indexPosition = tal.IndexOf(29); //position 4 är första förekomsten av 29
            Console.WriteLine(indexPosition); //skriver 4
            indexPosition = tal.IndexOf(17);

            Console.WriteLine(indexPosition);
        }

        private static void ClearList()
        {
            var lista = new List<bool>() {true, false, false, true};
            lista.Add(true);
            lista.Add(false);
            lista.Add(true);
            lista.Add(true);
            Console.WriteLine(lista.Count); //antal element
            lista.Clear();
            Console.WriteLine(lista.Count);
        }

        private static void ArraySyntaxIntisar()
        {
            var storlekar = new List<int>() {3, 32, 3, 23, 1, 132, 1, 34, 1, 234, 2341, 2341, 23412, 34};
            var kopia = storlekar; //Pekar på samma objekt på heapen
            storlekar.Sort();
            //storlekar.Reverse();
            //foreach (var s in kopia) 
            //{
            //    Console.WriteLine(s);
            //}
            for (int i = 0; i < storlekar.Count; i++)
            {
                Console.WriteLine(storlekar[i]);
            }
        }

        private static void FlyLista()
        {
            var jas39 = new AirPlane(seats: 5, pilots: 2);
            var jas40 = new AirPlane(seats: 7, pilots: 0);
            jas39.Seats = 5;
            var planes = new List<AirPlane>() {jas39, jas40};
        }

        private static void ListaBus()
        {
            var busses = new List<Bus>();
            for (int i = 0; i < 10; i++)
            {
                busses.Add(new Bus(seats: 8 + i, horsePowers: 900));
            }
            foreach (var bus in busses)
            {
                Console.WriteLine(bus);
            }
        }

        private static void Lista2()
        {
            var persons = new List<Person>();
            for (int i = 0; i < 10000; i++)
            {
                persons.Add(new Person("Name" + i, i%21));
            }

            //var myndiga = persons.Where(p => p.Age >= 18).ToList();


            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
        }

        private static void Lista1()
        {
            var lisa = new Person("Lisa", 26);
            var raffe = new Person("Rafael", 44);
            List<Person> persons = new List<Person>();
            persons.Add(lisa);
            persons.Add(raffe);
            foreach (var person in persons)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}
