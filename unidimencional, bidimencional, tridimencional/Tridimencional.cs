using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unidimencional__bidimencional__tridimencional
{
    internal class Tridimencioanl
    {
        private int dat1;
        private int dat2;
        private int dat3;

        public int Dat1 { get { return dat1; } set { dat1 = value; } }
        public int Dat2 { get { return dat2; } set { dat2 = value; } }
        public int Dat3 { get { return dat3; } set { dat3 = value; } }

        public Tridimencioanl(int numero1, int numero2, int numero3)
        {
            this.dat1 = numero1;
            this.dat2 = numero2;
            this.dat3 = numero3;
        }

        public override string ToString()
        {
            return Convert.ToString((dat1 * dat2)/ dat3);
        }
    }
}
