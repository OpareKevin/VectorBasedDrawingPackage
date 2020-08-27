using System;
using System.Drawing;

namespace VectorBasedDrawingPackage
{
    public class Textbox : Widget
    {
      public  Rectangle Box { get; }

      public  string Text { get; }

        public Textbox(string text,int width, int height, Point position) : base("Textbox", position)
        {
            Box = new Rectangle(width, height, position);
            Text = text;
        }

        public override string ToString() => $"{base.ToString()} width={Box.Width} height={Box.Height} Text=\"{Text}\"";
    }
}
