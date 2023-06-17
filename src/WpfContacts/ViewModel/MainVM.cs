using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Linq;
using ViewModel.Services;

namespace ViewModel
{
    /// <summary>
    /// ViewModel для главного окна.
    /// </summary>
    public partial class MainVM : ObservableObject
    {
        /// <summary>
        /// Свойство для блокировки элементов пользовательского интерфейса.
        /// </summary>
        [ObservableProperty]
        private bool _isReadOnly = true;

        /// <summary>
        /// Свойство для блокировки элементов пользовательского интерфейса.
        /// </summary>
        [ObservableProperty]
        private bool _isSelecting;

        /// <summary>
        /// Выбранный контакт.
        /// </summary>
        private ContactVm _selectedContact;

        /// <summary>
        /// Логика команды <see cref="AddContactCommand"/>.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        [RelayCommand]
        private void AddContact()
        {
            SelectedContact = null;
            ContactVm contact = new ContactVm();
            contact.Name = "";
            contact.PhoneNumber = "";
            contact.Email = "";
            SelectedContact = contact;
            IsReadOnly = IsSelecting = false;
        }

        /// <summary>
        /// Логика команды <see cref="EditContactCommand"/>.
        /// </summary>
        [RelayCommand]
        private void EditContact()
        {
            IsReadOnly = IsSelecting = false;
        }

        /// <summary>
        /// Логика команды <see cref="DeleteContactCommand"/>.
        /// </summary>
        [RelayCommand]
        private void DeleteContact()
        {
            if (SelectedContact == Contacts.Last())
            {
                Contacts!.Remove(SelectedContact);
                if (Contacts.Count > 1)
                {
                    SelectedContact = Contacts.Last();
                    IsSelecting = true;
                }
                else
                {
                    SelectedContact = null;
                    IsSelecting = false;
                }
            }
            else
            {
                for (int i = 0; i < Contacts.Count; i++)
                {
                    if (SelectedContact == Contacts[i])
                    {
                        Contacts!.Remove(SelectedContact);
                        SelectedContact = Contacts[i];
                        IsSelecting = true;
                        break;
                    }
                }
            }

            ContactsSerializer.Serialize(Contacts);
        }

        /// <summary>
        /// Логика команды <see cref="ApplyContactCommand"/>.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        [RelayCommand]
        private void ApplyContact()
        {
            IsReadOnly = IsSelecting = true;
            if (Contacts.Contains(SelectedContact))
            {
                ContactsSerializer.Serialize(Contacts);
            }
            else
            {
                Contacts.Add(SelectedContact);
                ContactsSerializer.Serialize(Contacts);
            }
        }

        /// <summary>
        /// Коллекция контактов.
        /// </summary>
        public ObservableCollection<ContactVm>? Contacts { get; } =
            ContactsSerializer.Deserialize();

        /// <summary>
        /// Возвращает и задает выбранный контакт.
        /// </summary>
        public ContactVm SelectedContact
        {
            get
            {
                return _selectedContact;
            }
            set
            {
                _selectedContact = value;
                OnPropertyChanged();
                IsReadOnly = true;
                IsSelecting = true;
            }
        }
    }
}
