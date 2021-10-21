using AtelierMVVM.Helpers;
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
using System.Windows.Shapes;

namespace AtelierMVVM.ViewModel
{
    /// <summary>
    /// Interaction logic for Authentication.xaml
    /// </summary>
    public partial class Authentication : Window
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void Connecter_Click(object sender, RoutedEventArgs e)
        {
            if(cbxModeAuth.IsChecked == true)
            {
                AuthentificationWindow();
            }
            else
            {
                AuthenticationBase(); 
            }
            
        }

        private void AuthenticationBase()
        {
            MessageBox.Show("Authentification en base...");
            this.DialogResult = true; 
        }

        private void AuthentificationWindow()
        {
            MessageBox.Show($"le login est {txtLogin.Text}, mot de passe {pwUser.Password}"); 
                //bool ok = true;
                bool ok = false;
            ok = AccessHelper.IsAuthentificationCorrect(txtLogin.Text, pwUser.Password); 
                if (ok)
                {
                    this.DialogResult = true;
                }
                else
                {
                    this.DialogResult = false;
                }
            
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false; 
        }
    }
}
