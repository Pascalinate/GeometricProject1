using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject1.Shapes
{
    class Cylinder : IShape
    {
        private double radius;
        public double Radius { get { return radius; } }
        private double height;
        public double Height { get { return height; } }
        public double CalculateTSA()
        {
            return (2 * Math.PI * Radius * Height) + (2 * Math.PI * Math.Pow(Radius, 2));
        }

        public double CalculateVolume()
        {
            return Math.PI * Math.Pow(Radius, 2) * Height;
        }

        public void TakeDimensions()
        {
            radius = new TakeInput.InputRadius().GetRadius();
            height = new TakeInput.InputHeight().GetHeight();
        }

        public void DisplayResults()
        {
            new Output.DisplayResults().Show("CYLINDER", CalculateTSA(), CalculateVolume());
        }
    }
}
