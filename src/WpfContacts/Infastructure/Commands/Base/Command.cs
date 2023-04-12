using System;
using System.Windows.Input;

namespace WpfContacts.Infastructure.Commands.Base
{
    /// <summary>
    /// Представляет базовую реализацию интерфейса <see cref="ICommand"/>.
    /// </summary>
    public abstract class Command : ICommand
    {
        /// <summary>
        /// Событие изменения возможности вызова команды.
        /// </summary>
        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        /// <summary>
        /// Определяет, может ли команда выполняться.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        /// <returns></returns>
        public abstract bool CanExecute(object? parameter);

        /// <summary>
        /// Выполняет логику команды.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        public abstract void Execute(object? parameter);
    }
}
