using System;
using System.Drawing;

namespace VectorBasedDrawingPackage
{
    public class Square : Widget
    {
        public int Width { get; }

        public Square(int width, Point position) : base("Square", position)
        {
            Width = width;
        }

        public override string ToString() => $"{base.ToString()} size={Width} ";
    }
}
