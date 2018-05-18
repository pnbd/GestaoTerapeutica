using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoTerapeutica.Models
{
    public class Farmacia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FarmId { get; set; }
        public string NomeFarm { get; set; }
        public string MoradaRua { get; set; }
        public int MoradaAndar { get; set; }
        public int MoradaCodPost { get; set; }
        public int ContactoTelefone { get; set; }
        public string ContactoMail { get; set; }
        public virtual ICollection<ReservaFarmaco> Reservas { get; set; }
    }
}