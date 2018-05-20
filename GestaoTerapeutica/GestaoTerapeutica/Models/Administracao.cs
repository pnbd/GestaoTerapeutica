using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoTerapeutica.Models
{
    public class Administracao
    {

        //Numero de Identificação da administração, automaticamente gerado
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdminId { get; set; }
        //Data e hora da administração do fármaco
        public DateTime DataAdmin { get; set; }

        [ForeignKey("Funcionario")]
        public int FuncFk { get; set; }
        public virtual Funcionario Funcionario { get; set; }

        [ForeignKey("ReservaFarmaco")]
        public int ReservaFk { get; set; }
        public virtual ReservaFarmaco ReservaFarmaco { get; set; }
        
    }
}