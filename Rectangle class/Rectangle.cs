


using Generics_Homework.Shape_Class;

namespace Generics_Homework.Rectangle_class
{
    public class Rectangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }

        public override double GetArea()
        {
            return SideB * SideA;
        }
        public override double GetPerimeter()
        {
            return 2 * (SideA + SideB);
        }
    }
}