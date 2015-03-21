using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEF.Mapping.Pessoa
{
    public class PessoaMap : BaseEntityConfiguration<Model.Pessoa>
    {
        public PessoaMap() : base("pessoa")
        {
            Property(x => x.Nome).HasColumnName("str_nome");
            Property(x => x.DataNascimento).HasColumnName("dt_nascimento");

            HasOptional(x => x.Medico).WithOptionalDependent(x => x.Pessoa).WillCascadeOnDelete();
            HasOptional(x => x.Paciente).WithOptionalDependent(x => x.Pessoa).WillCascadeOnDelete();
            HasOptional(x => x.Secretaria).WithOptionalDependent(x => x.Pessoa).WillCascadeOnDelete();
            HasOptional(x => x.Usuario).WithOptionalDependent(x => x.Pessoa).WillCascadeOnDelete();
        }
    }
}
