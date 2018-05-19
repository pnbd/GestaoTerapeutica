using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoTerapeutica.Models
{
    public class Utente
    {
        public Utente()
        {
            this.Patologias = new HashSet<Patologia>();
            this.Reservas = new HashSet<ReservaFarmaco>();
        }
        //Numero de Utente, automaticamente gerado
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UtenteId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public virtual ICollection<Patologia> Patologias { get; set; }
        public virtual ICollection<ReservaFarmaco> Reservas { get; set; }
    }

}