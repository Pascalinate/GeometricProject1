using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject1.TakeInput
{
    class InputRadius
    {
        public double Radius;
        public double GetRadius()
        {
            Console.Write("Enter the radius: ");
            try
            {
                return Radius = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine($"The radius entered is not valid.");
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
                return 0;
            }
        }
    }
}
