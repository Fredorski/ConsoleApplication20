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
            var persons = new List<Person>();
            for (int i = 0; i < 50; i++)
            {
                persons.Add(new Person("Name"+i, i%30));
            }
            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
            //System.Threading.Thread.Sleep(4000);
            Console.ReadLine();
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
