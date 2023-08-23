

//    C# Advanced-04 Generics and Extension Methods
//Homework
//1 Create a (abstract?)class Shape that has Id and methods GetArea and GetPerimeter.// 
//2 Create a class Circle, with property Radius that inherits from Shape.
//3 Create a class Rectangle, with properties SideA and SideB that inherits from Shape.
//4 Create a class GenericDb that holds a list of generic objects, that have a type that
//inherits from Shape. 
//•5 Create methods in the GenericDb that print the areas and perimeters of all shapes in
//the list.(GENERIC METHODS)
//Create generic db for both types and call the methods of the db.
//• Add extension methods for Circle and Rectangle, that print info for these types.
using System;
using System.Collections.Generic;
using Generics_Homework.Circle_Class;
using Generics_Homework.Rectangle_class;
using Generics_Homework.Shape_Class;
using Generics_Homework.Extensions;

namespace Generics_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle()
            {
                Id = 1,
                Radius = 50
            };

            Rectangle rectangle = new Rectangle()
            {
                Id = 2,
                SideA = 50,
                SideB = 100
            };

            GenericDB<Shape> genDB = new GenericDB<Shape>();
            genDB.Gen.Add(circle);
            genDB.Gen.Add(rectangle);

            genDB.PrintAreas();
            genDB.PrintPerimeters();

            circle.PrintInfo();
            rectangle.PrintInfo();
        }
    }
}