namespace Employees.View
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
            this.ListBoxEmployees = new System.Windows.Forms.ListBox();
            this.SelectedEmployeesGroupBox = new System.Windows.Forms.GroupBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PostTextBox = new System.Windows.Forms.TextBox();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SelectedEmployeesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxEmployees
            // 
            this.ListBoxEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListBoxEmployees.FormattingEnabled = true;
            this.ListBoxEmployees.IntegralHeight = false;
            this.ListBoxEmployees.ItemHeight = 20;
            this.ListBoxEmployees.Location = new System.Drawing.Point(12, 12);
            this.ListBoxEmployees.Name = "ListBoxEmployees";
            this.ListBoxEmployees.Size = new System.Drawing.Size(290, 444);
            this.ListBoxEmployees.TabIndex = 0;
            this.ListBoxEmployees.SelectedIndexChanged += new System.EventHandler(this.ListBoxEmployees_SelectedIndexChanged);
            // 
            // SelectedEmployeesGroupBox
            // 
            this.SelectedEmployeesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedEmployeesGroupBox.Controls.Add(this.DateTimePicker);
            this.SelectedEmployeesGroupBox.Controls.Add(this.PostTextBox);
            this.SelectedEmployeesGroupBox.Controls.Add(this.SalaryTextBox);
            this.SelectedEmployeesGroupBox.Controls.Add(this.FullNameTextBox);
            this.SelectedEmployeesGroupBox.Controls.Add(this.label4);
            this.SelectedEmployeesGroupBox.Controls.Add(this.label3);
            this.SelectedEmployeesGroupBox.Controls.Add(this.label2);
            this.SelectedEmployeesGroupBox.Controls.Add(this.label1);
            this.SelectedEmployeesGroupBox.Location = new System.Drawing.Point(309, 12);
            this.SelectedEmployeesGroupBox.Name = "SelectedEmployeesGroupBox";
            this.SelectedEmployeesGroupBox.Size = new System.Drawing.Size(584, 205);
            this.SelectedEmployeesGroupBox.TabIndex = 1;
            this.SelectedEmployeesGroupBox.TabStop = false;
            this.SelectedEmployeesGroupBox.Text = "Selected Employee";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(168, 115);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(229, 26);
            this.DateTimePicker.TabIndex = 5;
            this.DateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // PostTextBox
            // 
            this.PostTextBox.Location = new System.Drawing.Point(168, 77);
            this.PostTextBox.Name = "PostTextBox";
            this.PostTextBox.Size = new System.Drawing.Size(229, 26);
            this.PostTextBox.TabIndex = 7;
            this.PostTextBox.TextChanged += new System.EventHandler(this.PostTextBox_TextChanged);
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(168, 157);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(229, 26);
            this.SalaryTextBox.TabIndex = 6;
            this.SalaryTextBox.TextChanged += new System.EventHandler(this.SalaryTextBox_TextChanged);
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(168, 37);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(409, 26);
            this.FullNameTextBox.TabIndex = 4;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salary:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of employment:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Post:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddEmployeeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddEmployeeButton.FlatAppearance.BorderSize = 0;
            this.AddEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployeeButton.Image = ((System.Drawing.Image)(resources.GetObject("AddEmployeeButton.Image")));
            this.AddEmployeeButton.Location = new System.Drawing.Point(12, 462);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(52, 50);
            this.AddEmployeeButton.TabIndex = 2;
            this.AddEmployeeButton.Text = "\r\n";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            this.AddEmployeeButton.MouseEnter += new System.EventHandler(this.AddEmployeeButton_MouseEnter);
            this.AddEmployeeButton.MouseLeave += new System.EventHandler(this.AddEmployeeButton_MouseLeave);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(70, 462);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(52, 50);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteEmployeeButton_Click);
            this.DeleteButton.MouseEnter += new System.EventHandler(this.DeleteEmployeeButton_MouseEnter);
            this.DeleteButton.MouseLeave += new System.EventHandler(this.DeleteEmployeeButton_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 525);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.SelectedEmployeesGroupBox);
            this.Controls.Add(this.ListBoxEmployees);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Employees";
            this.SelectedEmployeesGroupBox.ResumeLayout(false);
            this.SelectedEmployeesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxEmployees;
        private System.Windows.Forms.GroupBox SelectedEmployeesGroupBox;
        private System.Windows.Forms.TextBox PostTextBox;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
    }
}

