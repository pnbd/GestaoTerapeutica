using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoTerapeutica.Models
{
    public class Utente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UtenteId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public ICollection<Patologia> Patologias { get; set; }
        public virtual ICollection<ReservaFarmaco> Reservas { get; set; }
    }

    public class Patologia
    {
        public int IdPatologia { get; set; }
        public string NomePatologia { get; set; }
        public ICollection<Utente> Utentes { get; set; }
    }
}