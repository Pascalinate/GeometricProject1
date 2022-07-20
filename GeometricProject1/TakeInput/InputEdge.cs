using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject1.TakeInput
{
    class InputEdge
    {
        public double Edge;
        public double GetEdge()
        {
            Console.Write("Enter the edge: ");
            try
            {
                return Edge = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine($"The edge entered is not valid.");
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
