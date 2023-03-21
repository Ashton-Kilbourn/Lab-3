using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace GraphicsLibrary
{
        public class Circle : Shape
        {
            public int Radius { get; set; }

            public Circle(int radius, Point2D startPt, ConsoleColor color)
                : base(startPt, color)
            {
                Radius = radius;
            }

            private void Plot(int x, int y)
            {
                x = Math.Max(0, x);
                y = Math.Max(0, y);

                Console.SetCursorPosition(x, y);
                Console.Write(" ");
            }

            private void DrawCirclePoints(int xc, int yc, int x, int y)
            {
                Plot(xc + x, yc + y);
                Plot(xc - x, yc + y);
                Plot(xc + x, yc - y);
                Plot(xc - x, yc - y);
                Plot(xc + y, yc + x);
                Plot(xc - y, yc + x);
                Plot(xc + y, yc - x);
                Plot(xc - y, yc - x);
            }

            private void DrawCircle(int xc, int yc, int r)
            {
                int x = 0, y = r;
                int d = 3 - 2 * r;
                DrawCirclePoints(xc, yc, x, y);
                while (y >= x)
                {
                    x = x + 1;
                    if (d > 0)
                    {
                        y = y - 1;
                        d = d + 4 * (x - y) + 10;
                    }
                    else
                    {
                        d = d + 4 * x + 6;
                    }
                    DrawCirclePoints(xc, yc, x, y);
                }
            }

            public override void Draw()
            {
                Console.BackgroundColor = Color;
                DrawCircle((int)StartPt.X, (int)StartPt.Y, Radius);
                Console.ResetColor();
            }
        }
}

