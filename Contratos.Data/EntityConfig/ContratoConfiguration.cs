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
            Property(c => c.Valor).IsRequired();
            HasRequired(c => c.Arquivo).WithMany().HasForeignKey(p => p.ArquivoId);
            HasRequired(c => c.Cliente).WithMany().HasForeignKey(p => p.ClienteId);
            HasRequired(c => c.Tipo).WithMany().HasForeignKey(p => p.TipoId);
        }
    }
}
