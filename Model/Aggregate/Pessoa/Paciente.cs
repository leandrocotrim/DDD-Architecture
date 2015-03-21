using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Paciente : Pessoa
    {
        //public Guid PessoaId { get; protected set; }
        public Pessoa Pessoa { get; protected set; }
        public TipoPaciente TipoPaciente { get; protected set; }

        protected Paciente() { }
        public Paciente(Guid pessoaId, TipoPaciente tipoPaciente)
        {
            this.Id = pessoaId;
            this.TipoPaciente = tipoPaciente;
        }

        public void UpdateTipoPaciente(TipoPaciente tipoPaciente)
        {
            this.TipoPaciente = tipoPaciente;
        }
    }
}
