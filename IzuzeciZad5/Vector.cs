using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzuzeciZad5
{
    class Vector
    {
        private int n; //broj elemenata
        private int[] niz;

        public Vector (int dim)
        {
            n = dim;
            niz = new int[n];
            for (int i = 0; i < n; i++)
                niz[i] = i;
        }

        public int getElements (int k)
        {
            return niz[k];
        }
        public int getDimension()
        {
            return n;
        }
    }
}
