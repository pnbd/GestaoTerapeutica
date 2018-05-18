using System.Collections.Generic;

namespace GestaoTerapeutica.Models
{
    class Funcionario
    {
        public Funcionario()
        {
            this.Reservas = new HashSet<ReservaFarmaco>(); 
        }
        public int NumFunc { get; set; }
        public string NomeFunc { get; set; }

        public virtual ICollection<ReservaFarmaco> Reservas { get; set; }
    }
}