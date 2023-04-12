namespace Programming.View.Panels
{
    partial class RectanglesControl
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
            this.RectangleGroupBox = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.IdRectangleTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.YRectangleTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.XRectangleTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.WidthRectangleTextBox = new System.Windows.Forms.TextBox();
            this.ColorRectangleTextBox = new System.Windows.Forms.TextBox();
            this.Color_label = new System.Windows.Forms.Label();
            this.Width_label = new System.Windows.Forms.Label();
            this.LengthRectangleTextBox = new System.Windows.Forms.TextBox();
            this.Length_label = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectangleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RectangleGroupBox
            // 
            this.RectangleGroupBox.Controls.Add(this.label13);
            this.RectangleGroupBox.Controls.Add(this.IdRectangleTextBox);
            this.RectangleGroupBox.Controls.Add(this.label12);
            this.RectangleGroupBox.Controls.Add(this.YRectangleTextBox);
            this.RectangleGroupBox.Controls.Add(this.label11);
            this.RectangleGroupBox.Controls.Add(this.XRectangleTextBox);
            this.RectangleGroupBox.Controls.Add(this.FindButton);
            this.RectangleGroupBox.Controls.Add(this.WidthRectangleTextBox);
            this.RectangleGroupBox.Controls.Add(this.ColorRectangleTextBox);
            this.RectangleGroupBox.Controls.Add(this.Color_label);
            this.RectangleGroupBox.Controls.Add(this.Width_label);
            this.RectangleGroupBox.Controls.Add(this.LengthRectangleTextBox);
            this.RectangleGroupBox.Controls.Add(this.Length_label);
            this.RectangleGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectangleGroupBox.Location = new System.Drawing.Point(0, 0);
            this.RectangleGroupBox.Name = "RectangleGroupBox";
            this.RectangleGroupBox.Size = new System.Drawing.Size(496, 448);
            this.RectangleGroupBox.TabIndex = 1;
            this.RectangleGroupBox.TabStop = false;
            this.RectangleGroupBox.Text = "Rectangles";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(216, 334);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "Id:";
            // 
            // IdRectangleTextBox
            // 
            this.IdRectangleTextBox.Enabled = false;
            this.IdRectangleTextBox.Location = new System.Drawing.Point(216, 357);
            this.IdRectangleTextBox.Name = "IdRectangleTextBox";
            this.IdRectangleTextBox.Size = new System.Drawing.Size(146, 26);
            this.IdRectangleTextBox.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(216, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Y:";
            // 
            // YRectangleTextBox
            // 
            this.YRectangleTextBox.Enabled = false;
            this.YRectangleTextBox.Location = new System.Drawing.Point(216, 295);
            this.YRectangleTextBox.Name = "YRectangleTextBox";
            this.YRectangleTextBox.Size = new System.Drawing.Size(146, 26);
            this.YRectangleTextBox.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(216, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "X:";
            // 
            // XRectangleTextBox
            // 
            this.XRectangleTextBox.Enabled = false;
            this.XRectangleTextBox.Location = new System.Drawing.Point(216, 232);
            this.XRectangleTextBox.Name = "XRectangleTextBox";
            this.XRectangleTextBox.Size = new System.Drawing.Size(146, 26);
            this.XRectangleTextBox.TabIndex = 8;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(216, 398);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(146, 31);
            this.FindButton.TabIndex = 7;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // WidthRectangleTextBox
            // 
            this.WidthRectangleTextBox.Location = new System.Drawing.Point(216, 109);
            this.WidthRectangleTextBox.Name = "WidthRectangleTextBox";
            this.WidthRectangleTextBox.Size = new System.Drawing.Size(146, 26);
            this.WidthRectangleTextBox.TabIndex = 4;
            this.WidthRectangleTextBox.TextChanged += new System.EventHandler(this.WidthRectangleTextBox_TextChanged);
            // 
            // ColorRectangleTextBox
            // 
            this.ColorRectangleTextBox.Location = new System.Drawing.Point(216, 171);
            this.ColorRectangleTextBox.Name = "ColorRectangleTextBox";
            this.ColorRectangleTextBox.Size = new System.Drawing.Size(146, 26);
            this.ColorRectangleTextBox.TabIndex = 6;
            this.ColorRectangleTextBox.TextChanged += new System.EventHandler(this.ColorRectangleTextBox_TextChanged);
            // 
            // Color_label
            // 
            this.Color_label.AutoSize = true;
            this.Color_label.Location = new System.Drawing.Point(216, 148);
            this.Color_label.Name = "Color_label";
            this.Color_label.Size = new System.Drawing.Size(50, 20);
            this.Color_label.TabIndex = 5;
            this.Color_label.Text = "Color:";
            // 
            // Width_label
            // 
            this.Width_label.AutoSize = true;
            this.Width_label.Location = new System.Drawing.Point(212, 86);
            this.Width_label.Name = "Width_label";
            this.Width_label.Size = new System.Drawing.Size(54, 20);
            this.Width_label.TabIndex = 3;
            this.Width_label.Text = "Width:";
            // 
            // LengthRectangleTextBox
            // 
            this.LengthRectangleTextBox.Location = new System.Drawing.Point(216, 48);
            this.LengthRectangleTextBox.Name = "LengthRectangleTextBox";
            this.LengthRectangleTextBox.Size = new System.Drawing.Size(146, 26);
            this.LengthRectangleTextBox.TabIndex = 2;
            this.LengthRectangleTextBox.TextChanged += new System.EventHandler(this.LengthRectangleTextBox_TextChanged);
            // 
            // Length_label
            // 
            this.Length_label.AutoSize = true;
            this.Length_label.Location = new System.Drawing.Point(212, 25);
            this.Length_label.Name = "Length_label";
            this.Length_label.Size = new System.Drawing.Size(63, 20);
            this.Length_label.TabIndex = 1;
            this.Length_label.Text = "Length:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 20;
            this.RectanglesListBox.Location = new System.Drawing.Point(6, 25);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(200, 404);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RectangleGroupBox);
            this.Name = "RectanglesControl";
            this.Size = new System.Drawing.Size(498, 450);
            this.RectangleGroupBox.ResumeLayout(false);
            this.RectangleGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RectangleGroupBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox IdRectangleTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox YRectangleTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox XRectangleTextBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox WidthRectangleTextBox;
        private System.Windows.Forms.TextBox ColorRectangleTextBox;
        private System.Windows.Forms.Label Color_label;
        private System.Windows.Forms.Label Width_label;
        private System.Windows.Forms.TextBox LengthRectangleTextBox;
        private System.Windows.Forms.Label Length_label;
        private System.Windows.Forms.ListBox RectanglesListBox;
    }
}
