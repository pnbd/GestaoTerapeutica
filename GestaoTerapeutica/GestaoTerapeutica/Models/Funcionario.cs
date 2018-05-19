using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoTerapeutica.Models
{
    public class Funcionario
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FuncId { get; set; }
        public string NomeFunc { get; set; }
        public int ContactoTelef { get; set; }
        public string ContactoMail { get; set; }

        public virtual ICollection<Administracao> Administracoes { get; set; }
    }
}