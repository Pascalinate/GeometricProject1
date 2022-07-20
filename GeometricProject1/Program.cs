using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeometricCalculation();
        }

        public static void GeometricCalculation()
        {
            while (true)
            {
                int shapeId = ShapeHelper.ChooseShape(); // message to choose shape
                IShape op = ShapeHelper.ShapeChoice(shapeId); // actual shape chosen
                if (op == null) break;
                op.TakeDimensions(); 
                op.CalculateTSA();
                op.CalculateVolume();
                op.DisplayResults();

            }
        }
    }
}
