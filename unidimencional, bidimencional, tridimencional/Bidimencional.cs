using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unidimencional__bidimencional__tridimencional
{
    internal class Bidimencional
    {
        private int dat1;
        private int dat2;

        public int Dat1 {  get { return dat1; } set {  dat1 = value; } }
        public int Dat2 { get { return dat2; } set { dat2 = value; } }

        public Bidimencional(int numero1, int numero2)
        {
            this.dat1 = numero1;
            this.dat2 = numero2;
        }

        public override string ToString()
        {
            return Convert.ToString(dat1+dat2);   
        }
    }
}
