using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoTerapeutica.Models
{
    public class ReservaFarmaco
    {
        public ReservaFarmaco()
        {
            this.Medicos = new HashSet<Medico>();
            this.Administracoes = new HashSet<Administracao>();
        }
        //Chave primária Gerada automaticamente
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReservaId { get; set; }
        //Código Nacional do Produto
        public int CNP { get; set; }
        //Substância Activa
        public string SubstAct { get; set; }
        //Forma Farmaceutica
        public string FormaFarm { get; set; }
        //Dosagem
        public string Dose { get; set; }
        //URL para o Resumo das Características do Medicamento
        public string LinkRCM { get; set; }
        //Numero de tomas diárias
        public float PosologiaDia { get; set; }
        //Número de tomas Semanais
        public float PosologiaSemana { get; set; }
        //Numero de tomas Mensais
        public float PosologiaMes { get; set; }
        //Existências de comprimidos
        public float CompExistentes { get; set; }

        public virtual ICollection<Medico> Medicos { get; set; }
        public virtual ICollection<Administracao> Administracoes { get; set; }

        [ForeignKey("Utente")]
        public int UtenteId { get; set; }
        public virtual Utente Utente { get; set; }

        [ForeignKey("Farmacia")]
        public int FarmaciaId { get; set; }
        public virtual Farmacia Farmacia { get; set; }
    }
}