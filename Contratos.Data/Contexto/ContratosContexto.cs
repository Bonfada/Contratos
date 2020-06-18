using Contratos.Data.EntityConfig;
using Contratos.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Contratos.Data.Contexto
{
    public class ContratosContexto : DbContext
    {
        public ContratosContexto() : base("contratosbd") 
        {
            var ensureDLLIsCopied =
                System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public DbSet<Arquivo> Arquivo { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Contrato> Contrato { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ArquivoConfiguration());
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new ContratoConfiguration());
            modelBuilder.Configurations.Add(new UsuarioConfiguration());
        }
    }
}
