using AtelierMVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AtelierMVVM.View
{
    /// <summary>
    /// Interaction logic for PageGestionCompte.xaml
    /// </summary>
    public partial class PageGestionCompte : Page
    {
        private MVVMGestionEmailDBEntities db = new MVVMGestionEmailDBEntities(); 
        public PageGestionCompte()
        {
            InitializeComponent();
        }

        private void Enregistre_Click(object sender, RoutedEventArgs e)
        {
            Compte compte = new Compte();
            db.Comptes.Add(compte);
            db.SaveChanges(); 
        }
    }

    
}
