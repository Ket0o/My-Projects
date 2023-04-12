using System.Drawing;

namespace Programming.Model.Classes
{
    /// <summary>
    /// хранит данные о цветах 
    /// </summary>
    public static class AppColors
    {
        /// <summary>
        /// Переменная цвета, когда ничего не происходит
        /// </summary>
        public static Color CorrectColor = Color.White;

        /// <summary>
        /// Переменная цвета при ошибке
        /// </summary>
        public static Color ErrorColor = Color.LightPink;

        /// <summary>
        /// Переменная цвета, если прямоугольники пересекаются
        /// </summary>
        public static Color IsCollisionTrue = Color.FromArgb(127, 255, 127, 127);

        /// <summary>
        /// Переменная цвета, если прямоугольники не пересекаются
        /// </summary>
        public static Color IsCollisionFalse = Color.FromArgb(127, 127, 255, 127);
    }
}
