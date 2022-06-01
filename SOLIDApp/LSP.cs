using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDApp
{
    internal class LSP
    {
        public interface IUcabilir
        {
            public double UcmaMesafesi();
        }
        public class Kus
        {
            public int KanatAraligi { get; set; }
            public string LatinceAdi { get; set; }

        }

        public class Baykus : Kus, IUcabilir
        {
            public double UcmaMesafesi()
            {
                double ucmaMesafesiniHesapla = 1000;
                return ucmaMesafesiniHesapla;
            }
        }

        public class Penguen : Kus
        {

        }
    }
}
