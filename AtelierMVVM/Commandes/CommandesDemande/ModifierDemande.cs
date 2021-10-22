using AtelierMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AtelierMVVM.Model
{
    class ModifierDemande : ICommand

    {
        public event EventHandler CanExecuteChanged;

        CrudDemandeViewModel crudDemandeViewModel;

        public ModifierDemande(CrudDemandeViewModel crudDemandeViewModel)
        {
            this.crudDemandeViewModel = crudDemandeViewModel; 

        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            crudDemandeViewModel.ModifierDemande();
        }
    }
}
