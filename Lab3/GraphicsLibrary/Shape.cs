using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLibrary
{
    public class Shape
    {
        public Point2D StartPt { get; set; }
        public ConsoleColor Color { get; set; }

        // First constructor
        public Shape(Point2D startPt, ConsoleColor color)
        {
            StartPt = startPt;
            Color = color;
        }

        // Second constructor
        public Shape(int x, int y, ConsoleColor color)
        {
            StartPt = new Point2D(x, y);
            Color = color;
        }

        public virtual void Draw()
        {
            Console.BackgroundColor = Color;
            Console.SetCursorPosition(StartPt.X, StartPt.Y);
            Console.Write(" ");
            Console.ResetColor();
        }
    }
}
