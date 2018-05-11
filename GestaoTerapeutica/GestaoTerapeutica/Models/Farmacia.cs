using System.Collections.Generic;

namespace GestaoTerapeutica.Models
{
    class Farmacia
    {
        public int CodFarmacia { get; set; }
        public string NomeFarm { get; set; }
        public virtual ICollection<ReservaFarmaco> Reservas { get; set; }
    }
}