using System.Collections.Generic;

namespace GestaoTerapeutica.Models
{
    class Medico
    {
        public Medico()
        {
            this.Reservas = new HashSet<ReservaFarmaco>();
        }

        public int NumOrdem { get; set; }
        public string NomeDoc { get; set; }
        public string Especialidade { get; set; }

        public virtual ICollection<ReservaFarmaco> Reservas { get; set; }
    }
}