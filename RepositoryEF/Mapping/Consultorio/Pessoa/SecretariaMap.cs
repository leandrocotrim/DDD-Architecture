using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEF.Mapping.Consultorio.Pessoa
{
    public class SecretariaMap : BaseEntityConfiguration<Model.Secretaria>
    {
        public SecretariaMap() : base("secretaria")
        {
            HasRequired(x => x.Pessoa);
        }
    }
}
