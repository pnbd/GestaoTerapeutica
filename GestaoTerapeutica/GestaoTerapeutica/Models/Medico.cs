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
        //Id do Médico, igual ao Número da Ordem dos Médicos
        [Key]
        public int NumOrdem { get; set; }
        public string NomeDoc { get; set; }
        public string Especialidade { get; set; }
        public int ContactoTelef { get; set; }
        public string ContactoMail { get; set; }

        public virtual ICollection<ReservaFarmaco> Reservas { get; set; }
    }
}