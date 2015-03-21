using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEF.Mapping
{
    public class PermissaoMap : BaseEntityConfiguration<Model.Permissao>
    {
        public PermissaoMap() : base("permissao")
        {
            Property(x => x.Nome).HasColumnName("str_nome");
            Property(x => x.Descricao).HasColumnName("str_descricao");
            Property(x => x.TipoUsuarioId).HasColumnName("id_tipo_usuario");
        }
    }
}
