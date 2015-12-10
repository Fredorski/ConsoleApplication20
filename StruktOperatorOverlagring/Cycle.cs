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
            val = min;
            this.min = min;
            this.max = max;
        }

        public int Val {
            get { return val; }
            set
            {
                if(value>=min && value<=max)
                    val = value;
                val = min;
            } 
        }

        public static Cycle operator +(Cycle cycle, int tal)
        {
            cycle.max += tal;
            return cycle;
        }
        public static Cycle operator -(Cycle cycle, int tal)
        {
            cycle.max -= tal;
            return cycle;
        }
        public override string ToString()
        {
            return $"Val{Val}: Min{min}: Max{max}";
        }
    }
}
