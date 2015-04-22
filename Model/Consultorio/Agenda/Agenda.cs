using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Agenda : Base
    {
        public string Nome { get; protected set; }
        public string Descricao { get; protected set; }
        public DateTime DataAbertura { get; protected set; }
        public DateTime DataFechamento { get; protected set; }

        public Guid MedicoId { get; protected set; }
        public Medico Medico { get; protected set; }

        private ICollection<Consulta> _consultas;
        public ICollection<Consulta> Consultas 
        {
            get { return _consultas; } protected set { _consultas = new List<Consulta>(value); }
        }

        protected Agenda() { _consultas = new List<Consulta>(); }
        public Agenda(string nome, string Descricao, DateTime dataAbertura, DateTime dataFechamento, Guid medicoId)
        {
            this.Nome = nome;
            this.Descricao = Descricao;
            this.DataAbertura = dataAbertura;
            this.DataFechamento = dataFechamento;
            this.MedicoId = medicoId;
            this._consultas = new List<Consulta>();
        }

        public void AddConsulta(Consulta consulta)
        {
            this._consultas.Add(consulta);
        }
    }
}
