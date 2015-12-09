using System;
using System.Collections.Generic;
using System.Linq;
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
            var jas39 = new AirPlane(seats: 5, pilots: 2);
            var jas40 = new AirPlane(seats: 7, pilots: 0);
            var planes = new List<AirPlane>() {jas39, jas40};

            //System.Threading.Thread.Sleep(4000);
            Console.ReadLine();
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
