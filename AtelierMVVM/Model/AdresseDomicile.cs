//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AtelierMVVM.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class AdresseDomicile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AdresseDomicile()
        {
            this.Personnels = new HashSet<Personnel>();
        }
    
        public int Id { get; set; }
        public string Numero { get; set; }
        public string NomRue { get; set; }
        public string Ville { get; set; }
        public string CodePostal { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personnel> Personnels { get; set; }
    }
}
