using System;
using System.Drawing;

namespace VectorBasedDrawingPackage
{
    public class Ellipse : Widget
    {
        public int HorizontalDiameter { get; }

        public int VerticalDiameter { get; }

        public Ellipse(int diameterH, int diameterV, Point position) : base("Ellipse", position)
        {

            HorizontalDiameter = diameterH;

            VerticalDiameter = diameterV;

        }

        public override string ToString() => $"{base.ToString()} diameterH = {HorizontalDiameter} diameterV = {VerticalDiameter}";
    }
}
