using Programming.Model.Classes;
using Programming.Model.Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Rectangle = Programming.Model.Geometry.Rectangle;

namespace Programming.View.Panels
{
    /// <summary>
    /// Реализация по представлению прямоугольников.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
    {
        /// <summary>
        /// Коллекция прямоугольников.
        /// </summary>
        private List<Rectangle> _rectangles;

        /// <summary>
        /// Коллекция отображаемых прямоугольников.
        /// </summary>
        private List<Panel> _rectanglePanels;

        /// <summary>
        /// Выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Создает экземпляр класса <see cref="RectanglesCollisionControl"/>.
        /// </summary>
        public RectanglesCollisionControl()
        {
            InitializeComponent();

            _rectanglePanels = new List<Panel>();

            _rectangles = new List<Rectangle>();
        }

        /// <summary>
        /// Находит пересекающиеся прямоугольники и перекрашивает их в красный цвет.
        /// </summary>
        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                CanvasPanel.Controls[i].BackColor = AppColors.IsCollisionFalse;
            }

            for (int i = 0; i < _rectanglePanels.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectanglePanels.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        CanvasPanel.Controls[i].BackColor = AppColors.IsCollisionTrue;
                        CanvasPanel.Controls[j].BackColor = AppColors.IsCollisionTrue;
                    }
                }
            }
        }

        /// <summary>
        /// Из данных прямоугольника, собирает форматированную строку.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        /// <returns>Возвращает форматированную строку.</returns>
        private string FormatRectangle(Rectangle rectangle)
        {
            string lineOutputRectangle = $"{rectangle.Id}: " +
                                         $"(X= {rectangle.Center.X};" +
                                         $" Y= {rectangle.Center.Y};" +
                                         $" W= {rectangle.Width};" +
                                         $" H= {rectangle.Height})";
            return lineOutputRectangle;
        }

        /// <summary>
        /// Очищает информацию с текстовых полей и со списка.
        /// </summary>
        private void ClearReactangleInfo()
        {
            ListBoxRectanglesTabPage.Items.Clear();
            IdRectangle.Clear();
            XRectangle.Clear();
            YRectangle.Clear();
            WidthRectangle.Clear();
            HeightRectangle.Clear();
        }

        /// <summary>
        /// Обновляет информацию в списке.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            int ind = ListBoxRectanglesTabPage.FindString(rectangle.Id.ToString());

            if (ind == -1) return;

            ListBoxRectanglesTabPage.Items[ind] = FormatRectangle(rectangle);
        }

        private void ListBoxRectanglesTabPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxRectanglesTabPage.SelectedItem != null)
            {
                int indexSelectedRectangle = ListBoxRectanglesTabPage.SelectedIndex;
                _currentRectangle = _rectangles[indexSelectedRectangle];
                IdRectangle.Text = _currentRectangle.Id.ToString();
                XRectangle.Text = _currentRectangle.Center.X.ToString();
                YRectangle.Text = _currentRectangle.Center.Y.ToString();
                WidthRectangle.Text = _currentRectangle.Width.ToString();
                HeightRectangle.Text = _currentRectangle.Height.ToString();
            }
        }

        private void HeightRectangle_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxRectanglesTabPage.SelectedIndex == -1)
                return;
            try
            {
                string rectnagleCurrentHeight = HeightRectangle.Text;
                int rectangleHeight = int.Parse(rectnagleCurrentHeight);
                _currentRectangle.Height = rectangleHeight;
                CanvasPanel.Controls[ListBoxRectanglesTabPage.SelectedIndex].Height = _currentRectangle.Height;
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                HeightRectangle.BackColor = AppColors.ErrorColor;
                return;
            }
            HeightRectangle.BackColor = AppColors.CorrectColor;
        }

        private void WidthRectangle_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxRectanglesTabPage.SelectedIndex == -1)
                return;
            try
            {
                string rectnagleCurrentWidth = WidthRectangle.Text;
                int rectangleWidth = int.Parse(rectnagleCurrentWidth);
                _currentRectangle.Width = rectangleWidth;
                CanvasPanel.Controls[ListBoxRectanglesTabPage.SelectedIndex].Width = _currentRectangle.Width;
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                WidthRectangle.BackColor = AppColors.ErrorColor;
                return;
            }
            WidthRectangle.BackColor = AppColors.CorrectColor;
        }

        private void XRectangle_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxRectanglesTabPage.SelectedIndex == -1)
                return;
            try
            {
                string rectnagleCurrentX = XRectangle.Text;
                int rectangleX = int.Parse(rectnagleCurrentX);
                _currentRectangle.Center.X = rectangleX;
                CanvasPanel.Controls[ListBoxRectanglesTabPage.SelectedIndex].Location =
                    new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                XRectangle.BackColor = AppColors.ErrorColor;
                return;
            }
            XRectangle.BackColor = AppColors.CorrectColor;
        }

        private void YRectangle_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxRectanglesTabPage.SelectedIndex == -1)
                return;
            try
            {
                string rectnagleCurrentY = YRectangle.Text;
                int rectangleY = int.Parse(rectnagleCurrentY);
                _currentRectangle.Center.Y = rectangleY;
                CanvasPanel.Controls[ListBoxRectanglesTabPage.SelectedIndex].Location =
                    new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                YRectangle.BackColor = AppColors.ErrorColor;
                return;
            }
            YRectangle.BackColor = AppColors.CorrectColor;
        }

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            _currentRectangle = RectangleFactory.Randomize();
            _rectangles.Add(_currentRectangle);
            ListBoxRectanglesTabPage.Items.Add(FormatRectangle(_currentRectangle));

            Panel rectanglePanel = new Panel();
            rectanglePanel.Width = _currentRectangle.Width;
            rectanglePanel.Height = _currentRectangle.Height;
            rectanglePanel.Location = new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
            rectanglePanel.BackColor = AppColors.IsCollisionTrue;
            _rectanglePanels.Add(rectanglePanel);
            CanvasPanel.Controls.Add(rectanglePanel);

            FindCollisions();
        }

        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            int index = ListBoxRectanglesTabPage.SelectedIndex;
            if (index != -1)
            {
                _rectangles.RemoveAt(index);
                _rectanglePanels.RemoveAt(index);
                ListBoxRectanglesTabPage.Items.RemoveAt(index);
                CanvasPanel.Controls.RemoveAt(index);
                FindCollisions();
                ClearReactangleInfo();

                for (int i = 0; i < _rectangles.Count; i++)
                {
                    ListBoxRectanglesTabPage.Items.Add(FormatRectangle(_rectangles[i]));
                    ListBoxRectanglesTabPage.SelectedIndex = 0;
                }
            }
        }

        private void AddRectangleButton_MouseEnter(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24;
        }

        private void AddRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void RemoveRectangleButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Properties.Resources.rectangle_remove_24x24;
        }

        private void RemoveRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Properties.Resources.rectangle_remove_24x24_uncolor;
        }
    }
}
