using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEF.Mapping.Consultorio.Agenda
{
    public class AgendaMap : BaseEntityConfiguration<Model.Agenda>
    {
        public AgendaMap() : base("agenda")
        {                      
            Property(x => x.Nome).HasColumnName("str_nome");
            Property(x => x.Descricao).HasColumnName("str_descricao");
            Property(x => x.DataAbertura).HasColumnName("dt_abertura");
            Property(x => x.DataFechamento).HasColumnName("dt_fechamento");
            Property(x => x.MedicoId).HasColumnName("id_medico");

            HasMany(x => x.Consultas).WithRequired(x => x.Agenda).WillCascadeOnDelete();
        }
    }
}
