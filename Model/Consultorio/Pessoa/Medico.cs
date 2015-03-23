using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Medico : Pessoa
    {
        public Pessoa Pessoa { get; protected set; }

        public string Formacao { get; protected set; }
        public DateTime DataFormacao { get; protected set; }

        private IList<Especialidade> _especialidades;
        public IList<Especialidade> Especialidades 
        {
            get { return _especialidades; }  protected set { _especialidades = new List<Especialidade>(value);} 
        }

        private IList<Agenda> _agendas;
        public IList<Agenda> Agendas 
        {
            get { return _agendas; } protected set { _agendas = new List<Agenda>(value); } 
        }

        protected Medico(){ _especialidades = new List<Especialidade>(); _agendas = new List<Agenda>(); }
        public Medico(Guid pessoaId, string formacao, DateTime dataFornacao)
        {
            this.Id = pessoaId;
            this.Formacao = formacao;
            this.DataFormacao = DataFormacao;
            this._especialidades = new List<Especialidade>();
            this._agendas = new List<Agenda>();            
        }

        public void AddEspecialidade(Especialidade especialidade) { this._especialidades.Add(especialidade); }
    }
}