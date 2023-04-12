namespace Programming.View
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Classes_TabPage = new System.Windows.Forms.TabPage();
            this.Enums_tabPage = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Rectangles_TabPage = new System.Windows.Forms.TabPage();
            this.seasonsControl1 = new Programming.View.Panels.SeasonsControl();
            this.allEnumerationsControl1 = new Programming.View.Panels.AllEnumerationsControl();
            this.rectanglesControl1 = new Programming.View.Panels.RectanglesControl();
            this.moviesControl1 = new Programming.View.Panels.MoviesControl();
            this.rectanglesCollisionControl1 = new Programming.View.Panels.RectanglesCollisionControl();
            this.weekdayParsingControl1 = new Programming.View.Panels.WeekdayParsingControl();
            this.Classes_TabPage.SuspendLayout();
            this.Enums_tabPage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Rectangles_TabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Classes_TabPage
            // 
            this.Classes_TabPage.Controls.Add(this.rectanglesControl1);
            this.Classes_TabPage.Controls.Add(this.moviesControl1);
            this.Classes_TabPage.Location = new System.Drawing.Point(4, 29);
            this.Classes_TabPage.Name = "Classes_TabPage";
            this.Classes_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Classes_TabPage.Size = new System.Drawing.Size(1014, 645);
            this.Classes_TabPage.TabIndex = 1;
            this.Classes_TabPage.Text = "Classes";
            this.Classes_TabPage.UseVisualStyleBackColor = true;
            // 
            // Enums_tabPage
            // 
            this.Enums_tabPage.Controls.Add(this.weekdayParsingControl1);
            this.Enums_tabPage.Controls.Add(this.seasonsControl1);
            this.Enums_tabPage.Controls.Add(this.allEnumerationsControl1);
            this.Enums_tabPage.Location = new System.Drawing.Point(4, 29);
            this.Enums_tabPage.Name = "Enums_tabPage";
            this.Enums_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Enums_tabPage.Size = new System.Drawing.Size(1014, 645);
            this.Enums_tabPage.TabIndex = 0;
            this.Enums_tabPage.Text = "Enums";
            this.Enums_tabPage.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Enums_tabPage);
            this.tabControl1.Controls.Add(this.Classes_TabPage);
            this.tabControl1.Controls.Add(this.Rectangles_TabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1022, 678);
            this.tabControl1.TabIndex = 0;
            // 
            // Rectangles_TabPage
            // 
            this.Rectangles_TabPage.Controls.Add(this.rectanglesCollisionControl1);
            this.Rectangles_TabPage.Location = new System.Drawing.Point(4, 29);
            this.Rectangles_TabPage.Name = "Rectangles_TabPage";
            this.Rectangles_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Rectangles_TabPage.Size = new System.Drawing.Size(1014, 645);
            this.Rectangles_TabPage.TabIndex = 2;
            this.Rectangles_TabPage.Text = "Rectangles";
            this.Rectangles_TabPage.UseVisualStyleBackColor = true;
            // 
            // seasonsControl1
            // 
            this.seasonsControl1.Location = new System.Drawing.Point(494, 418);
            this.seasonsControl1.Name = "seasonsControl1";
            this.seasonsControl1.Size = new System.Drawing.Size(512, 217);
            this.seasonsControl1.TabIndex = 4;
            // 
            // allEnumerationsControl1
            // 
            this.allEnumerationsControl1.Location = new System.Drawing.Point(0, -2);
            this.allEnumerationsControl1.Name = "allEnumerationsControl1";
            this.allEnumerationsControl1.Size = new System.Drawing.Size(1006, 414);
            this.allEnumerationsControl1.TabIndex = 3;
            // 
            // rectanglesControl1
            // 
            this.rectanglesControl1.Location = new System.Drawing.Point(3, 0);
            this.rectanglesControl1.Name = "rectanglesControl1";
            this.rectanglesControl1.Size = new System.Drawing.Size(498, 450);
            this.rectanglesControl1.TabIndex = 2;
            // 
            // moviesControl1
            // 
            this.moviesControl1.Location = new System.Drawing.Point(508, 0);
            this.moviesControl1.Name = "moviesControl1";
            this.moviesControl1.Size = new System.Drawing.Size(506, 456);
            this.moviesControl1.TabIndex = 1;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(0, 0);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(1014, 645);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // weekdayParsingControl1
            // 
            this.weekdayParsingControl1.Location = new System.Drawing.Point(0, 418);
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            this.weekdayParsingControl1.Size = new System.Drawing.Size(490, 217);
            this.weekdayParsingControl1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 678);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.Classes_TabPage.ResumeLayout(false);
            this.Enums_tabPage.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Rectangles_TabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage Classes_TabPage;
        private System.Windows.Forms.TabPage Enums_tabPage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Rectangles_TabPage;
        private Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private Panels.MoviesControl moviesControl1;
        private Panels.RectanglesControl rectanglesControl1;
        private Panels.AllEnumerationsControl allEnumerationsControl1;
        private Panels.SeasonsControl seasonsControl1;
        private Panels.WeekdayParsingControl weekdayParsingControl1;
    }
}

