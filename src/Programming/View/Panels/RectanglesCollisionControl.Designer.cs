namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            this.label20 = new System.Windows.Forms.Label();
            this.HeightRectangle = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.WidthRectangle = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.YRectangle = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.XRectangle = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.IdRectangle = new System.Windows.Forms.TextBox();
            this.RemoveRectangleButton = new System.Windows.Forms.Button();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.ListBoxRectanglesTabPage = new System.Windows.Forms.ListBox();
            this.labelRectanglesTabPage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 491);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 20);
            this.label20.TabIndex = 31;
            this.label20.Text = "Height:";
            // 
            // HeightRectangle
            // 
            this.HeightRectangle.Location = new System.Drawing.Point(83, 487);
            this.HeightRectangle.Name = "HeightRectangle";
            this.HeightRectangle.Size = new System.Drawing.Size(134, 26);
            this.HeightRectangle.TabIndex = 30;
            this.HeightRectangle.TextChanged += new System.EventHandler(this.HeightRectangle_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(23, 458);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 20);
            this.label18.TabIndex = 29;
            this.label18.Text = "Width:";
            // 
            // WidthRectangle
            // 
            this.WidthRectangle.Location = new System.Drawing.Point(83, 455);
            this.WidthRectangle.Name = "WidthRectangle";
            this.WidthRectangle.Size = new System.Drawing.Size(134, 26);
            this.WidthRectangle.TabIndex = 28;
            this.WidthRectangle.TextChanged += new System.EventHandler(this.WidthRectangle_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(49, 426);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 20);
            this.label19.TabIndex = 27;
            this.label19.Text = "Y:";
            // 
            // YRectangle
            // 
            this.YRectangle.Location = new System.Drawing.Point(83, 423);
            this.YRectangle.Name = "YRectangle";
            this.YRectangle.Size = new System.Drawing.Size(134, 26);
            this.YRectangle.TabIndex = 26;
            this.YRectangle.TextChanged += new System.EventHandler(this.YRectangle_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(49, 394);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 20);
            this.label17.TabIndex = 25;
            this.label17.Text = "X:";
            // 
            // XRectangle
            // 
            this.XRectangle.Location = new System.Drawing.Point(83, 391);
            this.XRectangle.Name = "XRectangle";
            this.XRectangle.Size = new System.Drawing.Size(134, 26);
            this.XRectangle.TabIndex = 24;
            this.XRectangle.TextChanged += new System.EventHandler(this.XRectangle_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(49, 361);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 20);
            this.label16.TabIndex = 23;
            this.label16.Text = "Id:";
            // 
            // IdRectangle
            // 
            this.IdRectangle.Location = new System.Drawing.Point(83, 358);
            this.IdRectangle.Name = "IdRectangle";
            this.IdRectangle.Size = new System.Drawing.Size(134, 26);
            this.IdRectangle.TabIndex = 22;
            // 
            // RemoveRectangleButton
            // 
            this.RemoveRectangleButton.BackgroundImage = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.RemoveRectangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RemoveRectangleButton.FlatAppearance.BorderSize = 0;
            this.RemoveRectangleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.RemoveRectangleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RemoveRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveRectangleButton.Location = new System.Drawing.Point(282, 261);
            this.RemoveRectangleButton.Name = "RemoveRectangleButton";
            this.RemoveRectangleButton.Size = new System.Drawing.Size(112, 40);
            this.RemoveRectangleButton.TabIndex = 21;
            this.RemoveRectangleButton.UseVisualStyleBackColor = true;
            this.RemoveRectangleButton.Click += new System.EventHandler(this.RemoveRectangleButton_Click);
            this.RemoveRectangleButton.MouseEnter += new System.EventHandler(this.RemoveRectangleButton_MouseEnter);
            this.RemoveRectangleButton.MouseLeave += new System.EventHandler(this.RemoveRectangleButton_MouseLeave);
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.BackgroundImage = global::Programming.Properties.Resources.rectangle_add_24x24_uncolor;
            this.AddRectangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddRectangleButton.FlatAppearance.BorderSize = 0;
            this.AddRectangleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.AddRectangleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AddRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectangleButton.Location = new System.Drawing.Point(3, 261);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(112, 40);
            this.AddRectangleButton.TabIndex = 20;
            this.AddRectangleButton.Text = "\r\n";
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
            this.AddRectangleButton.MouseEnter += new System.EventHandler(this.AddRectangleButton_MouseEnter);
            this.AddRectangleButton.MouseLeave += new System.EventHandler(this.AddRectangleButton_MouseLeave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(-1, 327);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(153, 20);
            this.label15.TabIndex = 19;
            this.label15.Text = "Selected Rectangle:";
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasPanel.Location = new System.Drawing.Point(407, 3);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(580, 580);
            this.CanvasPanel.TabIndex = 18;
            // 
            // ListBoxRectanglesTabPage
            // 
            this.ListBoxRectanglesTabPage.FormattingEnabled = true;
            this.ListBoxRectanglesTabPage.ItemHeight = 20;
            this.ListBoxRectanglesTabPage.Location = new System.Drawing.Point(3, 26);
            this.ListBoxRectanglesTabPage.Name = "ListBoxRectanglesTabPage";
            this.ListBoxRectanglesTabPage.Size = new System.Drawing.Size(390, 224);
            this.ListBoxRectanglesTabPage.TabIndex = 17;
            this.ListBoxRectanglesTabPage.SelectedIndexChanged += new System.EventHandler(this.ListBoxRectanglesTabPage_SelectedIndexChanged);
            // 
            // labelRectanglesTabPage
            // 
            this.labelRectanglesTabPage.AutoSize = true;
            this.labelRectanglesTabPage.Location = new System.Drawing.Point(-1, 3);
            this.labelRectanglesTabPage.Name = "labelRectanglesTabPage";
            this.labelRectanglesTabPage.Size = new System.Drawing.Size(94, 20);
            this.labelRectanglesTabPage.TabIndex = 16;
            this.labelRectanglesTabPage.Text = "Rectangles:";
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label20);
            this.Controls.Add(this.HeightRectangle);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.WidthRectangle);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.YRectangle);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.XRectangle);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.IdRectangle);
            this.Controls.Add(this.RemoveRectangleButton);
            this.Controls.Add(this.AddRectangleButton);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CanvasPanel);
            this.Controls.Add(this.ListBoxRectanglesTabPage);
            this.Controls.Add(this.labelRectanglesTabPage);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(993, 589);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox HeightRectangle;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox WidthRectangle;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox YRectangle;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox XRectangle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox IdRectangle;
        private System.Windows.Forms.Button RemoveRectangleButton;
        private System.Windows.Forms.Button AddRectangleButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.ListBox ListBoxRectanglesTabPage;
        private System.Windows.Forms.Label labelRectanglesTabPage;
    }
}
