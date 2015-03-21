using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEF.Mapping
{
    public class BaseEntityConfiguration<T> : EntityTypeConfiguration<T> where T : Model.Base     
    {
        public BaseEntityConfiguration(string tableName)
        {
            ToTable(tableName);

            HasKey(x => x.Id).Property(x=>x.Id).HasColumnName("id");
            Property(x => x.DataCriacao).HasColumnName("dt_criacao");
            Property(x => x.DataModificacao).HasColumnName("dt_modificacao");
        }
    }
}
