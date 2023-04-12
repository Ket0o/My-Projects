using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные товарах.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Количество всех товаров.
        /// </summary>
        private static int _allItemsCount;

        /// <summary>
        /// Уникальный идентификатор для всех объектов класса.
        /// </summary>
        private int _id;

        /// <summary>
        /// Наименование товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Информация о товаре.
        /// </summary>
        private string _info;

        /// <summary>
        /// Цена.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает и задает количество всех товаров.
        /// </summary>
        public static int AllItemsCount
        {
            get => _allItemsCount;
        }

        /// <summary>
        /// Возвращает и задает наименование товара. Не более 200 символов.
        /// </summary>
        public string Name
        {
            get => (_name == null) ? null : _name;
            set
            {
                Validator.NoMoreThan(value, InitialConstants.MaxLengthName, Name);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает информацию о товаре. Не более 1000.
        /// </summary>
        public string Info
        {
            get => (_info == null) ? null : _info;
            set
            {
                Validator.NoMoreThan(value, InitialConstants.MaxLengthInfo, Info);
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задает цену товара. От 0 до 100000.
        /// </summary>
        public double Cost
        {
            get => _cost;
            set
            {
                Validator.AssertValueInRange(nameof(Cost), value, InitialConstants.MinValueCost, InitialConstants.MaxValueCost);
                _cost = value;
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
        /// Создает экземпляр класса <see cref="Item"/>
        /// </summary>
        public Item()
        {
            _allItemsCount++;
            _id = _allItemsCount;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>
        /// </summary>
        /// <param name="name">Наименование товара. Не более 200 символов.</param>
        /// <param name="info">Информация о товаре. Не более 1000 символов.</param>
        /// <param name="cost">Цена товара. От 0 до 100000.</param>
        public Item(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _allItemsCount++;
            _id = _allItemsCount;
        }
    }
}
