using AtelierMVVM.ViewModel;
using Microsoft.Win32;
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
    /// Logique d'interaction pour PageAjoutPersonnel.xaml
    /// </summary>
    public partial class PageAjoutPersonnel : Page
    {
        CrudPersonnelViewModel crudViewModel = new CrudPersonnelViewModel();

        public PageAjoutPersonnel()
        {

            InitializeComponent();
            DataContext = crudViewModel;
        }
        private void ImporterImage_Click(object sender, RoutedEventArgs e)
        {
            {
                // Ouvir le fenetre pour selectionner un fichier
                // OpenFileIDialogue -- est la classe qui nous permet d'ouvre la boite qui permet de selectionner un fichier
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == true)
                {

                    string cheminFic = ofd.FileName;

                    var r = new Uri(cheminFic);
                    image.Source = new BitmapImage(r);

                }

            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
