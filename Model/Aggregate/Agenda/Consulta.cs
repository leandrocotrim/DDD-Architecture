using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Consulta : Base
    {
        public DateTime DataAgendamento { get; protected set; }
        public Guid AgendaId { get; protected set; }
        public Agenda Agenda { get; protected set; }
        public Guid PacienteId { get; protected set; } 
        public Paciente Paciente { get; protected set; }

        protected Consulta() { }
        public Consulta(DateTime dataAgendamento, Guid agendaId, Guid pacienteId)
        {
            this.DataAgendamento = dataAgendamento;
            this.AgendaId = agendaId;
            this.PacienteId = pacienteId;
        }
    }
}
