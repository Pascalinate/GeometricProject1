using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject1.TakeInput
{
    internal class InputHeight
    {
        public double Height;
        public double GetHeight()
        {
            Console.Write("Enter the height: ");
            try
            {
                return Height = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine($"The height entered is not valid.");
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
