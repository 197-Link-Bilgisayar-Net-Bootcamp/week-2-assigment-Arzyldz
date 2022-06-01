using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDApp
{
    //DEĞİŞTİRMEYE KAPALI GELİŞİME AÇIK
    internal class OCP
    {
        public abstract class Sekil
        {
            public abstract double Alan();
        }

        public class Kare : Sekil
        {
            public int kenar { get; set; }
            public Kare(int kenari)
            {
                kenar = kenari;
            }
            public override double Alan()
            {
                return System.Math.Pow(kenar, 2);
            }
        }

        public class Daire : Sekil
        {
            public int yaricap { get; set; }
            public Daire(int yaricapi)
            {
                yaricap = yaricapi;
            }
            public override double Alan()
            {
                return 3.14 * System.Math.Pow(yaricap, 2);
            }
        }

       public class AlanToplamiHesaplama
        {
            public double AlanToplamlari(List<Sekil> sekiller)
            {
                double alanToplami = 0;

                foreach (Sekil sekil in sekiller)
                    alanToplami += sekil.Alan();

                return alanToplami;
            }
        }
    }
}
