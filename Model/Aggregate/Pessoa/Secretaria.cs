using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Secretaria : Pessoa
    {
        //public Guid PessoaId { get; protected set; }
        public Pessoa Pessoa { get; protected set; }

        protected Secretaria() { }
        public Secretaria(Guid pessoaId)
        {
            this.Id = pessoaId;
        }
    }
}
