using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Permissao : Base
    {
        public string Nome { get; protected set; }
        public string Descricao { get; protected set; }

        public Guid TipoUsuarioId { get; set; }
        public TipoUsuario TipoUsuario { get; set; }

        protected Permissao() { }
        public Permissao(string nome, string descricao, Guid tipoUsuarioId)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.TipoUsuarioId = tipoUsuarioId;
        }
    }
}
