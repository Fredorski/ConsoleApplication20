using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kollektioner
{
    class Bus
    {
        public int Seats { get; set; }
        public int HorsePowers { get; set; }

        public Bus(int seats, int horsePowers)
        {

            Seats = seats;
            HorsePowers = horsePowers;
        }

        public override string ToString()
        {            
            return string.Format("Seats:{0}, HorsePosers{1}", Seats, HorsePowers);
        }
    }
}
