using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для главного окна.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Событие на изменение свойст.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Контактные данные.
        /// </summary>
        public Contact Contact { get; } = new Contact();

        /// <summary>
        /// Возвращает и задает имя.
        /// </summary>
        public string Name
        {
            get => Contact.Name;
            set
            {
                Contact.Name = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задает телефонный номер.
        /// </summary>
        public int PhoneNumber
        {
            get => Contact.PhoneNumber;
            set
            {
                Contact.PhoneNumber = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задает электронную почту.
        /// </summary>
        public string Email
        {
            get => Contact.Email;
            set
            {
                Contact.Email = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Команда на сохранение контактных данных.
        /// </summary>
        public ICommand SaveCommand
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    ContactSerializer.Serialize(Contact);
                });
            }
        }

        /// <summary>
        /// Команда на загрузку контактных данных.
        /// </summary>
        public ICommand LoadCommand
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    Contact contact = ContactSerializer.Deserialize();
                    Name = contact.Name;
                    PhoneNumber = contact.PhoneNumber;
                    Email = contact.Email;
                });
            }
        }

        /// <summary>
        /// Зажигает событие <see cref="OnPropertyChanged"/>.
        /// </summary>
        /// <param name="prop">Имя свойства.</param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}