namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о фильме.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Продолжительность фильма в минутах.
        /// </summary>
        private int _durationMinutes;

        /// <summary>
        /// Год релиза фильма.
        /// </summary>
        private int _releaseYear;

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Возвращает и создает рейтинг фильма. Значение принимает от 0 до 10, типа double.
        /// </summary>
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(nameof(Rating), value, 0d, 10d);
                _rating = value;
            }
        }

        /// <summary>
        /// Возвращает и задает длительность фильма в минутах. Не может быть отрицательным значением.
        /// </summary>
        public int DurationMinutes
        {
            get
            {
                return _durationMinutes;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(DurationMinutes));
                _durationMinutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задает год выпуска фильма. Значение принимает от 1900 до 2022 включая.
        /// </summary>
        public int ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                Validator.AssertValueInRange(nameof(ReleaseYear), value, 1900, 2022);
                _releaseYear = value;
            }
        }

        /// <summary>
        /// Возвращает и создает название фильма.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        public Movie()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="name">Название фильма.</param>
        /// <param name="durationMinutes">Продолжительность фильма в минутах. Не может быть отрицательным значением.</param>
        /// <param name="releaseYear">Год выпуска фильма. Значение принимает от 1900 до 2022 включая.</param>
        /// <param name="genre">Жанр фильма</param>
        /// <param name="rating">Рейтинг фильма. Значение принимает от 0 до 10, типа double.</param>
        public Movie(string name, int durationMinutes, int releaseYear, string genre, double rating)
        {
            Name = name;
            DurationMinutes = durationMinutes;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }
    }
}
