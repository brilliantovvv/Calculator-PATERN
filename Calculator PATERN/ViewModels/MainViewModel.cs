using Calculator_PATERN.Infrastructure.Commands;
using Calculator_PATERN.ViewModels.Base;
using System.Windows;
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

        #endregion

        #region Calculator КОМАНДЫ модели V1
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

        #region КОМАНДЫ модели V2 (пример)

        public ICommand ClosseAppCommand { get; }

        private bool CanCloseApplicationCommandExecute(object p) => true;

        private void OnCloseApplicationCommandExeceted(object p)
        {
            Application.Current.Shutdown();
        }

        public MainViewModel()
        {
            ClosseAppCommand = new LCommand(OnCloseApplicationCommandExeceted, CanCloseApplicationCommandExecute);
        }

        #endregion


    }
}

