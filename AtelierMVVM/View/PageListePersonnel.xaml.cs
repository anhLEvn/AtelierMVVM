using AtelierMVVM.ViewModel;
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
    /// Interaction logic for PageListePersonnel.xaml
    /// </summary>
    public partial class PageListePersonnel : Page
    {
        PageModifierPersonnel pageModifierPersonnel; 

        CrudPersonnelViewModel crudPersonnelviewModel = new CrudPersonnelViewModel(); 

        public PageListePersonnel()
        {
            InitializeComponent();
            DataContext = crudPersonnelviewModel; 
        }

        private void AppelPageModifierPersonnel_Click(object sender, RoutedEventArgs e)
        {
            pageModifierPersonnel = new PageModifierPersonnel(crudPersonnelviewModel.PersonnelVM); 
            
        }
    }
}
