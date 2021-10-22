using AtelierMVVM.Helpers;
using AtelierMVVM.Model;
using System;
using System.Windows.Input;

namespace AtelierMVVM.ViewModel
{
    public class VerifiAdresseCommand : ICommand
    {
        private CrudAdresseViewModel crudAdresseViewModel;

        public VerifiAdresseCommand(CrudAdresseViewModel crudAdresseViewModel)
        {
            this.crudAdresseViewModel = crudAdresseViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            AdresseDomicile adresseATrouver = new AdresseDomicile(); 
            var adresse = await AccesAPIHelper.GetAdresses(adresseATrouver.NomRue);
            crudAdresseViewModel.AdressesVM.Clear(); 
        }
    }
}