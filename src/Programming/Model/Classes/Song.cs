namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о песнях.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Длительность в секундах.
        /// </summary>
        private int _durationSeconds;

        /// <summary>
        /// Возвращает и задает длительность песни в секундах. Не может быть отрицательным.
        /// </summary>
        public int DurationSeconds
        {
            get
            {
                return _durationSeconds;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(DurationSeconds));
                _durationSeconds = value;
            }
        }

        /// <summary>
        /// Возвращает и задает название песни.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает автора песни.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Song"/>.
        /// </summary>
        public Song()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="name">Название песни.</param>
        /// <param name="author">Автор песни.</param>
        /// <param name="durationSeconds">Длительность песни в секундах. Не может быть отрицательным.</param>
        public Song(string name, string author, int durationSeconds)
        {
            Name = name;
            Author = author;
            DurationSeconds = durationSeconds;
        }
    }
}
