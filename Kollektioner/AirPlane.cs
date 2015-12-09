using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kollektioner
{
    class AirPlane
    {
        public int Seats { get; internal set; }
        public int Pilots { get; private set; }

        public AirPlane(int seats, int pilots)
        {
            Seats = seats;
            Pilots = pilots;
        }

        public override string ToString()
        {
            return $"Seats:{Seats}, Pilots:{Pilots}";
        }
    }
}
