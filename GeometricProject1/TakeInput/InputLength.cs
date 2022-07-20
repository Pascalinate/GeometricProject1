using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject1.TakeInput
{
    internal class InputLength
    {
        public double Length;
        public double GetLength()
        {
            Console.Write("Enter the length: ");
            try
            {
                return Length = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine($"The length entered is not valid.");
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
