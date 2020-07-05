using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Calculator_PATERN.ViewModels.Base
{
    // сообщает клиенту об изменениях свойств
    internal abstract class BaseViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

    }
}
