using Model.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pessoa : Base
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public Medico Medico { get; protected set; }
        public Paciente Paciente { get; protected set; }
        public Secretaria Secretaria { get; protected set; }
        public Usuario Usuario { get; protected set; }

        protected Pessoa() { }
        public Pessoa(string nome, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;

            DomainEvents.Raise<EnviarEmail>(new EnviarEmail("cotrim.leandro@gmail.com"));
        }
    }
}
