using System;
using System.Collections.Generic;
using System.Drawing;

namespace VectorBasedDrawingPackage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Widget> widgets = new List<Widget>()
            {
                new Rectangle(30,40,new Point(10,10)),

                new Square(35,new Point(15,30)),

                new Ellipse(300, 200, new Point(100, 150)),

                new Circle(300, new Point(1, 1)),

                new Textbox("sample text", 200, 100, new Point(5, 5)),
            };

            Print(widgets);
        }

        static void Print(List<Widget> widgets)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Requested Drawing");
            Console.WriteLine("------------------------------------------------");

            foreach (var widget in widgets)
            {
                Console.WriteLine(widget);
            }
        }
    }
}
