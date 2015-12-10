using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StruktOperatorOverlagring
{
    struct Cycle
    {
        private int val, min, max;
        //Växlar vald, lägst högst...
        public Cycle(int min, int max)
        {
            //val = min;
            this.min = min;
            this.max = max;
        }

        public int Val
        {
            get { return val; }
            set
            {
                if (value >= min && value <= max)
                    val = value;
                val = min;
            }
        }

        public static Cycle operator +(Cycle cycle, int tal)
        {
            //Om klass gör vi så här:
            //Om vi skapat referenstyp/class måste vi skapa en kopia som vi returnerar så att inte det objekt som skickas in pekas på från 2 eller fler ställen...
           // return new Cycle(1, cycle.max += tal);
           //hej

            cycle.max += tal;
            return cycle;

        }
        public static Cycle operator -(Cycle cycle, int tal)
        {
            cycle.max -= tal;
            return cycle;
        }

        public static int operator -(int tal, Cycle cykle)
        {
            tal -= cykle.max;
            return tal;
        }
        public static int operator +(int tal, Cycle cykle)
        {
            tal += cykle.max;
            return tal;
        }

        public override string ToString()
        {
            return $"Val{Val}: Min{min}: Max{max}";
        }
    }
}
