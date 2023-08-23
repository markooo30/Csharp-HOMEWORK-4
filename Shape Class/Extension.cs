using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics_Homework.Extensions;
using Generics_Homework.Circle_Class;
using Generics_Homework.Rectangle_class;

namespace Generics_Homework.Extensions
{
    public static class ShapeExtensions
    {
        public static void PrintInfo(this Circle circle)
        {
            Console.WriteLine($"Circle ID: {circle.Id}, Radius: {circle.Radius}, Area: {circle.GetArea()}, Perimeter: {circle.GetPerimeter()}");
        }

        public static void PrintInfo(this Rectangle rectangle)
        {
            Console.WriteLine($"Rectangle ID: {rectangle.Id}, SideA: {rectangle.SideA}, SideB: {rectangle.SideB}, Area: {rectangle.GetArea()}, Perimeter: {rectangle.GetPerimeter()}");
        }
    }
}