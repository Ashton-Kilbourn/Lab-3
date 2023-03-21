using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLibrary
{
    public class Triangle : Shape
    {
        public Point2D P2 { get; set; }
        public Point2D P3 { get; set; }
        private List<Line> _lines;

        public Triangle(Point2D p1, Point2D p2, Point2D p3, ConsoleColor color)
            : base(p1, color)
        {
            P2 = p2;
            P3 = p3;

            // create 3 lines
            _lines = new List<Line>();
            _lines.Add(new Line(p1, P2, color));
            _lines.Add(new Line(P2, P3, color));
            _lines.Add(new Line(P3, p1, color));
        }

        public override void Draw()
        {
            foreach (Line line in _lines)
            {
                line.Draw();
            }
        }
    }
}
