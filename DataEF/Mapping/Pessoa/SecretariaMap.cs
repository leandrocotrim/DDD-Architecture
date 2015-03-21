using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEF.Mapping.Pessoa
{
    public class SecretariaMap : BaseEntityConfiguration<Model.Secretaria>
    {
        public SecretariaMap() : base("secretaria")
        {
            HasRequired(x => x.Pessoa);
        }
    }
}
