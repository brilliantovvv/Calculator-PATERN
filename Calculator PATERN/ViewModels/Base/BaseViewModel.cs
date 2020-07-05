using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Calculator_PATERN.ViewModels.Base
{
   
    internal abstract class BaseViewModel : INotifyPropertyChanged
    {
        // сообщает клиенту об изменениях свойств
        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        // предотвращение кольцевых обновлений
        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string prop = null)
        {
            if (Equals(field, value))
            {
                return false;
            }
            field = value;
            OnPropertyChanged(prop);
            return true;
        }
    }
}
