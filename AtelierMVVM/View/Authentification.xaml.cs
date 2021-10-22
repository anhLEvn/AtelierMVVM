using AtelierMVVM.Helpers;
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
using System.Windows.Shapes;

namespace AtelierMVVM.ViewModel
{
    /// <summary>
    /// Interaction logic for Authentication.xaml
    /// </summary>
    public partial class Authentication : Window

    {
        private static int NbEssaie = 3; 

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

            MVVMGestionEmailDBEntities db = new MVVMGestionEmailDBEntities();
            string login = txtLogin.Text;
            string pwdCrype = CryptHelper .Base64Encode(pwUser.Password);

            var compteAchercher = db.Comptes.FirstOrDefault(x => (x.Login.Equals(login) && x.Password.Equals(pwdCrype))); 
            
            if(compteAchercher != null)
            {
                this.DialogResult = true; 
            }
            else
            {
                NbEssaie--;
                MessageBox.Show($" Nombre d'essaie retant {NbEssaie}");

                if (NbEssaie == 0)
                {
                    MessageBox.Show($" Nombre d'essaie dépassé");
                    this.DialogResult = false;
                }
            }
            this.DialogResult = true; 
        }

        private void AuthentificationWindow()
        {
            MessageBox.Show($"le login est {txtLogin.Text}, mot de passe {pwUser.Password}"); 
                //bool ok = true;
                bool ok = false;
            ok = AccessHelper.IsLoginCorrecte(txtLogin.Text, pwUser.Password, "");  
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
