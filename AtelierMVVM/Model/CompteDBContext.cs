using System;
using System.Data.Entity;
using System.Linq;

namespace AtelierMVVM.Model
{
    public class CompteDBContext : DbContext
    {
        // Your context has been configured to use a 'CompteDBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'AtelierMVVM.Model.CompteDBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CompteDBContext' 
        // connection string in the application configuration file.
        public CompteDBContext()
            : base("name=CompteDBContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Compte> Comptes { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}