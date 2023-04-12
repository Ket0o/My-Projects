using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Customer = ObjectOrientedPractics.Model.Customer;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Реализация по представлению покупателей.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Коллекция покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();

            _customers = ProjectSerializer.DeserializeCustomers();

            foreach (Customer customer in _customers)
            {
                ListBoxCustomers.Items.Add($"{customer.Id}: " + $"{customer.FullName};");
            }
        }

        /// <summary>
        /// Очищает информацию с текстовых полей.
        /// </summary>
        private void ClearCustomerInfo()
        {
            ListBoxCustomers.Items.Clear();
            IdTextBox.Clear();
            FullNameTextBox.Clear();
            AddressTextBox.Clear();
        }

        /// <summary>
        /// Обновляет информацию в списке.
        /// </summary>
        /// <param name="selectedIndex">Выбранный индекс.</param>
        private void UpdateCustomerInfo(int selectedIndex)
        {
            ListBoxCustomers.Items.Clear();

            _customers = Sorting.SortedCustomers(_customers);

            foreach (Customer customer in _customers)
            {
                ListBoxCustomers.Items.Add($"{customer.Id}: " + $"{customer.FullName};");
            }

            if (selectedIndex == -1) return;

            ListBoxCustomers.SelectedIndex = selectedIndex;
        }

        private void ListBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxCustomers.SelectedItem != null)
            {
                int indexSelectedCustomer = ListBoxCustomers.SelectedIndex;
                _currentCustomer = _customers[indexSelectedCustomer];
                IdTextBox.Text = _currentCustomer.Id.ToString();
                FullNameTextBox.Text = _currentCustomer.FullName;
                AddressTextBox.Text = _currentCustomer.Address;
            }
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxCustomers.SelectedIndex == -1)
                return;
            try
            {
                string customerCurrentFullName = FullNameTextBox.Text;
                _currentCustomer.FullName = customerCurrentFullName;
                int index = _customers.IndexOf(_currentCustomer);
                UpdateCustomerInfo(index);
                ProjectSerializer.Serialize(_customers);
            }
            catch
            {
                FullNameTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            FullNameTextBox.BackColor = AppColors.CorrectColor;
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxCustomers.SelectedIndex == -1)
                return;
            try
            {
                string customerCurrentAddress = AddressTextBox.Text;
                _currentCustomer.Address = customerCurrentAddress;
                int index = _customers.IndexOf(_currentCustomer);
                UpdateCustomerInfo(index);
                ProjectSerializer.Serialize(_customers);
            }
            catch
            {
                AddressTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            AddressTextBox.BackColor = AppColors.CorrectColor;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = CustomerFactory.DefaultCustomer();
            _customers.Add(_currentCustomer);
            int index = _customers.IndexOf(_currentCustomer);
            Sorting.SortedCustomers(_customers);
            UpdateCustomerInfo(index);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = ListBoxCustomers.SelectedIndex;
            if (index != -1)
            {
                _customers.RemoveAt(index);
                ListBoxCustomers.Items.RemoveAt(index);
                ClearCustomerInfo();

                for (int i = 0; i < _customers.Count; i++)
                {
                    ListBoxCustomers.Items.Add(_customers[i].FullName);
                    ListBoxCustomers.SelectedIndex = 0;
                }
            }

            UpdateCustomerInfo(-1);
            ProjectSerializer.Serialize(_customers);
        }
    }
}