using System;

namespace Rectangles
{
    public static class RectanglesTask
    {
        // Проверка пересечения двух прямоугольников
        public static bool AreIntersected(Rectangle r1, Rectangle r2)
        {
            return r1.Right >= r2.Left && r1.Left <= r2.Right &&
                   r1.Bottom >= r2.Top && r1.Top <= r2.Bottom;
        }

        // Вычисление площади пересечения прямоугольников
        public static int IntersectionSquare(Rectangle r1, Rectangle r2)
        {
            if (!AreIntersected(r1, r2))
                return 0;

            int left = Math.Max(r1.Left, r2.Left);
            int right = Math.Min(r1.Right, r2.Right);
            int top = Math.Max(r1.Top, r2.Top);
            int bottom = Math.Min(r1.Bottom, r2.Bottom);

            return (right - left) * (bottom - top);
        }

        // Определение, вложен ли один прямоугольник в другой
        public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
        {
            if (IsInside(r1, r2))
                return 0;
            if (IsInside(r2, r1))
                return 1;
            return -1;
        }

        // Вспомогательный метод для определения, находится ли один прямоугольник внутри другого
        private static bool IsInside(Rectangle r1, Rectangle r2)
        {
            return r1.Left >= r2.Left && r1.Right <= r2.Right &&
                   r1.Top >= r2.Top && r1.Bottom <= r2.Bottom;
        }
    }
}
