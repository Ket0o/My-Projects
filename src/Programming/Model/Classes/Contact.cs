using System;
using System.Text.RegularExpressions;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о телефонном контакте.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Регулярное выражение(только цифры).
        /// </summary>
        private readonly Regex _patternString = new Regex(@"\d{11}");

        /// <summary>
        /// Номер.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Имя.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возвращает и создает имя контакта. Должно состоять только из букв.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = AssertStringContainsOnlyLetters(nameof(Name), value);
            }
        }

        /// <summary>
        /// Возвращает и задает фамилию контакта. Должна состоять только из букв.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = AssertStringContainsOnlyLetters(nameof(Surname), value);
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона человека. Должен состоять только из цифр и их должно быть 11.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                MatchCollection matches = _patternString.Matches(value);
                if (matches.Count != 11)
                {
                    throw new ArgumentException("Enter only numbers");
                }
                if (value.Length > 11)
                {
                    throw new ArgumentException("The phone number contains more than 11 digits");
                }
                else
                {
                    _phoneNumber = value;
                }
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {

        }

        /// <summary>
        ///  Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя. Должно состоять только из букв.</param>
        /// <param name="surname">Фамилия. Должна состоять только из букв.</param>
        /// <param name="phoneNumber">Номер телефона. Должен состоять из цифр и их должно быть 11.</param>
        public Contact(string name, string surname, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Проверяет, что строка состоит только из букв.
        /// </summary>
        /// <param name="value">>Проверямая строка.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private string AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]))
                {
                    throw new ArgumentException($"{propertyName} must cintains letters only");
                }
            }

            return value;
        }
    }
}
