using AtelierMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AtelierMVVM.Model
{
    public class CreerDemande : ICommand

    {
        public event EventHandler CanExecuteChanged;

        private CrudViewModel crudViewModel;

        public CreerDemande(CrudViewModel crudViewModel)
        {
            this.crudViewModel = crudViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            crudViewModel.CreerDemande();
        }
    }
}
