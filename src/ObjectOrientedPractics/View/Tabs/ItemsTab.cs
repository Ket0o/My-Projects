using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Item = ObjectOrientedPractics.Model.Item;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Реализация по представлению продуктов.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Коллекция продуктов.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Выбранный продукт.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();

            _items = ProjectSerializer.DeserializeItems();

            foreach (Item item in _items)
            {
                ListBoxItems.Items.Add($"{item.Id}: " + $"{item.Name};");
            }
        }

        /// <summary>
        /// Очищает информацию с текстовых полей.
        /// </summary>
        private void ClearItemInfo()
        {
            ListBoxItems.Items.Clear();
            IdTextBox.Clear();
            CostTextBox.Clear();
            DescriptionTextBox.Clear();
            NameTextBox.Clear();
        }

        /// <summary>
        /// Обновляет информацию в списке.
        /// </summary>
        /// <param name="selectedIndex">Выбранный индекс.</param>
        private void UpdateItemInfo(int selectedIndex)
        {
            ListBoxItems.Items.Clear();

            _items = Sorting.SortedItems(_items);

            foreach (Item item in _items)
            {
                ListBoxItems.Items.Add($"{item.Id}: " + $"{item.Name};");
            }

            if (selectedIndex == -1) return;

            ListBoxItems.SelectedIndex = selectedIndex;
        }

        private void ListBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxItems.SelectedItem != null)
            {
                int indexSelectedItem = ListBoxItems.SelectedIndex;
                _currentItem = _items[indexSelectedItem];
                IdTextBox.Text = _currentItem.Id.ToString();
                CostTextBox.Text = _currentItem.Cost.ToString();
                NameTextBox.Text = _currentItem.Name;
                DescriptionTextBox.Text = _currentItem.Info;
            }
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxItems.SelectedIndex == -1)
                return;
            try
            {
                string itemCurrentCost = CostTextBox.Text;
                int itemCost = int.Parse(itemCurrentCost);
                _currentItem.Cost = itemCost;
                int index = _items.IndexOf(_currentItem);
                UpdateItemInfo(index);
                ProjectSerializer.Serialize(_items);
            }
            catch
            {
                CostTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            CostTextBox.BackColor = AppColors.CorrectColor;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxItems.SelectedIndex == -1)
                return;
            try
            {
                string itemCurrentName = NameTextBox.Text;
                _currentItem.Name = itemCurrentName;
                int index = _items.IndexOf(_currentItem);
                UpdateItemInfo(index);
                ProjectSerializer.Serialize(_items);
            }
            catch
            {
                NameTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            NameTextBox.BackColor = AppColors.CorrectColor;
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxItems.SelectedIndex == -1)
                return;
            try
            {
                string itemCurrentDescription = DescriptionTextBox.Text;
                _currentItem.Info = itemCurrentDescription;
                int index = _items.IndexOf(_currentItem);
                UpdateItemInfo(index);
                ProjectSerializer.Serialize(_items);
            }
            catch
            {
                DescriptionTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            DescriptionTextBox.BackColor = AppColors.CorrectColor;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentItem = ItemFactory.DefaultItem();
            _items.Add(_currentItem);
            int index = _items.IndexOf(_currentItem);
            Sorting.SortedItems(_items);
            UpdateItemInfo(index);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = ListBoxItems.SelectedIndex;
            if (index != -1)
            {
                _items.RemoveAt(index);
                ListBoxItems.Items.RemoveAt(index);
                ClearItemInfo();

                for (int i = 0; i < _items.Count; i++)
                {
                    ListBoxItems.Items.Add(_items[i].Name);
                    ListBoxItems.SelectedIndex = 0;
                }
            }

            UpdateItemInfo(-1);
            ProjectSerializer.Serialize(_items);
        }
    }
}