using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestaoTerapeutica.Models
{
    public class Medico
    {
        public Medico()
        {
            this.Reservas = new HashSet<ReservaFarmaco>();
        }

        [Key]
        public int DocId { get; set; }
        public string NomeDoc { get; set; }
        public string Especialidade { get; set; }

        public virtual ICollection<ReservaFarmaco> Reservas { get; set; }
    }
}