using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Класс реализует проверку прямоугольников и окружностей на пересечение.
    /// </summary>
    public static class CollisionManager
    {
        /// <summary>
        /// Проверяет прямоугольники на пересечение и возвращает True, если они пересекаются и False, если нет.
        /// </summary>
        /// <param name="rectangle1">Первый прямоугольник для сравнения.</param>
        /// <param name="rectangle2">Второй прямоугольник для сравнения.</param>
        /// <returns></returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            int dX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            int dY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
            double widthDifference = Math.Abs(rectangle1.Width + rectangle2.Width) / 2;
            double lengthDifference = Math.Abs(rectangle1.Height + rectangle2.Height) / 2;

            return rectangle1.Center.X < rectangle2.Center.X + rectangle2.Width &&
                   rectangle1.Center.X + rectangle1.Width > rectangle2.Center.X &&
                   rectangle1.Center.Y < rectangle2.Center.Y + rectangle2.Height &&
                   rectangle1.Height + rectangle1.Center.Y > rectangle2.Center.Y;

        }

        /// <summary>
        /// Проверяет окружности на пересечение и возвращает True, если они пересекаются и False, если нет.
        /// </summary>
        /// <param name="ring1">Первая окружность для сравнения.</param>
        /// <param name="ring2">Вторая окружность для сравнения.</param>
        /// <returns></returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            int dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            int dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double c = Math.Sqrt(dX * dX + dY * dY);

            return c < (ring1.OuterRadius + ring2.OuterRadius);
        }
    }
}
