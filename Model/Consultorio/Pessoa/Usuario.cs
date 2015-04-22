using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Usuario : Pessoa
    {
        public Pessoa Pessoa { get; protected set; }

        public bool Ativo { get; protected set; }

        public Guid TipoUsuarioId { get; protected set; }
        public TipoUsuario TipoUsuario { get; protected set; }

        public ICollection<Permissao> _permissoes; 
        public ICollection<Permissao> Permissoes 
        {
            get { return _permissoes; } protected set { _permissoes = new List<Permissao>(value); }
        }

        protected Usuario() { _permissoes = new List<Permissao>(); }
        public Usuario(Guid pessoaId, Guid tipoUsuarioId)
        {
            this.Id = pessoaId;
            this.TipoUsuarioId = tipoUsuarioId;
            this.Ativo = true;
            this._permissoes = new List<Permissao>();
        }

        public void DesativaUsuario() { this.Ativo = false; }
        public void AtivaUsuario() { this.Ativo = true; }
        public void AddPermissao(Permissao permissao) { this._permissoes.Add(permissao); }
    }
}
