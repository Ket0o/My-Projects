using Programming.Model.Classes;
using Programming.Model.Enums;
using System;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    /// <summary>
    /// Реализация по представлению фильмов.
    /// </summary>
    public partial class MoviesControl : UserControl
    {
        /// <summary>
        /// Количество элементов.
        /// </summary>
        private const int ElementsCount = 5;

        /// <summary>
        /// Массив фильмов.
        /// </summary>
        private Movie[] _movies;

        /// <summary>
        /// Выбранный фильм.
        /// </summary>
        private Movie _currentMovie;

        /// <summary>
        /// Переменная псевдо-случайных чисел.
        /// </summary>
        private Random _random;

        /// <summary>
        /// Создает экземпляр класса <see cref="MoviesControl"/>.
        /// </summary>
        public MoviesControl()
        {
            InitializeComponent();

            _random = new Random();

            InitMovies();
        }

        /// <summary>
        /// Инициализирует массив фильмов.
        /// </summary>
        private void InitMovies()
        {
            _movies = new Movie[ElementsCount];

            var genres = Enum.GetValues(typeof(Genre));
            for (int i = 0; i < ElementsCount; i++)
            {
                _currentMovie = new Movie();
                _currentMovie.Rating = _random.Next(101) / 10.0;
                _currentMovie.ReleaseYear = _random.Next(1900, 2023);
                _currentMovie.Genre = genres.GetValue(_random.Next(0, genres.Length)).ToString();
                _currentMovie.Name = $"Movie {_currentMovie.Genre} {_currentMovie.ReleaseYear}";
                _currentMovie.DurationMinutes = _random.Next(151);
                _movies[i] = _currentMovie;
                MovieListBox.Items.Add($"Movie {i + 1}");
            }
            MovieListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Находит фильм, чей рейтинг больше остальных.
        /// </summary>
        /// <param name="movies">Массив фильмов.</param>
        /// <returns>Возвращает индекс элемента, чей рейтинг больше остальных.</returns>
        private int FindMovieWithMaxRating(Movie[] movies)
        {
            int maxRatingIndex = 0;
            double max = 0;
            for (int i = 0; i < ElementsCount; i++)
            {
                if (movies[i].Rating > max)
                {
                    max = movies[i].Rating;
                    maxRatingIndex = i;
                }
            }
            return maxRatingIndex;
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int movieSelectedIndex = MovieListBox.SelectedIndex;
            _currentMovie = _movies[movieSelectedIndex];
            MovieNameTextBox.Text = _currentMovie.Name;
            MovieGenreTextBox.Text = _currentMovie.Genre;
            MovieYearReleaseTextBox.Text = _currentMovie.ReleaseYear.ToString();
            MovieDurationMinutesTextBox.Text = _currentMovie.DurationMinutes.ToString();
            MovieRatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        private void MovieNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string movieName = MovieNameTextBox.Text;
            _currentMovie.Name = movieName;
        }

        private void MovieGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            string movieGenre = MovieGenreTextBox.Text;
            _currentMovie.Genre = movieGenre;
        }

        private void MovieRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentRating = MovieRatingTextBox.Text;
                double movieRating = double.Parse(currentRating);
                _currentMovie.Rating = movieRating;
            }
            catch
            {
                MovieRatingTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            MovieRatingTextBox.BackColor = AppColors.CorrectColor;
        }

        private void MovieYearReleaseTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentYearRelease = MovieYearReleaseTextBox.Text;
                int movieReleaseYear = int.Parse(currentYearRelease);
                _currentMovie.ReleaseYear = movieReleaseYear;
            }
            catch
            {
                MovieYearReleaseTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            MovieYearReleaseTextBox.BackColor = AppColors.CorrectColor;
        }

        private void MovieDurationMinutesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string durationAsString = MovieDurationMinutesTextBox.Text;
                int durationInMinutes = int.Parse(durationAsString);
                _currentMovie.DurationMinutes = durationInMinutes;
            }
            catch
            {
                MovieDurationMinutesTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            MovieDurationMinutesTextBox.BackColor = AppColors.CorrectColor;
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            int findMaxRatingIndex = FindMovieWithMaxRating(_movies);
            MovieListBox.SelectedIndex = findMaxRatingIndex;
        }
    }
}
