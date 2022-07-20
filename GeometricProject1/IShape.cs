using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject1
{
    interface IShape
    {
        void TakeDimensions();

        double CalculateTSA();

        double CalculateVolume();

        void DisplayResults(); 
    }
}
