using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierMVVM.Model
{


    public class AdresseGov
        {
            public string type { get; set; }
            public string version { get; set; }
            public Caracteristique[] caracteristique { get; set; }
            public string attribution { get; set; }
            public string licence { get; set; }
            public string query { get; set; }
            public int limit { get; set; }
        }

    
}
