using System;
using System.Drawing;
namespace Poligonos
{
    class Primitivas
    {
        public static void ponto_medio_circunf(int x1, int y1, int x2, int y2, Color c, Bitmap image)
        {
            int x = 0;
            int y = (int)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double d = 1 - y;
            simetria(x, y, x1, y1, c, image);
            while (y > x)
            {
                if (d < 0)
                    d += 2 * x + 3;
                else
                {
                    d += 2 * (x - y) + 5;
                    y--;
                }
                x++;
                simetria(x, y, x1, y1, c, image);
            }
        }

        public static void ponto_medio_elipse(int x1, int y1, int x2, int y2, Color c, Bitmap image)
        {
            double d1, d2;
            int a = Math.Abs(x2 - x1), b = Math.Abs(y2 - y1);
            int x = 0;
            int y = b;

            d1 = b * b - a * a * b + a * a / 4.0;
            simetria4(x, y, x1, y1, c, image);
            while (a * a * (y - 0.5) > b * b * (x + 1))
            {
                if (d1 < 0)
                {
                    d1 = d1 + b * b * (2 * x + 3);
                    x++;
                }
                else
                {
                    d1 = d1 + b * b * (2 * x + 3) + a * a * (-2 * y + 2);
                    x++;
                    y--;
                }
                simetria4(x, y, x1, y1, c, image);
            }
            d2 = b * b * (x + 0.5) * (x + 0.5) + a * a * (y - 1) * (y - 1) - a * a * b * b;
            while (y > 0)
            {
                if (d2 < 0)
                {
                    d2 = d2 + b * b * (2 * x + 2) + a * a * (-2 * y + 3);
                    x++;
                    y--;
                }
                else
                {
                    d2 = d2 + a * a * (-2 * y + 3);
                    y--;
                }
                simetria4(x, y, x1, y1, c, image);
            }
        }

        private static void simetria4(int x, int y, int cx, int cy, Color c, Bitmap image)
        {
            if (cx + x < image.Width && cy + y < image.Height)
                image.SetPixel(cx + x, cy + y, c);
            if (cx + x < image.Width && cy - y > 0)
                image.SetPixel(cx + x, cy - y, c);
            if (cy + y < image.Height && cx - x > 0)
                image.SetPixel(cx - x, cy + y, c);
            if (cx - x > 0 && cy - y > 0)
                image.SetPixel(cx - x, cy - y, c);
        }

        private static void simetria(int x, int y, int cx, int cy, Color c, Bitmap image)
        {
            if (cx + x < image.Width && cy + y < image.Height)
                image.SetPixel(cx + x, cy + y, c);
            if (cx + y < image.Width && cy + x < image.Height)
                image.SetPixel(cx + y, cy + x, c);
            if (cx + y < image.Width && cy - x > 0)
                image.SetPixel(cx + y, cy - x, c);
            if (cx + x < image.Width && cy - y > 0)
                image.SetPixel(cx + x, cy - y, c);
            if (cx - x > 0 && cy - y > 0)
                image.SetPixel(cx - x, cy - y, c);
            if (cx - y > 0 && cy - x > 0)
                image.SetPixel(cx - y, cy - x, c);
            if (cx - y > 0 && cy + x < image.Height)
                image.SetPixel(cx - y, cy + x, c);
            if (cx - x > 0 && cy + y < image.Height)
                image.SetPixel(cx - x, cy + y, c);
        }

        public static void bresenham(int x1, int y1, int x2, int y2, Color c, Bitmap image)
        {
            int declive = 1;
            int dx, dy, incE, incNE, d, x, y;
            dx = x2 - x1;
            dy = y2 - y1;
            if (Math.Abs(dx) >= Math.Abs(dy))
            {
                if (x2 < x1)
                    bresenham(x2, y2, x1, y1, c, image);
                else
                {
                    if (dy < 0)
                    {
                        declive = -1;
                        dy = -dy;
                    }

                    incE = 2 * dy;
                    incNE = 2 * (dy - dx);
                    d = incE - dx;
                    y = y1;
                    for (x = x1; x <= x2; x++)
                    {

                        if (x > 0 && y > 0 && x < image.Width && y < image.Height)
                            image.SetPixel(x, y, c);
                        if (d <= 0)
                            d += incE;
                        else
                        {
                            d += incNE;
                            y += declive;
                        }
                    }
                }
            }
            else
            {
                if (y2 < y1)
                    bresenham(x2, y2, x1, y1, c, image);
                else
                {
                    if (dx < 0)
                    {
                        declive = -1;
                        dx = -dx;
                    }

                    incE = 2 * dx;
                    incNE = 2 * (dx - dy);
                    d = incE - dy;
                    x = x1;
                    for (y = y1; y <= y2; y++)
                    {
                        if (x > 0 && y > 0 && x < image.Width && y < image.Height)
                            image.SetPixel(x, y, c);
                        if (d <= 0)
                            d += incE;
                        else
                        {
                            d += incNE;
                            x += declive;
                        }
                    }
                }
            }
        }
    }
}
