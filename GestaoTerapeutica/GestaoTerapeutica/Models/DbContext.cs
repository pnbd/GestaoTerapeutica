namespace GestaoTerapeutica.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public partial class MedsLarContext : DbContext
    {
        public MedsLarContext() : base("MedsLarConnectionString")
        { }

        public virtual DbSet<Direccao> Directores { get; set; }
        public virtual DbSet<Utente> Utentes { get; set; }
        public virtual DbSet<ReservaFarmaco> Reservas { get; set; }
        public virtual DbSet<Farmacia> Farmacias { get; set; }
        public virtual DbSet<Funcionario> Funcionarios { get; set; }
        public virtual DbSet<Medico> Medicos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
