using AtelierMVVM.Commandes.CommandesPersonnel;
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
    public class CrudPersonnelViewModel: IDisposable
    {
        private MVVMGestionEmailDBEntities db = new MVVMGestionEmailDBEntities();


        public AjouterPersonnel AjouterPersonnelVM { get; set; }
        public ModifierPersonnel ModifierPersonnelVM { get; set; }
        public RecherPersonnelParMatricule RecherPersonnelParMatriculeVM { get; set; }
        public SupprimerPersonne SupprimerPersonneVM { get; set; }
      
        public Personnel PersonnelVM { set; get; }
        public AdresseDomicile AdresseVM { get; set; }
        public Service ServiceVM { get; set; }

        public ObservableCollection<Service> ServicesVM { get; set; }
        public ObservableCollection<AdresseDomicile> AdressesVM { get; set; }
        public ObservableCollection<Personnel> ListPersonnelsVM { get; set; }

        internal void ModifierPersonnel()
        {
            throw new NotImplementedException();
        }

        public CrudPersonnelViewModel()
        {
            AjouterPersonnelVM = new AjouterPersonnel(this);
            ModifierPersonnelVM = new ModifierPersonnel(this);
                        
                if(ListPersonnelsVM == null)
            {
                ListPersonnelsVM = new ObservableCollection<Personnel>(db.Personnels); 
            }

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

             
        }


        public void AjouterPersonne()
        {
            PersonnelVM.AdresseDomicile = AdresseVM;
            PersonnelVM.Service = ServiceVM;
            db.Personnels.Add(PersonnelVM);
            db.SaveChanges();
            
        }

        public void ModifierPersonnel(Personnel personnel)
        {
            var personnelAModifier = db.Personnels.FirstOrDefault(x => x.Matricule == personnel.Matricule);
            personnelAModifier.Nom = personnel.Nom; 
            personnelAModifier.Prenom = personnel.Prenom; 
            personnelAModifier.LieuNaissance = personnel.LieuNaissance; 
            personnelAModifier.Matricule = personnel.Matricule; 
            personnelAModifier.DateNaissance = personnel.DateNaissance; 
            personnelAModifier.EmailPersonnel = personnel.EmailPersonnel; 
            personnelAModifier.Profil = personnel.Profil; 
            personnelAModifier.Photo = personnel.Photo; 
            personnelAModifier.TypeDeContrat = personnel.TypeDeContrat; 
            //personnelAModifier.AdresseDomicile_Id = personnel.AdresseDomicile_Id; 
            db.SaveChanges();

        }

        public List<Personnel> ListPersonnels()
        {
            return db.Personnels.ToList(); 
        }


        public Personnel RecherPersonnelParMatricule(Personnel personnel)
        {
            Personnel personnelARechercher = db.Personnels.FirstOrDefault(x => x.Matricule == personnel.Matricule);
            return personnelARechercher; 
            
        }

        public void SupprimerPersonne(Personnel personnel)
        {
            Personnel personnelASupprimer = db.Personnels.FirstOrDefault(x => x.Matricule == personnel.Matricule);
            db.SaveChanges();

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

}
