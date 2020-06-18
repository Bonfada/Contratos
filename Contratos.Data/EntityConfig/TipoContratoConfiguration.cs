using Contratos.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Contratos.Data.EntityConfig
{
    public class TipoContratoConfiguration : EntityTypeConfiguration<TipoContrato>
    {
        public TipoContratoConfiguration()
        {
            HasKey(c => c.Id);
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Descricao).IsRequired().HasMaxLength(50);
        }
    }
}
