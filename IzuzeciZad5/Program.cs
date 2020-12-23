using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzuzeciZad5
{
    class Program
    {
        static void Main(string[] args)
        {
            IIterator i;
            Vector v = new Vector(10);
            i = new VectorIterator(v);
            i.reset();
            while (i.existMore())
            {
                Console.Write(i.current());
                i.next();
            }
            Console.ReadKey();
        }
    }
}
