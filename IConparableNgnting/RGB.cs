using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IConparableNgnting
{
    class RGB: IComparable<RGB>
    {
        public int R { get; set; }
        public int G { get; set; }
        public int  B { get; set; }
        public RGB(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }

        public int CompareTo(RGB other)
        {
            return R.CompareTo(other.R);
        }

        public override string ToString()
        {
            return string.Format
                ("R:{0},G:{1},B:{2}", R, B, G);
        }

      
    }
}
