using Calculator_PATERN.Infrastructure.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_PATERN.Infrastructure.Commands
{
    // Наследуюемся от базового класса команд
   class LCommand : BaseCommand
    {
        // поля РЕДОНЛИ немного ускоряют процесс
        private readonly  Action<object> _Execute;
        private readonly Func<object,bool> _CanExecute;

        public LCommand(Action<object> Execote, Func<object,bool> CanExecute=null)
        {
            // добавили выброс исключения
            _Execute = Execote ?? throw new ArgumentNullException(nameof(Execote));
            _CanExecute = CanExecute;
        }
        // переписали с лямбдой
        public override bool CanExecute(object parameter)
            => _CanExecute == null || _CanExecute(parameter);

        // переписали с лямбдой
        public override void Execute(object parameter) 
            =>_Execute(parameter);
        
    }
}
