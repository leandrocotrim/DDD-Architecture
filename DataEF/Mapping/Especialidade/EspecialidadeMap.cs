using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEF.Mapping
{
    public class EspecialidadeMap : BaseEntityConfiguration<Model.Especialidade>
    {
        public EspecialidadeMap() : base("especialidade")
        {
            Property(x => x.Nome).HasColumnName("str_nome");
            Property(x => x.Descricao).HasColumnName("dt_descricao");       
        }
    }
}
