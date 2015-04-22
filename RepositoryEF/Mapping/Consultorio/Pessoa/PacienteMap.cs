using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEF.Mapping
{
    public class PacienteMap : BaseEntityConfiguration<Model.Paciente>
    {
        public PacienteMap() : base("paciente")
        {
            Property(x => x.TipoPaciente).HasColumnName("enum_tipo_paciente");

            HasRequired(x => x.Pessoa);
        }
    }
}
