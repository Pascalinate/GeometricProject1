using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject1.Shapes
{
    class Sphere : IShape
    {
        private double radius;
        public double Radius { get { return radius; } }
        public double CalculateTSA()
        {
            return 4 * Math.PI * Math.Pow(Radius, 2);
        }

        public double CalculateVolume()
        {
            return (4 / 3) * Math.PI * Math.Pow(Radius, 3);
        }

        public void TakeDimensions()
        {
            radius = new TakeInput.InputRadius().GetRadius();

        }

        public void DisplayResults()
        {
            new Output.DisplayResults().Show("SPHERE", CalculateTSA(), CalculateVolume());
        }
    }
}
