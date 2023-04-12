using Programming.Model.Enums;
using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Класс создает прямоугольники.
    /// </summary>
    public static class RectangleFactory
    {
        /// <summary>
        /// Переменная псевдо-случайных чисел.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Создание прямоугольника со случайными значениями.
        /// </summary>
        /// <returns></returns>
        public static Rectangle Randomize()
        {
            var colors = Enum.GetValues(typeof(Colors));
            Rectangle rectangle = new Rectangle();
            rectangle.Width = _random.Next(30, 100);
            rectangle.Height = _random.Next(30, 100);
            rectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
            rectangle.Center = new Point2D(_random.Next(1, 350), _random.Next(1, 350));
            return rectangle;
        }
    }
}
