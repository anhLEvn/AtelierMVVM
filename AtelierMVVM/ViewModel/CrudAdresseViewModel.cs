using AtelierMVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierMVVM.ViewModel
{
   public class CrudAdresseViewModel: IDisposable
    {
        private MVVMGestionEmailDBEntities db = new MVVMGestionEmailDBEntities();

        public AdresseDomicile AdresseVM { get; set; }
        public VerifiAdresseCommand VerifiAdresseVM { get; set; }
        public EnregistrerAdresseCommand EnregistreAdresseVM { get; set; }

        public ObservableCollection<AdresseDomicile> AdressesVM { get; set; }

        public CrudAdresseViewModel()
        {
            AdresseVM = new AdresseDomicile(); 

            if(VerifiAdresseVM == null)
            {
                VerifiAdresseVM = new VerifiAdresseCommand(this); 
            }

            if (EnregistreAdresseVM == null)
            {
                EnregistreAdresseVM = new EnregistrerAdresseCommand(this);
            }
            if(AdressesVM == null)
            {
                AdressesVM = new ObservableCollection<AdresseDomicile>();
                AdresseVM = new AdresseDomicile(); 
            }
        }

        public void AjouteAdresse()
        {
            db.AdresseDomiciles.Add(AdresseVM);
            db.SaveChanges(); 

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
