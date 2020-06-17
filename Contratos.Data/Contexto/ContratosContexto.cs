using Contratos.Domain.Entities;
using System.Data.Entity;
using System.Security.Permissions;

namespace Contratos.Data.Contexto
{
    public class ContratosContexto : DbContext
    {
        public ContratosContexto() : base("contratosbd") { }

        public DbSet<Arquivo> Arquivo { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Contrato> Contrato { get; set; }
        public DbSet<TipoContrato> TipoContrato { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
