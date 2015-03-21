using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEF.Mapping.Pessoa
{
    public class UsuarioMap : BaseEntityConfiguration<Model.Usuario>
    {
        public UsuarioMap() : base("usuario")
        {
            Property(x => x.Ativo).HasColumnName("bol_ativo");
            Property(x => x.TipoUsuarioId).HasColumnName("id_tipo_usuario");

            HasRequired(x => x.Pessoa);
        }
    }
}
