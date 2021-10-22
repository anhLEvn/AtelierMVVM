using AtelierMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierMVVM.Commandes.CommandesDemande
{
    public class AjouterCreationDemande
    {
        private CrudDemandeViewModel crudDemandeViewModel;

        public AjouterCreationDemande(CrudDemandeViewModel crudDemandeViewModel)
        {
            this.crudDemandeViewModel = crudDemandeViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            crudDemandeViewModel.AjouterCreationDemande();
        }
    }
}
