using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzuzeciZad5
{
    interface IIterator
    {
        bool existMore();
        void next();
        int current();
        void reset();
    }
}
