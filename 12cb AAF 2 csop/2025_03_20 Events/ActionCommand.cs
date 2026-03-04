using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _2025_03_20_Events
{
    internal class ActionCommand : ICommand
    {
        //Fields
        private readonly Action action;


        //Konstruktor
        public ActionCommand(Action action)
        {
            this.action = action;
        }

        //Methods
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            action();
        }
    }
}
