using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ViewModel
{
    /// <summary>
    /// Представляет базовую реализацию интерфейса <see cref="INotifyDataErrorInfo"/>.
    /// </summary>
    public class ErrorsVm : INotifyDataErrorInfo
    {
        /// <summary>
        /// Словарь свойств зависимостей. Доступен только на чтение.
        /// </summary>
        private readonly Dictionary<string, List<string>> _propertyDependencies =
            new Dictionary<string, List<string>>();

        /// <summary>
        /// Pажигает событие <see cref="ErrorsChanged"/>.
        /// </summary>
        /// <param name="propertyName">Имя объекта.</param>
        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Возвращает true или false, в зависимости от того, есть ли ошибки.
        /// </summary>
        public bool HasErrors => _propertyDependencies.Any();

        /// <summary>
        /// Событие измнение ошибки.
        /// </summary>
        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        /// <summary>
        /// Добавляет ошибку.
        /// </summary>
        /// <param name="propertyName">Имя объекта.</param>
        /// <param name="errorMessage">Сообщение об ошибке.</param>
        public void AddError(string propertyName, string errorMessage)
        {
            if (!_propertyDependencies.ContainsKey(propertyName))
            {
                _propertyDependencies.Add(propertyName, new List<string>());
            }

            _propertyDependencies[propertyName].Add(errorMessage);
        }

        /// <summary>
        /// Убирает ошибку.
        /// </summary>
        /// <param name="propertyName">Имя объекта.</param>
        public void ClearErrors(string propertyName)
        {
            if (_propertyDependencies.Remove(propertyName))
            {
                OnErrorsChanged(propertyName);
            }
        }

        /// <summary>
        /// Извлекает имя объекта.
        /// </summary>
        /// <param name="propertyName">Имя объекта.</param>
        /// <returns><see cref="propertyName"/> или <see cref="null"/>.</returns>
        public IEnumerable GetErrors(string? propertyName)
        {
            return _propertyDependencies.GetValueOrDefault(propertyName, null);
        }
    }
}
