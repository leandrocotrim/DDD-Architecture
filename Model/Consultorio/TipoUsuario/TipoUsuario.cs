using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TipoUsuario : Base
    {
        public string Nome { get; protected set; }

        private IList<Permissao> _permissao;
        public ICollection<Permissao> Permissoes 
        {
            get { return _permissao; }
            protected set { _permissao = new List<Permissao>(value); }
        }

        protected TipoUsuario() { Permissoes = new List<Permissao>(); }
        public TipoUsuario(string nome)
        {
            this.Nome = nome;
            this._permissao = new List<Permissao>();
        }

        public void AddPermissao(Permissao permissao)
        {
            this._permissao.Add(permissao);
        }
    }
}
