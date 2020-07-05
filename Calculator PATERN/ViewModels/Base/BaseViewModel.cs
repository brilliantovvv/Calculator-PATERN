using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Calculator_PATERN.ViewModels.Base
{
   
    public abstract class BaseViewModel : INotifyPropertyChanged , IDisposable
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

        // Деструктор
        ~BaseViewModel()
        {
            Dispose(false);
        }

        // Освобождение управляемых ресурсов
        public void Dispose()
        {
            Dispose(true);
        }

        private bool _Disposing;
        protected virtual void Dispose(bool Disposing)
        {
            if (!Disposing || _Disposing )
            {
                return;
            }
            _Disposing = true;
            // Освобождение управляемых ресурсов
        }
    }
}
