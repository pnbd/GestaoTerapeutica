using System.Collections.Generic;

namespace GestaoTerapeutica.Models
{
    class Direccao
    {
        public Direccao()
        {
            this.Utentes = new HashSet<Utente>();
        }
        //Numero de funcionario da Direcção do lar
        public int NumDir { get; set; }
        public string Nome { get; set; }
        public string Funcao { get; set; }

        public virtual ICollection<Utente> Utentes { get; set; }
    }
}