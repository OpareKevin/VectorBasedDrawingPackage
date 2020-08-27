using System;
using System.Drawing;

namespace VectorBasedDrawingPackage
{
    public class Rectangle : Widget
    {

        public int Width { get; }

        public int Height { get; }

        public Rectangle( int width, int height, Point position) : base("Rectangle", position)
        {
            Width = width;
            Height = height;
        }

        public override string ToString() => $"{base.ToString()} width={Width} height={Height}";
    }
}
