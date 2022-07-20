using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject1.Output
{
    class DisplayResults
    {

        public void Show(string shapeName, double TSA, double Volume)
        {
            Console.WriteLine($@"
RESULTS ({shapeName}):
Total Surface area: {TSA}
Volume: {Volume}

");
        }
    }
}
