using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject1.Shapes
{
    class Cone : IShape
    {
        private double radius;
        public double Radius { get { return radius; } }
        private double height;
        public double Height { get { return height; } }
        public double CalculateTSA()
        {
            return Math.PI * Radius * (Radius + Math.Pow((Math.Pow(Height, 2) + Math.Pow(Radius, 2)), (1 / 2)));
        }

        public double CalculateVolume()
        {
            return Math.PI * Math.Pow(Radius, 2) * (Height / 3);
        }

        public void TakeDimensions()
        {
            radius = new TakeInput.InputRadius().GetRadius();
            height = new TakeInput.InputHeight().GetHeight();
        }

        public void DisplayResults()
        {
            new Output.DisplayResults().Show("CONE", CalculateTSA(), CalculateVolume());
        }
    }
}
