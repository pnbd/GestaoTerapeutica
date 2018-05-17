using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestaoTerapeutica.Models
{
    public class Utente
    {
        public Utente()
        {
            this.Directores = new HashSet<Direccao>();
        }

        [Key]
        public int UtenteId { get; set; }
        public DateTime DataNascimento { get; set; }
        public Patologia Patologias { get; set; }
        public virtual ICollection<Direccao> Directores { get; set; }
        public virtual ICollection<ReservaFarmaco> Reservas { get; set; }
    }

    public class Patologia
    {
        [Key]
        public int IdPatologia { get; set; }
        public string NomePatologia { get; set; }
        public ICollection<Utente> Utentes { get; set; }
    }
}