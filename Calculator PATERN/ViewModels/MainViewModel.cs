using Calculator_PATERN.ViewModels.Base;
using System.Windows.Input;

namespace Calculator_PATERN.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {


        #region Calculator свойства модели

        private int _ValueA;
        /// <summary>Свойства переменной "А"</summary>
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

