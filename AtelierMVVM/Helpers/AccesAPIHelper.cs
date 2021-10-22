using AtelierMVVM.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AtelierMVVM.Helpers
{
   public class AccesAPIHelper
    {
        public static async  Task<List<AdresseDomicile>> GetAdresses(string adr)
        {
            //HttpClient -- pour acceder à un WS REST
            HttpClient client = new HttpClient();
            string pathURL = ConfigurationManager.AppSettings["urlAdresse"]+adr;

            string contenuFormaJson = await client.GetStringAsync(pathURL);
            //client.BaseAddress = "https://api-adresse.data.gouv.fr/search/?q=anne";

            //désérialiser --> convertir au format de class AdresseGov

            var retour = JsonConvert.DeserializeObject<AdresseGov>(contenuFormaJson);

            List<AdresseDomicile> adresseDomiciles = new List<AdresseDomicile>(); 

            foreach(var item in retour.caracteristique)
            {
                AdresseDomicile adresse = new AdresseDomicile();
                adresse.NomRue = item.propertiesAdresse.name;
                adresse.Ville = item.propertiesAdresse.city;
                adresse.CodePostal = item.propertiesAdresse.postcode;

                adresseDomiciles.Add(adresse); 
            }
            client.Dispose();
            return adresseDomiciles; 
        }
    }
}
