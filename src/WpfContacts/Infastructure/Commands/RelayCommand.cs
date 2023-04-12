using System;
using WpfContacts.Infastructure.Commands.Base;

namespace WpfContacts.Infastructure.Commands
{
    public class RelayCommand : Command
    {
        /// <summary>
        /// Делегат для вызова команды.
        /// </summary>
        private readonly Action<object> _execute;

        /// <summary>
        /// Делегат проверки, для вызова команды.
        /// </summary>
        private readonly Func<object, bool> _canExecute;

        /// <summary>
        /// Создает экземпляр класса <see cref="RelayCommand"/>
        /// </summary>
        /// <param name="Execute">Делегат для вызова команды.</param>
        /// <param name="CanExecute">Делегат проверки, для вызова команды.</param>
        /// <exception cref="ArgumentNullException">Вызывается, если получаем null.</exception>
        public RelayCommand(Action<object> Execute, Func<object, bool> CanExecute = null)
        {
            _execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
            _canExecute = CanExecute;
        }

        /// <summary>
        /// Определяет, может ли команда выполняться.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        /// <returns>Возвращает true, если кто-то подписался на событие и false, если нет.</returns>
        public override bool CanExecute(object? parameter)
        {
            return _canExecute?.Invoke(parameter) ?? true;
        }

        /// <summary>
        /// Выполняет реализацию команды.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        public override void Execute(object? parameter)
        {
            _execute(parameter);
        }
    }
}