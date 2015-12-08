using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konverteringar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Konverteringar();
            Cyckel c1 = new Cyckel(); //OK!
            MC mc = new Cyckel(); //Ej OK
            MC mc2 = (MC) c1; // Explicit typkonvertering
            //Kompilatorn upptäcker inte felet förrän under programkörning

            //TEST med as:
            Cyckel cyckel = (Cyckel) new MC();
            MC mcTest = c1 as MC; //Försökergöra om c1 till en MC
            if (mcTest != null) //Kontrollerar att mc är giltig
            {
                //Konverterad
            }
            //Test med is:
            Object obj = new Cyckel();
            bool b = obj is Cyckel; //Allways true

            Cyckel cyckel2= new Cyckel();
            Boolean f = cyckel2 is object;

            //Boxing:
            int tal = 5;
            object paket = tal; //Boxing- värdetyp till referenstyp

            //Unboxing
            int tal23 = (int) paket; //Unboxing -referenstyp till värdetyp

        }

        private static void Konverteringar()
        {
            long tal = 200; //implicit typkonvertering
            //int tal2 = 200L;
            int tal2 = (int)200L;//explicit typkonvertering (Extra!)

            System.Int64 longTal = 200L;
            System.Int32 intTal = 200;
            var doubleTal = 4.4;
            //float flyttal = (float)4.4; //Typkonvertering
            float flyttal = 4.4f; //Ingen typkonvertering
            int number = (int)doubleTal;
            //Alltid när vi gör explicit typkonvertering kan vi FÖRLORA NÅGOT
            //Om vi gör en implicit typkonvertering är den nya behållaren "större" så vi får plats med allt
        }
    }
}
