using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Especialidade : Base
    {
        public string Nome { get; protected set; }
        public string Descricao { get; protected set; }

        private ICollection<Medico> _medicos;
        public ICollection<Medico> Medicos
        {
            get { return _medicos; } 
            protected set { _medicos = new List<Medico>(value); } 
        }

        protected Especialidade() { _medicos = new List<Medico>(); }
        public Especialidade(string nome, string descricao)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this._medicos = new List<Medico>();
        }
    }
}
