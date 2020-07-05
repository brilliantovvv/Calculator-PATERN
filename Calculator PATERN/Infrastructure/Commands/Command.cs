using Calculator_PATERN.Infrastructure.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_PATERN.Infrastructure.Commands
{
    class Command : BaseCommand
    {
        private  Action<object> _Execute;
        private Func<object,bool> _CanExecute;

        public Command(Action<object> Execote, Func<object,bool> CanExecute=null)
        {
            _Execute = Execote;
            _CanExecute = CanExecute;
        }
        public override bool CanExecute(object parameter)
        {
          return  _CanExecute == null || _CanExecute(parameter);
        }

        public override void Execute(object parameter)
        {
          return _Execute(parameter);
        }
    }
}
