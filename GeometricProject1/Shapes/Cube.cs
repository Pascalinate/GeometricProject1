using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject1.Shapes
{
    class Cube : IShape
    {
        private double edge;
        public double Edge { get { return edge; } }
        public double CalculateTSA()
        {
            return 6 * Math.Pow(Edge, 2);
        }

        public double CalculateVolume()
        {
            return Math.Pow(Edge, 3);
        }

        public void TakeDimensions()
        {
            edge = new TakeInput.InputEdge().GetEdge();
        }

        public void DisplayResults()
        {
            new Output.DisplayResults().Show("CUBE", CalculateTSA(), CalculateVolume());
        }
    }
}
