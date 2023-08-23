using System;
using System.Collections.Generic;
using Generics_Homework.Circle_Class;
using Generics_Homework.Rectangle_class;
using Generics_Homework.Shape_Class;
using Generics_Homework.Extensions;

namespace Generics_Homework
{
    public class GenericDB2<T> where T : Shape
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public void PrintAll()
        {
            foreach (T item in items)
            {
                if (item is Circle circle)
                {
                    circle.PrintInfo();
                }
                else if (item is Rectangle rectangle)
                {
                    rectangle.PrintInfo();
                }
            }
        }
    }
}