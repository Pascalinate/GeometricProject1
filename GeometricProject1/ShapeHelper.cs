// Function: to choose shapes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GeometricProject1
{
    enum Shape
    {
        Circle, Cube, Cuboid, Cylinder, Cone
    }
    class ShapeHelper
    {
        public static IShape ShapeChoice(int shapeId)
        {
            if (shapeId == 1)
            {
                return new Shapes.Sphere();
            }
            if (shapeId == 2)
            {
                return new Shapes.Cube();
            }
            if (shapeId == 3)
            {
                return new Shapes.Cuboid();
            }
            if (shapeId == 4)
            {
                return new Shapes.Cylinder();
            }
            if (shapeId == 5)
            {
                return new Shapes.Cone();
            }
            else
            {
                return null;
            }
        }

        public static int ChooseShape()
        {
            int shapeId;

            Console.WriteLine(@"****************** WELCOME ******************
Choose a geometric shape: 
    1. Sphere
    2. Cube
    3. Cuboid
    4. Cylinder
    5. Cone
Press -1 to exit.
");

            shapeId = !int.TryParse(Console.ReadLine(), out shapeId) ? 0 : shapeId;
            return shapeId;

        }
    }
}
