using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesIntro
{
    interface IWalker
    {
        int NumLegs { get; set; }
        double StrideLength { get; set; }

        void walk();
    }
}
