using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestaoTerapeutica.Models
{
    public class Direccao
    {
        public Direccao()
        {
            this.Utentes = new HashSet<Utente>();
        }
        //Numero de funcionario da Direcção do lar
        [Key]
        public int DirId { get; set; }
        public string Nome { get; set; }
        public string Funcao { get; set; }

        public virtual ICollection<Utente> Utentes { get; set; }
    }
}