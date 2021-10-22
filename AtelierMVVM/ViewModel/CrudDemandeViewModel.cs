using AtelierMVVM.Commandes.CommandesDemande;
using AtelierMVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierMVVM.ViewModel
{
    public class CrudDemandeViewModel: IDisposable
    {
        private MVVMGestionEmailDBEntities db = new MVVMGestionEmailDBEntities();


        public AjouterCreationDemande AjouterCreationDemandeVM { get; set; }

        public DemandeCreation2 DemandeCreationVM { set; get; }               
        public Service ServiceVM { get; set; }

        public ObservableCollection<Service> ServicesVM { get; set; }

        public ObservableCollection<Personnel> RespServicesVM { get; set; }

        internal void ModifierDemande()
        {
            throw new NotImplementedException();
        }


        public CrudDemandeViewModel()
        {
            AjouterCreationDemandeVM = new AjouterCreationDemande(this);

            if (ServicesVM == null)
            {
                ServicesVM = new ObservableCollection<Service>(db.Services);
                ServiceVM = new Service();
            }


            if (DemandeCreationVM == null)
            {
                DemandeCreationVM = new DemandeCreation2();
            }

            if (RespServicesVM == null)
            {
                RespServicesVM = new ObservableCollection<Personnel>(db.Personnels);
                //RespService r = new RespService();
                //List<RespService> list = db.Personnels.
                //AdresseVM = new AdresseDomicile();
            }
        }



        public void AjouterCreationDemande()
        {

            db.DemandeCreation2.Add(DemandeCreationVM); 
            db.SaveChanges();
           

        }



        public void ModifierDemande(DemandeCreation2 demandeCreation)
        {
            db.DemandeCreation2.FirstOrDefault(x => x.Id == demandeCreation.Id);

            db.SaveChanges();


        }

        public DemandeCreation2 RechercheDemandeCreationParId(DemandeCreation2 demandeCreation)
        {
            DemandeCreation2 demandeCreationARecher = db.DemandeCreation2.FirstOrDefault(x => x.Id == demandeCreation.Id);
      
            return demandeCreation;
        }

        public List<DemandeCreation2> DemandeCreations()
        {
            return db.DemandeCreation2.ToList(); 
        }


        public void SupprimerCreations(DemandeCreation2 demandeCreation)
        {
            db.DemandeCreation2.FirstOrDefault(x => x.Id == demandeCreation.Id);
            db.DemandeCreation2.Remove(demandeCreation);
            db.SaveChanges(); 
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }

        
    }
}
