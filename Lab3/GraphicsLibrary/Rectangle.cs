using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLibrary
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        private List<Line> _lines;

        public Rectangle(int width, int height, Point2D startPt, ConsoleColor color)
              : base(startPt, color)
        {
            Width = width;
            Height = height;

            // Create 4 lines and add them to the _lines field
            _lines = new List<Line>
            {
                new Line(startPt, new Point2D(startPt.X + Width, startPt.Y), color),
                new Line(new Point2D(startPt.X + Width, startPt.Y), new Point2D(startPt.X + Width, startPt.Y + Height), color),
                new Line(new Point2D(startPt.X, startPt.Y + Height), new Point2D(startPt.X + Width, startPt.Y + Height), color),
                new Line(startPt, new Point2D(startPt.X, startPt.Y + Height), color)
            };
        }

        public override void Draw()
        {
            Console.BackgroundColor = Color;
            foreach (Line line in _lines)
            {
                line.Draw();
            }
            Console.ResetColor();
        }
    }
}
