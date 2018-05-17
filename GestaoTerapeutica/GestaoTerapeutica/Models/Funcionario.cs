using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestaoTerapeutica.Models
{
    public class Funcionario
    {
        public Funcionario()
        {
            this.Reservas = new HashSet<ReservaFarmaco>(); 
        }
        [Key]
        public int FuncId { get; set; }
        public string NomeFunc { get; set; }

        public virtual ICollection<ReservaFarmaco> Reservas { get; set; }
    }
}