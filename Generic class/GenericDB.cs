using System;
using System.Collections.Generic;
using Generics_Homework.Circle_Class;
using Generics_Homework.Rectangle_class;
using Generics_Homework.Shape_Class;
using Generics_Homework.Extensions;

namespace Generics_Homework
{
    public class GenericDB<T> where T : Shape
    {
        public List<T> Gen = new List<T>();

        public void PrintAreas()
        {
            foreach (T shape in Gen)
            {
                if (shape is Circle circle)
                {
                    double area = circle.GetArea();
                    Console.WriteLine($"Area of Circle with Id {circle.Id}: {area}");
                }
                else if (shape is Rectangle rectangle)
                {
                    double area = rectangle.GetArea();
                    Console.WriteLine($"Area of Rectangle with Id {rectangle.Id}: {area}");
                }
            }
        }

        public void PrintPerimeters()
        {
            foreach (T shape in Gen)
            {
                if (shape is Circle circle)
                {
                    double perimeter = circle.GetPerimeter();
                    Console.WriteLine($"Perimeter of Circle with Id {circle.Id}: {perimeter}");
                }
                else if (shape is Rectangle rectangle)
                {
                    double perimeter = rectangle.GetPerimeter();
                    Console.WriteLine($"Perimeter of Rectangle with Id {rectangle.Id}: {perimeter}");
                }
            }
        }
    }
}
