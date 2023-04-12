using Programming.Model.Enums;
using System;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    /// <summary>
    /// Реализация по представлению перечислений.
    /// </summary>
    public partial class AllEnumerationsControl : UserControl
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="AllEnumerationsControl"/>.
        /// </summary>
        public AllEnumerationsControl()
        {
            InitializeComponent();

            Array typeValues = Enum.GetValues(typeof(Enums));
            foreach (Enums value in typeValues)
            {
                EnumsListBox.Items.Add(value);
            }

            EnumsListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Array enumValues;
            ValuesListBox.Items.Clear();
            switch (EnumsListBox.SelectedItem)
            {
                case Enums.Color:
                    enumValues = Enum.GetValues(typeof(Colors));
                    break;

                case Enums.Weekday:
                    enumValues = Enum.GetValues(typeof(Weekday));
                    break;

                case Enums.Seasons:
                    enumValues = Enum.GetValues(typeof(Season));
                    break;

                case Enums.Manufactures:
                    enumValues = Enum.GetValues(typeof(Manufactures));
                    break;

                case Enums.Genre:
                    enumValues = Enum.GetValues(typeof(Genre));
                    break;

                case Enums.EducationForm:
                    enumValues = Enum.GetValues(typeof(EducationForm));
                    break;

                default:
                    throw new NotImplementedException();
            }

            foreach (var value in enumValues)
            {
                ValuesListBox.Items.Add(value);
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ValuesListBox.SelectedItem;
            IntValueTextBox.Text = ((int)item).ToString();
        }
    }
}
