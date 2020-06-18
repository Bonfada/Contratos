using Contratos.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Contratos.Data.EntityConfig
{
    public class ArquivoConfiguration : EntityTypeConfiguration<Arquivo>
    {
        public ArquivoConfiguration()
        {
            HasKey(c => c.Id);
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Nome).IsRequired().HasMaxLength(50);
        }
    }
}
