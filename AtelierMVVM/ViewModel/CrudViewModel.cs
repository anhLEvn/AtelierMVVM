using AtelierMVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierMVVM.ViewModel
{
    public class CrudViewModel
    {
        private EmailDBEntitiesContainer db = new EmailDBEntitiesContainer();


        public AjouterPersonnel AjouterPersonnelVM { get; set; }
        public CreerDemande CreerDemandeVM { get; set; }


        public Personnel PersonnelVM { set; get; }
        public DemandeCreation2 DemandeCreationVM { set; get; }

        public AdresseDomicile AdresseVM { get; set; }
        public Service ServiceVM { get; set; }
        public ObservableCollection<Service> ServicesVM { get; set; }
        public ObservableCollection<AdresseDomicile> AdressesVM { get; set; }
        public ObservableCollection<Personnel> RespServicesVM { get; set; }

        
        internal void CreerDemande()
        {
            throw new NotImplementedException();
        }



        //public CreerDemande CreerDemande { get; set; }
        //public DemandeCreation DemandeCreation { get; set; }

        // public ListPersonnel listPersonnel { get; set; }
        // public RecherchePersonnel listPersonnel { get; set; }

        public CrudViewModel()
        {
            AjouterPersonnelVM = new AjouterPersonnel(this);
            CreerDemandeVM = new CreerDemande(this);

            if (PersonnelVM == null)
            {
                PersonnelVM = new Personnel();
                // PersonnelVM.Photo = ConfigurationManager.AppSetting
                PersonnelVM.DateNaissance = DateTime.Now; 
            }
            if (ServicesVM == null)
            {
                ServicesVM = new ObservableCollection<Service>(db.Services);
                ServiceVM = new Service();
            } 
            
            if (AdressesVM == null)
            {
                AdressesVM = new ObservableCollection<AdresseDomicile>(db.AdresseDomiciles);
                AdresseVM = new AdresseDomicile();
            }

             if (DemandeCreationVM == null)
            {
                DemandeCreationVM = new DemandeCreation2(); 
            }

            if (RespServicesVM == null)
            {
                RespServicesVM = new ObservableCollection<Personnel>(db.Personnels);
                RespService r = new RespService();
                //List<RespService> list = db.Personnels.
                //AdresseVM = new AdresseDomicile();
            }
        }


        public void AjouterPersonne()
        {

            //db.AdresseDomiciles.Add(AdresseVM);
            //db.Services.Add(ServiceVM);
            PersonnelVM.AdresseDomicile = AdresseVM;
            PersonnelVM.Service1 = ServiceVM;
            db.Personnels.Add(PersonnelVM);
            db.SaveChanges();
            //int i =  db.SaveChanges();
            //return i>0;

        }

        public void AjouterCeationDemande()
        {

            //db.AdresseDomiciles.Add(AdresseVM);
            //db.Services.Add(ServiceVM);
            PersonnelVM.AdresseDomicile = AdresseVM;
            PersonnelVM.Service1 = ServiceVM;
            db.Personnels.Add(PersonnelVM);
            db.SaveChanges();
            //int i =  db.SaveChanges();
            //return i>0;

        }


    }

}
