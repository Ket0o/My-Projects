using CommunityToolkit.Mvvm.ComponentModel;
using Model;
using System;
using System.Collections;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace ViewModel
{
    /// <summary>
    /// ViewModel для contact.
    /// </summary>
    public class ContactVm : ObservableObject, INotifyDataErrorInfo
    {
        /// <summary>
        /// Максимальная длина для textBox.
        /// </summary>
        private const int MaxLengthValueTextBox = 100;

        /// <summary>
        /// Экземпляр класса <see cref="ErrorsVm"/>.
        /// </summary>
        private readonly ErrorsVm _errorsVm;

        /// <summary>
        /// Зажигает событие <see cref="ErrorsChanged"/>.
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Параметр.</param>
        private void ErrorsVM_ErrorsChanged(object? sender, DataErrorsChangedEventArgs e)
        {
            ErrorsChanged?.Invoke(this, e);
            OnPropertyChanged();
        }

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
                _errorsVm.ClearErrors(nameof(Name));
                if ((Contact.Name.Length == 0) || (Contact.Name.Length > MaxLengthValueTextBox))
                {
                    _errorsVm.AddError(nameof(Name),
                        "Name должен быть не длиннее 100 символов");
                }
                OnPropertyChanged();
                OnPropertyChanged(nameof(HasErrors));
            }
        }

        /// <summary>
        /// Возвращает и задает телефонный номер.
        /// </summary>
        public string PhoneNumber
        {
            get => Contact.PhoneNumber;
            set
            {
                Contact.PhoneNumber = value;
                _errorsVm.ClearErrors(nameof(PhoneNumber));
                if ((Contact.PhoneNumber.Length > MaxLengthValueTextBox) || (Contact.PhoneNumber.Length == 0))
                {
                    _errorsVm.AddError(nameof(PhoneNumber),
                        "PhoneNumber должен быть не длиннее 100 символов и может " +
                        "содержать только цифры или символы +-() ." +
                        "\r\nПример: +7 (999) 111-22-33\r\n");
                }
                OnPropertyChanged();
                OnPropertyChanged(nameof(HasErrors));
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
                _errorsVm.ClearErrors(nameof(Email));
                if (((Contact.Email.Length > MaxLengthValueTextBox) || (Contact.Email.Length == 0)) ||
                    (new Regex("[@]").IsMatch(Contact.Email) == false))
                {
                    _errorsVm.AddError(nameof(Email),
                        "Email должен быть не длиннее 100 символов и должен содержать" +
                        "\r\nсимвол @ .");
                }
                OnPropertyChanged();
                OnPropertyChanged(nameof(HasErrors));
            }
        }

        /// <summary>
        /// Возвращает true или false, в зависимости от того, есть ли ошибки.
        /// </summary>
        public bool HasErrors => _errorsVm.HasErrors;

        /// <summary>
        /// Событие измнение ошибки.
        /// </summary>
        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        /// <summary>
        /// Создает экземпляр класса <see cref="ContactVm"/>.
        /// </summary>
        public ContactVm()
        {
            _errorsVm = new ErrorsVm();
            _errorsVm.ErrorsChanged += ErrorsVM_ErrorsChanged;
        }

        /// <summary>
        /// Извлекает имя объекта.
        /// </summary>
        /// <param name="propertyName">Имя объекта.</param>
        /// <returns><see cref="propertyName"/> или <see cref="null"/>.</returns>
        public IEnumerable GetErrors(string? propertyName)
        {
            return _errorsVm.GetErrors(propertyName);
        }
    }
}
