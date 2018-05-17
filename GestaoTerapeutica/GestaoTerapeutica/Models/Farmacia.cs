using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestaoTerapeutica.Models
{
    public class Farmacia
    {
        [Key]
        public int FarmaciaId { get; set; }
        public string NomeFarm { get; set; }
        public virtual ICollection<ReservaFarmaco> Reservas { get; set; }
    }
}