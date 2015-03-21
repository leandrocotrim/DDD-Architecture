using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEF.Mapping.TipoUsuario
{
    public class TipoUsuarioMap : BaseEntityConfiguration<Model.TipoUsuario>
    {
        public TipoUsuarioMap() : base("tipo_usuario")
        {
            Property(x => x.Nome).HasColumnName("str_nome");

            HasMany(x => x.Permissoes).WithRequired(x => x.TipoUsuario).WillCascadeOnDelete();
        }
    }
}
