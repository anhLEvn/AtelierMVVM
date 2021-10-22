using AtelierMVVM.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AtelierMVVM.ViewModel
{
    public class AjouterPersonnel : ICommand
    {
        private CrudPersonnelViewModel crudPersonnelViewModel;

        public AjouterPersonnel(CrudPersonnelViewModel crudPersonnelViewModel)
        {
            this.crudPersonnelViewModel = crudPersonnelViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        { 
            return true;
        }

        public void Execute(object parameter)
        {
            crudPersonnelViewModel.AjouterPersonne();
        }
    }
}
