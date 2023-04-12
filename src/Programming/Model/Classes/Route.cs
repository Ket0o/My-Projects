namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о перелетах.
    /// </summary>
    public class Route
    {
        /// <summary>
        /// Время полета в минутах.
        /// </summary>
        private int _flightTimeMinutes;

        /// <summary>
        /// Возвращает и задает время полета в минутах. Значение больше 0.
        /// </summary>
        public int FlightTimeMinutes
        {
            get
            {
                return _flightTimeMinutes;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(FlightTimeMinutes));
                _flightTimeMinutes = value;
            }
        }

        /// <summary>
        /// Точка вылета. Возвращает и задает точку вылета.
        /// </summary>
        public string Departure { get; set; }

        /// <summary>
        /// Точка прибытия. Возвращает и задает точку прибытия.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Route"/>.
        /// </summary>
        public Route()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Route"/>.
        /// </summary>
        /// <param name="departure">Точка вылета.</param>
        /// <param name="destination">Точка прибытия.</param>
        /// <param name="flightTimeMinutes">Время полета в минутах. Не может быть отрицательным.</param>
        public Route(string departure, string destination, int flightTimeMinutes)
        {
            Departure = departure;
            Destination = destination;
            FlightTimeMinutes = flightTimeMinutes;
        }
    }
}
