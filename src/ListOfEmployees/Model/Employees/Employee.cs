using System;

namespace Employees.Model.Employees
{
    /// <summary>
    /// Хранит данные о рабочих.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Количество всех рабочих.
        /// </summary>
        private static int _allEmployeesCount;

        /// <summary>
        /// Полное имя.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Занимаемая должность.
        /// </summary>
        private string _post;

        /// <summary>
        /// Зарплата.
        /// </summary>
        private int _salary;

        /// <summary>
        /// Уникальный идентификатор для всех объектов класса.
        /// </summary>
        private int _id;

        /// <summary>
        /// Возвращает и задает количество всех рабочих.
        /// </summary>
        public static int AllEmployeesCount
        {
            get => _allEmployeesCount;
        }

        /// <summary>
        /// Возвращает и задает полное имя рабочего. Не более 100 символов.
        /// </summary>
        public string FullName
        {
            get => (_fullName == null) ? null : _fullName;
            set
            {
                Validator.NoMoreThan(value, InitialConstants.MaxLengthFullName, FullName);
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает и задает занимаемую должность. Не более 50 символов.
        /// </summary>
        public string Post
        {
            get => (_post == null) ? null : _post;
            set
            {
                Validator.NoMoreThan(value, InitialConstants.MaxLengthPost, Post);
                _post = value;
            }
        }

        /// <summary>
        /// Возвращает и задает зарплату рабочего. От 0 до 500000
        /// </summary>
        public int Salary
        {
            get => _salary;
            set
            {
                Validator.AssertValueInRange(nameof(Salary), value, InitialConstants.MinValueSalary, InitialConstants.MaxValueSalary);
                _salary = value;
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
        /// Возвращает и задает дату трудоустройства.
        /// </summary>
        public DateTime DateOfEmployment { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Employee"/>.
        /// </summary>
        public Employee()
        {
            _allEmployeesCount++;
            _id = _allEmployeesCount;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Employee"/>.
        /// </summary>
        /// <param name="fullName">Полное имя. Не более 100 символов.</param>
        /// <param name="post">Занимаемая должность. Не более 50 символов.</param>
        /// <param name="salary">Зарплата. От 0 до 500000.</param>
        /// <param name="dateOfEmployment">Дата трудоустройства.</param>
        public Employee(string fullName, string post, int salary, DateTime dateOfEmployment)
        {
            FullName = fullName;
            Post = post;
            Salary = salary;
            DateOfEmployment = dateOfEmployment;
            _allEmployeesCount++;
            _id = _allEmployeesCount;
        }
    }
}
