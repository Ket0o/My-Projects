using Programming.Model.Classes;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о координатах центра фигуры.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Координата по X.
        /// </summary>
        private int _x;

        /// <summary>
        /// Координата по Y.
        /// </summary>
        private int _y;

        /// <summary>
        /// Возвращает и задает координату по X. Не может быть отрицательным значением.
        /// </summary>
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(X));
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задает координату по Y. Не может быть отрицательным значением.
        /// </summary>
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Y));
                _y = value;
            }
        }

        /// <summary>
        /// Экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Координата по X. Не может быть отрицательным.</param>
        /// <param name="y">Координата по Y. Не может быть отрицательным.</param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
