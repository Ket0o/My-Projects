using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателях.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Количество всех покупателей.
        /// </summary>
        private static int _allCustomersCount;

        /// <summary>
        /// Уникальный идентификатор для всех объектов класса.
        /// </summary>
        private int _id;

        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private string _address;

        /// <summary>
        /// Возвращает и задает количество всех покупателей.
        /// </summary>
        public static int AllCustomersCount
        {
            get => _allCustomersCount;
        }

        /// <summary>
        /// Возвращает и задает полное имя покупателя. Не более 200.
        /// </summary>
        public string FullName
        {
            get => (_fullName == null) ? null : _fullName;
            set
            {
                Validator.NoMoreThan(value, InitialConstants.MaxLengthName, FullName);
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает и создает адрес покупателя. Не более 200.
        /// </summary>
        public string Address
        {
            get => (_address == null) ? null : _address;
            set
            {
                Validator.NoMoreThan(value, InitialConstants.MaxLengthAddress, Address);
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает и задает уникальный индефикатор. Доступно только для чтения.
        /// </summary>
        public int Id
        {
            get => _id;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        public Customer()
        {
            _allCustomersCount++;
            _id = _allCustomersCount;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullName">Полное имя покупателя. Не более 200 символов.</param>
        /// <param name="address">Адрес покупателя. Не более 200 символов.</param>
        public Customer(string fullName, string address)
        {
            FullName = fullName;
            Address = address;
            _allCustomersCount++;
            _id = _allCustomersCount;
        }
    }
}
