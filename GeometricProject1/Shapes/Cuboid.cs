using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject1.Shapes
{
    class Cuboid : IShape
    {
        private double length;
        public double Length { get { return length; } }
        private double width;
        public double Width { get { return width; } }
        private double height;
        public double Height { get { return height; } }
        public double CalculateTSA()
        {
            return (2 * Length * Width) + (2 * Length * Height) + (2 * Height * Width);
        }

        public double CalculateVolume()
        {
            return Width * Height * Length;
        }

        public void TakeDimensions()
        {
            length = new TakeInput.InputLength().GetLength();
            width = new TakeInput.InputWidth().GetWidth();
            height = new TakeInput.InputHeight().GetHeight();
        }

        public void DisplayResults()
        {
            new Output.DisplayResults().Show("CUBOID", CalculateTSA(), CalculateVolume());
        }
    }
}
