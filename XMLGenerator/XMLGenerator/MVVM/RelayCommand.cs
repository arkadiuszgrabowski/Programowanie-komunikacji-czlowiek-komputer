﻿using System;
using System.Windows.Input;

namespace XMLGenerator.MVVM
{
    public class RelayCommand : ICommand
    {
        public RelayCommand(Action execute) : this(execute, null)
        { }

        public RelayCommand(Action execute, Func<bool> canExecute)
        {
            if (execute == null)
                throw new ArgumentNullException(nameof(execute));
            this.m_Execute = execute;
            this.m_CanExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (this.m_CanExecute == null)
                return true;
            if (parameter == null)
                return this.m_CanExecute();
            return this.m_CanExecute();
        }

        public virtual void Execute(object parameter)
        {
            this.m_Execute();
        }

        public event EventHandler CanExecuteChanged;

        internal void RaiseCanExecuteChanged()
        {
            this.CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        private readonly Action m_Execute;
        private readonly Func<bool> m_CanExecute;

    }
}
