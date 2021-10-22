using System;
using System.Windows.Input;

namespace AtelierMVVM.ViewModel
{
    public class EnregistrerAdresseCommand : ICommand

    {
        private CrudAdresseViewModel crudAdresseViewModel;

        public EnregistrerAdresseCommand(CrudAdresseViewModel crudAdresseViewModel)
        {
            this.crudAdresseViewModel = crudAdresseViewModel; 
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true; 
        }

        public void Execute(object parameter)
        {
            crudAdresseViewModel.AjouteAdresse(); 
        }
    }
}