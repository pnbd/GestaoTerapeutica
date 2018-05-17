using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoTerapeutica.Models
{
    public class ReservaFarmaco
    {
        public ReservaFarmaco()
        {
            this.Funcionarios = new HashSet<Funcionario>();
            this.Medicos = new HashSet<Medico>();
        }
        [Key]
        public int ReservaId { get; set; }
        //Código Nacional do Produto
        public int CNP { get; set; }
        public string LinkRCM { get; set; }
        public int PosologiaDia { get; set; }
        public int PosologiaSemana { get; set; }
        public int PosologiaMes { get; set; }
        public float Existencias { get; set; }

        public virtual ICollection<Funcionario> Funcionarios { get; set; }
        public virtual ICollection<Medico> Medicos { get; set; }

        [ForeignKey("Utente")]
        public int UtenteFK { get; set; }
        public virtual Utente Utente { get; set; }

        [ForeignKey("Farmacia")]
        public int FarmaciaFK { get; set; }
        public virtual Farmacia Farmacia { get; set; }
    }
}