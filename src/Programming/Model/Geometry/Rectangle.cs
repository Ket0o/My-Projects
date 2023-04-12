using Programming.Model.Classes;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о прямоугольниках.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Количество всех прямоугольников.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// Высота.
        /// </summary>
        private int _height;

        /// <summary>
        /// Ширина.
        /// </summary>
        private int _width;

        /// <summary>
        /// Уникальный идентификатор для всех объектов класса.
        /// </summary>
        private int _id;

        /// <summary>
        /// Возвращает и задает количество всех прямоугольников. 
        /// </summary>
        public static int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
        }

        /// <summary>
        /// Возвращает и задает высоту. Не может быть отрицательной.
        /// </summary>
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Length");
                _height = value;
            }
        }

        /// <summary>
        /// Возвращает и задает ширину. Не может быть отрицательной.
        /// </summary>
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Width");
                _width = value;
            }
        }

        /// <summary>
        /// Возвращает и задает уникальный индефикатор. Доступно только для чтения.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Возвращает и задает координаты центра фигуры.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и зададет цвет.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        public Rectangle()
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="height">Высота. Не может быть отрицательной.</param>
        /// <param name="width">Ширина. Не может быть отрицательной.</param>
        /// <param name="color">Цвет.</param>
        /// <param name="center">Координаты центра фигуры.</param>
        public Rectangle(int height, int width, string color, Point2D center)
        {
            Height = height;
            Width = width;
            Color = color;
            Center = center;
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }
    }
}
