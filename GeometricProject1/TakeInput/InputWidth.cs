using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject1.TakeInput
{
 
    class InputWidth
    {   
        public double Width;
        public double GetWidth()
        {
             Console.Write("Enter the width: ");
                try
                {
                    return Width = double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine($"The width entered is not valid.");
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
