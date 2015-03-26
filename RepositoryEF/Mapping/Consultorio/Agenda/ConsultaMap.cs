using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEF.Mapping.Consultorio.Agenda
{
    public class ConsultaMap : BaseEntityConfiguration<Model.Consulta>
    {
        public ConsultaMap() : base("consulta")
        {
            Property(x => x.DataAgendamento).HasColumnName("dt_agendamento");
            Property(x => x.AgendaId).HasColumnName("id_agenda");
            Property(x => x.PacienteId).HasColumnName("id_paciente");
        }
    }
}
