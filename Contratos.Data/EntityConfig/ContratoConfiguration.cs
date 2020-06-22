using Contratos.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Contratos.Data.EntityConfig
{
    public class ContratoConfiguration : EntityTypeConfiguration<Contrato>
    {
        public ContratoConfiguration()
        {
            HasKey(c => c.Id);
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Quantidade).IsRequired();
            Property(c => c.Arquivo).IsRequired();
            Property(c => c.Tipo).IsRequired().HasMaxLength(50); 
            Property(c => c.Valor).IsRequired();
            HasRequired(c => c.Cliente).WithMany().HasForeignKey(p => p.ClienteId);
        }
    }
}
