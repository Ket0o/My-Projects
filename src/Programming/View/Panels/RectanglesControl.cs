using Programming.Model.Classes;
using Programming.Model.Enums;
using Programming.Model.Geometry;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Rectangle = Programming.Model.Geometry.Rectangle;

namespace Programming.View.Panels
{
    /// <summary>
    /// Реализация по представлению прямоугольников, генерируемых программой.
    /// </summary>
    public partial class RectanglesControl : UserControl
    {
        /// <summary>
        /// Количество элементов.
        /// </summary>
        private const int ElementsCount = 5;

        /// <summary>
        /// Коллекция прямоугольников.
        /// </summary>
        private List<Rectangle> _rectangles;

        /// <summary>
        /// Выюранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Создает экземпляр класса <see cref="RectanglesControl"/>.
        /// </summary>
        public RectanglesControl()
        {
            InitializeComponent();

            _rectangles = new List<Rectangle>();

            InitRectangles();
        }

        /// <summary>
        /// Инициализирует коллекцию прямоугольников.
        /// </summary>
        private void InitRectangles()
        {
            var colors = Enum.GetValues(typeof(Colors));
            for (int i = 0; i < ElementsCount; i++)
            {
                _currentRectangle = RectangleFactory.Randomize();
                RectanglesListBox.Items.Add($"Rectangle {i + 1}");
                _rectangles.Add(_currentRectangle);
            }
            RectanglesListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Находит прямоугольник, чья ширина больше остальных.
        /// </summary>
        /// <param name="rectangles">Прямоугольник.</param>
        /// <returns>Индекс элемента коллекции, чья ширина больше остальных.</returns>
        private int FindRectangleWithMaxWidth(List<Rectangle> rectangles)
        {
            int maxWidthIndex = 0;
            double max = 0;
            for (int i = 0; i < ElementsCount; i++)
            {
                if (rectangles[i].Width > max)
                {
                    max = rectangles[i].Width;
                    maxWidthIndex = i;
                }
            }
            return maxWidthIndex;
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedItem != null)
            {
                int selectedIndexRectangle = RectanglesListBox.SelectedIndex;
                _currentRectangle = _rectangles[selectedIndexRectangle];
                LengthRectangleTextBox.Text = _currentRectangle.Height.ToString();
                WidthRectangleTextBox.Text = _currentRectangle.Width.ToString();
                ColorRectangleTextBox.Text = _currentRectangle.Color;
                XRectangleTextBox.Text = _currentRectangle.Center.X.ToString();
                YRectangleTextBox.Text = _currentRectangle.Center.Y.ToString();
                IdRectangleTextBox.Text = _currentRectangle.Id.ToString();
            }
        }

        private void LengthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string rectnagleCurrentLength = LengthRectangleTextBox.Text;
                int rectangleLength = int.Parse(rectnagleCurrentLength);
                _currentRectangle.Height = rectangleLength;
            }
            catch
            {
                LengthRectangleTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            LengthRectangleTextBox.BackColor = AppColors.CorrectColor;
        }

        private void WidthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string rectangleCurrentWidt = WidthRectangleTextBox.Text;
                int rectangleWidth = int.Parse(rectangleCurrentWidt);
                _currentRectangle.Width = rectangleWidth;
            }
            catch
            {
                WidthRectangleTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            WidthRectangleTextBox.BackColor = AppColors.CorrectColor;
        }

        private void ColorRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            string rectangleCurrentColor = ColorRectangleTextBox.Text;
            _currentRectangle.Color = rectangleCurrentColor;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            int findMaxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
            RectanglesListBox.SelectedIndex = findMaxWidthIndex;
        }
    }
}
