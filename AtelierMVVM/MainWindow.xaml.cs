using AtelierMVVM.View;
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

namespace AtelierMVVM
{



    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PageAjoutPersonnel ajoutPersonnelPage = new PageAjoutPersonnel();

        public MainWindow()
        {

            InitializeComponent();
            AfficherAuthentification();

        }

        private void AfficherAuthentification()
        {
            // masquer la fenetre actuelle
            // this.Visibility = Visibility.Hidden;
            this.Hide();

            Authentication auth = new Authentication();
            if(auth.ShowDialog() == true)
            {
                this.Show(); 
            }
            else
            {
                MessageBox.Show("Connextion abanndoné, fermeture de l'application");
                this.Close(); 
            }
            // Ouverture en Modal
            auth.ShowDialog();
        }


        //private void ImporterImage_Click(object sender, RoutedEventArgs e)
        //{
        //    {
        //        // Ouvir le fenetre pour selectionner un fichier
        //        // OpenFileIDialogue -- est la classe qui nous permet d'ouvre la boite qui permet de selectionner un fichier
        //        OpenFileDialog ofd = new OpenFileDialog();
        //        if (ofd.ShowDialog() == true)
        //        {

        //            string cheminFic = ofd.FileName;

        //            var r = new Uri(cheminFic);
        //            //var image.Source = new BitmapImage(r);

        //        }

        //    }
        //}



        private void AppelPageAjoutPersonne_Click(object sender, RoutedEventArgs e)
        {
            frmPrincipale.Navigate(ajoutPersonnelPage);

        }
    }
}
