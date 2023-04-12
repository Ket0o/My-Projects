namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о времени.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Часы.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Минуты.
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Секунды.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Возвращает и задает сколько часов. Может принимать значения от 0 до 23 включительно. 
        /// </summary>
        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                Validator.AssertValueInRange(nameof(Hours), value, 0, 23);
                _hours = value;
            }
        }

        /// <summary>
        /// Возвращает и задает сколько минут. Может принимать значения от 0 до 59 включительно.
        /// </summary>
        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                Validator.AssertValueInRange(nameof(Minutes), value, 0, 59);
                _minutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задает сколько секунд. Может принимать значения от 0 до 59 включительно.
        /// </summary>
        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                Validator.AssertValueInRange(nameof(Seconds), value, 0, 59);
                _seconds = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Time"/>.
        /// </summary>
        public Time()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Time"/>.
        /// </summary>
        /// <param name="hours">Часы. Принимает значения от 0 до 23 включительно.</param>
        /// <param name="minutes">Минуты. Принимает значения от 0 до 59 включительно.</param>
        /// <param name="seconds">Секунды. Принимает значения от 0 до 59 включительно.</param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}
