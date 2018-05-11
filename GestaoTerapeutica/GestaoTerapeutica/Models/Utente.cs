using System;
using System.Collections.Generic;

namespace GestaoTerapeutica.Models
{
    class Utente
    {
        public Utente()
        {
            this.Directores = new HashSet<Direccao>();
        }

        public int NumUtente { get; set; }
        public DateTime DataNascimento { get; set; }
        public Patologia Patologias { get; set; }
        public virtual ICollection<Direccao> Directores { get; set; }
        public virtual ICollection<ReservaFarmaco> Reservas { get; set; }
    }

    class Patologia
    {
        public int IdPatologia { get; set; }
        public string NomePatologia { get; set; }
        public ICollection<Utente> Utentes { get; set; }
    }
}