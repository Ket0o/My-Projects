namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные об учебных предметах.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Оценка.
        /// </summary>
        private int _mark;

        /// <summary>
        /// Количество часов.
        /// </summary>
        private int _hoursNumber;

        /// <summary>
        /// Возвращает и задает оценку. Принимает значение от 2 до 5 включительно.
        /// </summary>
        public int Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                Validator.AssertValueInRange(nameof(Mark), value, 2, 5);
                _mark = value;
            }
        }

        /// <summary>
        /// Возвращает и задает количество часов по предмету. Не может быть отрицательной.
        /// </summary>
        public int HoursNumber
        {
            get
            {
                return _hoursNumber;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(HoursNumber));
                _hoursNumber = value;
            }
        }

        /// <summary>
        /// Возвращает и задает название предмета.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Subject"/>.
        /// </summary>
        public Subject()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Subject"/>.
        /// </summary>
        /// <param name="mark">Оценка. Принимает значение от 2 до 5 включительно</param>
        /// <param name="name">Название предмета.</param>
        /// <param name="hoursNumber">Количество часов. Не может быть отрицательным.</param>
        public Subject(int mark, string name, int hoursNumber)
        {
            Mark = mark;
            Name = name;
            HoursNumber = hoursNumber;
        }
    }
}
