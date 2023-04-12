using Programming.Model.Classes;
using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Создает окружность.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Внешний радиус.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Внутренний радиус.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Возвращает и задает внешний радиус. Не может быть отрицательным. 
        /// Может быть в диапозоне от значения внутреннего радиуса до наибольшего возможного значения типа double (включая их).
        /// Изменить вне класса нельзя.
        /// </summary>
        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));
                Validator.AssertValueInRange(nameof(OuterRadius), value, _innerRadius, double.MaxValue);
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задает внутренний радиус. Не может быть отрицательным.
        /// Может быть в диапозоне от 0 до значения внешнего радиуса (включая их).
        /// Изменить вне класса нельзя.
        /// </summary>
        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));
                Validator.AssertValueInRange(nameof(InnerRadius), value, 0, _outerRadius);
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задает площадь окружности. Доступно только для чтения.
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * (_outerRadius * _outerRadius - _innerRadius * _innerRadius);
            }
        }

        /// <summary>
        /// Возвращает и задает координаты центра окружности.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="center">Координаты центра окружности.</param>
        /// <param name="outerRadius">Внешний радиус. Не может быть отрицательным. 
        /// Может быть в диапозоне от значения внутреннего радиуса до наибольшего возможного значения типа double (включая их).</param>
        /// <param name="innerRadius">Внутренний радиус. Не может быть отрицательным.
        /// Может быть в диапозоне от 0 до значения внешнего радиуса (включая их).</param>
        public Ring(Point2D center,
                   double outerRadius,
                   double innerRadius)
        {
            Center = center;
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;

        }
    }
}
