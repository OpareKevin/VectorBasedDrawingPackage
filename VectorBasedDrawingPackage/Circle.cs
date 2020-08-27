using System;
using System.Drawing;

namespace VectorBasedDrawingPackage
{
    public class Circle : Widget
    {
        public int Diameter { get; }

        public Circle(int diameter, Point position) : base("Circle", position)
        {
            Diameter = diameter;
        }

        public override string ToString() => $"{base.ToString()} size={Diameter} ";
    }
}
