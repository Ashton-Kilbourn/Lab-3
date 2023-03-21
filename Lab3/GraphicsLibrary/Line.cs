using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLibrary
{
    public class Line : Shape
    {
        public Point2D EndPt { get; set; }

        public Line(Point2D startPt, Point2D endPt, ConsoleColor color) : base(startPt, color)
        {
            EndPt = endPt;
        }

        private void PlotLine(int x0, int y0, int x1, int y1)
        {
            int dx = Math.Abs(x1 - x0);
            int sx = x0 < x1 ? 1 : -1;
            int dy = -Math.Abs(y1 - y0);
            int sy = y0 < y1 ? 1 : -1;
            int error = dx + dy;

            while (true)
            {
                Plot(x0, y0);
                if (x0 == x1 && y0 == y1) break;
                int e2 = 2 * error;
                if (e2 >= dy)
                {
                    if (x0 == x1) break;
                    error += dy;
                    x0 += sx;
                }

                if (e2 <= dx)
                {
                    if (y0 == y1) break;
                    error += dx;
                    y0 += sy;
                }
            }
        }

        private void Plot(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }

        public override void Draw()
        {
            Console.BackgroundColor = Color;
            PlotLine(StartPt.X, StartPt.Y, EndPt.X, EndPt.Y);
            Console.ResetColor();
        }
    }
}
