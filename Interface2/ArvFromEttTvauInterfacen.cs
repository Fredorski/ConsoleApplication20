using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    class ArvFromEttTvauInterfacen : IEtt, ITvau
    {
        public void GoByBus() //Single implementation for both
        {
            Console.WriteLine("GoByBus");
        }
        //void IEtt.GoByBus()
        //{
        //    throw new NotImplementedException();
        //}

        //void ITvau.GoByBus()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
