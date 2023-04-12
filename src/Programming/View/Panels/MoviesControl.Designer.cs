namespace Programming.View.Panels
{
    partial class MoviesControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MovieGroupBox = new System.Windows.Forms.GroupBox();
            this.MovieRatingTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MovieDurationMinutesTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FindFilmButton = new System.Windows.Forms.Button();
            this.MovieGenreTextBox = new System.Windows.Forms.TextBox();
            this.MovieYearReleaseTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MovieNameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.MovieGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MovieGroupBox
            // 
            this.MovieGroupBox.Controls.Add(this.MovieRatingTextBox);
            this.MovieGroupBox.Controls.Add(this.label10);
            this.MovieGroupBox.Controls.Add(this.MovieDurationMinutesTextBox);
            this.MovieGroupBox.Controls.Add(this.label9);
            this.MovieGroupBox.Controls.Add(this.FindFilmButton);
            this.MovieGroupBox.Controls.Add(this.MovieGenreTextBox);
            this.MovieGroupBox.Controls.Add(this.MovieYearReleaseTextBox);
            this.MovieGroupBox.Controls.Add(this.label5);
            this.MovieGroupBox.Controls.Add(this.label7);
            this.MovieGroupBox.Controls.Add(this.MovieNameTextBox);
            this.MovieGroupBox.Controls.Add(this.label8);
            this.MovieGroupBox.Controls.Add(this.MovieListBox);
            this.MovieGroupBox.Location = new System.Drawing.Point(0, 0);
            this.MovieGroupBox.Name = "MovieGroupBox";
            this.MovieGroupBox.Size = new System.Drawing.Size(500, 448);
            this.MovieGroupBox.TabIndex = 9;
            this.MovieGroupBox.TabStop = false;
            this.MovieGroupBox.Text = "Movie";
            // 
            // MovieRatingTextBox
            // 
            this.MovieRatingTextBox.Location = new System.Drawing.Point(216, 288);
            this.MovieRatingTextBox.Name = "MovieRatingTextBox";
            this.MovieRatingTextBox.Size = new System.Drawing.Size(146, 26);
            this.MovieRatingTextBox.TabIndex = 11;
            this.MovieRatingTextBox.TextChanged += new System.EventHandler(this.MovieRatingTextBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Rating:";
            // 
            // MovieDurationMinutesTextBox
            // 
            this.MovieDurationMinutesTextBox.Location = new System.Drawing.Point(216, 228);
            this.MovieDurationMinutesTextBox.Name = "MovieDurationMinutesTextBox";
            this.MovieDurationMinutesTextBox.Size = new System.Drawing.Size(146, 26);
            this.MovieDurationMinutesTextBox.TabIndex = 9;
            this.MovieDurationMinutesTextBox.TextChanged += new System.EventHandler(this.MovieDurationMinutesTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(212, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = " Duration in minutes:";
            // 
            // FindFilmButton
            // 
            this.FindFilmButton.Location = new System.Drawing.Point(216, 338);
            this.FindFilmButton.Name = "FindFilmButton";
            this.FindFilmButton.Size = new System.Drawing.Size(146, 31);
            this.FindFilmButton.TabIndex = 7;
            this.FindFilmButton.Text = "Find";
            this.FindFilmButton.UseVisualStyleBackColor = true;
            this.FindFilmButton.Click += new System.EventHandler(this.FindMovieButton_Click);
            // 
            // MovieGenreTextBox
            // 
            this.MovieGenreTextBox.Location = new System.Drawing.Point(216, 108);
            this.MovieGenreTextBox.Name = "MovieGenreTextBox";
            this.MovieGenreTextBox.Size = new System.Drawing.Size(146, 26);
            this.MovieGenreTextBox.TabIndex = 4;
            this.MovieGenreTextBox.TextChanged += new System.EventHandler(this.MovieGenreTextBox_TextChanged);
            // 
            // MovieYearReleaseTextBox
            // 
            this.MovieYearReleaseTextBox.Location = new System.Drawing.Point(216, 168);
            this.MovieYearReleaseTextBox.Name = "MovieYearReleaseTextBox";
            this.MovieYearReleaseTextBox.Size = new System.Drawing.Size(146, 26);
            this.MovieYearReleaseTextBox.TabIndex = 6;
            this.MovieYearReleaseTextBox.TextChanged += new System.EventHandler(this.MovieYearReleaseTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Release year:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Genre:";
            // 
            // MovieNameTextBox
            // 
            this.MovieNameTextBox.Location = new System.Drawing.Point(216, 48);
            this.MovieNameTextBox.Name = "MovieNameTextBox";
            this.MovieNameTextBox.Size = new System.Drawing.Size(146, 26);
            this.MovieNameTextBox.TabIndex = 2;
            this.MovieNameTextBox.TextChanged += new System.EventHandler(this.MovieNameTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Name:";
            // 
            // MovieListBox
            // 
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.ItemHeight = 20;
            this.MovieListBox.Location = new System.Drawing.Point(6, 25);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(200, 344);
            this.MovieListBox.TabIndex = 0;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MovieGroupBox);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(506, 456);
            this.MovieGroupBox.ResumeLayout(false);
            this.MovieGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MovieGroupBox;
        private System.Windows.Forms.TextBox MovieRatingTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MovieDurationMinutesTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button FindFilmButton;
        private System.Windows.Forms.TextBox MovieGenreTextBox;
        private System.Windows.Forms.TextBox MovieYearReleaseTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MovieNameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox MovieListBox;
    }
}
