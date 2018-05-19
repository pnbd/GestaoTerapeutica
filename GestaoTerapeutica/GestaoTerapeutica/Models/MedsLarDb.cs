namespace GestaoTerapeutica.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class MedsLarDb : DbContext
    {
        // Your context has been configured to use a 'MedsLarDb' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'GestaoTerapeutica.Models.MedsLarDb' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MedsLarDb' 
        // connection string in the application configuration file.
        public MedsLarDb()
            : base("name=MedsLarDb")
        {

        }
        public virtual DbSet<Patologia> Patologias { get; set; }
        public virtual DbSet<Utente> Utentes { get; set; }
        public virtual DbSet<ReservaFarmaco> Reservas { get; set; }
        public virtual DbSet<Farmacia> Farmacias { get; set; }
        public virtual DbSet<Funcionario> Funcionarios { get; set; }
        public virtual DbSet<Medico> Medicos { get; set; }
        public virtual DbSet<Administracao> Administracoes { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}