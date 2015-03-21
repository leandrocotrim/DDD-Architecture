using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEF.Mapping.Pessoa
{
    public class MedicoMap : BaseEntityConfiguration<Model.Medico>
    {
        public MedicoMap() : base("medico")
        {
            Property(x => x.Formacao).HasColumnName("str_formacao");
            Property(x => x.DataFormacao).HasColumnName("dt_formacao");

            HasMany(x => x.Especialidades).WithMany(x => x.Medicos).Map(x => x.ToTable("medico_especialidade").MapLeftKey("id_especialidade").MapRightKey("id_medico"));
            HasMany(x => x.Agendas).WithRequired(x => x.Medico).WillCascadeOnDelete();

            HasRequired(x => x.Pessoa);
        }
    }
}
