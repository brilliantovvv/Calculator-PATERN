using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Calculator_PATERN.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        #region Calculator

        private int _ValueA;
        public int ValueA
        {
            get { return _ValueA; }
            set
            {
                _ValueA = value;
                OnPropertyChanged();
                //OnPropertyChanged("ValueA");
                //OnPropertyChanged(nameof("ValueA"));
            }
        }

        protected virtual bool Set <T> (ref T field, T value, [CallerMemberName] string prop= null)
        {
            if (Equals(field,value))
            {
                return false;
            }
            field = value;
            OnPropertyChanged(prop);
            return true;
        }

        private int _ValueB;
        public int ValueB
        {
            get { return _ValueB; }
            set
            {
                _ValueB = value;
                OnPropertyChanged();
                //OnPropertyChanged("ValueB");
                //OnPropertyChanged(nameof("ValueB"));
            }
        }

        private int _Result;
        public int Result
        {
            get { return _Result; }
            set
            {
                _Result = value;
                OnPropertyChanged();
            }
        }

        public ICommand Sum
        {
            get
            {
                return new FuncButton((obj) =>
                {
                    Result = ValueA + ValueB;
                });
            }
        }
        public ICommand Subtraction
        {
            get
            {
                return new FuncButton((obj) =>
                {
                    Result = ValueA - ValueB;
                });
            }
        }
        public ICommand A1Plus
        {
            get
            {
                return new FuncButton((obj) =>
                {
                    ValueA++;
                });
            }
        }
        public ICommand A1Minus
        {
            get
            {
                return new FuncButton((obj) =>
                {
                    ValueA--;
                });
            }
        }

        public ICommand B1Plus
        {
            get
            {
                return new FuncButton((obj) =>
                {
                    ValueB++;
                });
            }
        }
        public ICommand B1Minus
        {
            get
            {
                return new FuncButton((obj) =>
                {
                    ValueB--;
                });
            }
        }

        #endregion




    }
}

