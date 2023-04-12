using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfContacts.ViewModel.Base
{
    /// <summary>
    /// Представляет базовую реализацию интерфейса <see cref="INotifyPropertyChanged"/>.
    /// </summary>
    public class ViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Событие на изменение свойст.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Зажигает событие <see cref="OnPropertyChanged"/>.
        /// </summary>
        /// <param name="propertyName">Имя свойства.</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}