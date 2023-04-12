using Employees.Model;
using Employees.Model.Employees;
using ListOfEmployees.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Employees.View
{
    /// <summary>
    /// Предоставляет реализацию расположения элементов на форме.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Коллекция рабочих.
        /// </summary>
        private List<Employee> _employees;

        /// <summary>
        /// Выбранный рабочий.
        /// </summary>
        private Employee _currentEmployee;

        /// <summary>
        /// Создает экземпляр класса <see cref="MainForm"/>
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            DateTimePicker.MaxDate = DateTime.Now;

            _employees = ProjectSerializer.Deserialize();

            foreach (Employee employee in _employees)
            {
                ListBoxEmployees.Items.Add($"{employee.FullName}");
            }
        }

        /// <summary>
        /// Очищает информацию с текстовых полей и поля с датой.
        /// </summary>
        private void ClearEmployeeInfo()
        {
            FullNameTextBox.Clear();
            PostTextBox.Clear();
            SalaryTextBox.Clear();
            DateTimePicker.Value = new DateTime(1753, 1, 1);
        }

        /// <summary>
        /// Обновляет информацию в списке.
        /// </summary>
        /// <param name="selectedIndex">Выбранный индекс.</param>
        private void UpdateEmployeeInfo(int selectedIndex)
        {
            ListBoxEmployees.Items.Clear();

            _employees = Sorting.SortedEmployees(_employees);

            foreach (Employee employee in _employees)
            {
                ListBoxEmployees.Items.Add($"{employee.FullName}");
            }

            if (selectedIndex == -1) return;

            ListBoxEmployees.SelectedIndex = selectedIndex;
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            _currentEmployee = EmployeeFactory.CreateDefaultt();
            _employees.Add(_currentEmployee);
            ListBoxEmployees.Items.Add(_currentEmployee.FullName);
            int index = _employees.IndexOf(_currentEmployee);
            Sorting.SortedEmployees(_employees);
            UpdateEmployeeInfo(index);
        }

        private void ListBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxEmployees.SelectedItem != null)
            {
                int indexSelectedEmployee = ListBoxEmployees.SelectedIndex;
                _currentEmployee = _employees[indexSelectedEmployee];
                FullNameTextBox.Text = _currentEmployee.FullName;
                PostTextBox.Text = _currentEmployee.Post;
                DateTimePicker.Value = _currentEmployee.DateOfEmployment;
                SalaryTextBox.Text = _currentEmployee.Salary.ToString();
            }
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxEmployees.SelectedIndex == -1)
                return;

            try
            {
                string employeeCurrentFullName = FullNameTextBox.Text;
                _currentEmployee.FullName = employeeCurrentFullName;
                int index = _employees.IndexOf(_currentEmployee);
                UpdateEmployeeInfo(index);
                ProjectSerializer.Serialize(_employees);
            }
            catch
            {
                FullNameTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            FullNameTextBox.BackColor = AppColors.CorrectColor;
        }

        private void PostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxEmployees.SelectedIndex == -1)
                return;

            try
            {
                string employeeCurrentPost = PostTextBox.Text;
                _currentEmployee.Post = employeeCurrentPost;
                ProjectSerializer.Serialize(_employees);
            }
            catch
            {
                PostTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            PostTextBox.BackColor = AppColors.CorrectColor;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (ListBoxEmployees.SelectedIndex == -1)
                return;

            try
            {
                string employeeCurrentDate = DateTimePicker.Text;
                _currentEmployee.DateOfEmployment = DateTime.Parse(employeeCurrentDate);
                ProjectSerializer.Serialize(_employees);
            }
            catch
            {
                DateTimePicker.CalendarForeColor = AppColors.ErrorColor;
                return;
            }

            DateTimePicker.CalendarTitleBackColor = AppColors.CorrectColor;
        }

        private void SalaryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxEmployees.SelectedIndex == -1)
                return;

            try
            {
                string employeeCurrentSalary = SalaryTextBox.Text;
                _currentEmployee.Salary = int.Parse(employeeCurrentSalary);
                ProjectSerializer.Serialize(_employees);
            }
            catch
            {
                SalaryTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            SalaryTextBox.BackColor = AppColors.CorrectColor;
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            int index = ListBoxEmployees.SelectedIndex;

            if (index != -1)
            {
                _employees.RemoveAt(index);
                ListBoxEmployees.Items.RemoveAt(index);
                ClearEmployeeInfo();

                for (int i = 0; i < _employees.Count; i++)
                {
                    ListBoxEmployees.Items.Add(_employees[i].FullName);
                    ListBoxEmployees.SelectedIndex = 0;
                }
            }

            UpdateEmployeeInfo(-1);
            ProjectSerializer.Serialize(_employees);
        }

        private void AddEmployeeButton_MouseEnter(object sender, EventArgs e)
        {
            AddEmployeeButton.Image = Resources.plus_24x24;
        }

        private void AddEmployeeButton_MouseLeave(object sender, EventArgs e)
        {
            AddEmployeeButton.Image = Resources.plus_24x24_uncolor;
        }

        private void DeleteEmployeeButton_MouseEnter(object sender, EventArgs e)
        {
            DeleteButton.Image = Resources.minus_24x24;
        }

        private void DeleteEmployeeButton_MouseLeave(object sender, EventArgs e)
        {
            DeleteButton.Image = Resources.minus_24x24_uncolor;
        }
    }
}
