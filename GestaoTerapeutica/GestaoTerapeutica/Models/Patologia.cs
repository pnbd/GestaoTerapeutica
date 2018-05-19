using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GestaoTerapeutica.Models
{
    public class Patologia
    {
        public Patologia()
        {
            this.Utentes = new HashSet<Utente>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatId { get; set; }
        public string Nome { get; set; }
        public string Especialidade { get; set; }
        public virtual ICollection<Utente> Utentes { get; set; }
    }
}