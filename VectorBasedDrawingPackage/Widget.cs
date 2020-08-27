using System;
using System.Drawing;

namespace VectorBasedDrawingPackage
{
    public abstract class Widget
    {

        protected string name = "";

        public Point Position { get; }

        public Widget(string name, Point position)
        {
            this.name = name;
            Position = position;
        }

         public override string ToString() => $"{name} ({Position.X},{Position.Y})";

    }

}
