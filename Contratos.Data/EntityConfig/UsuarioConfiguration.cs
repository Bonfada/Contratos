using Contratos.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Contratos.Data.EntityConfig
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            HasKey(c => c.Id);
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Nome).IsRequired().HasMaxLength(50);
            Property(c => c.Login).IsRequired().HasMaxLength(15);
            Property(c => c.Senha).IsRequired().HasMaxLength(100);
        }
    }
}
