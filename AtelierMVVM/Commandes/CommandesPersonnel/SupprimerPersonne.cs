﻿using AtelierMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AtelierMVVM.Commandes.CommandesPersonnel
{
    public class SupprimerPersonne : ICommand

    {
        CrudPersonnelViewModel crudPersonnelViewModel;

        public SupprimerPersonne(CrudPersonnelViewModel crudPersonnelViewModel)
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
            //crudPersonnelViewModel.SupprimerPersonne();
        }
    }
}
