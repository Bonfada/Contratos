using System.Collections.Generic;

namespace Contratos.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public virtual IEnumerable<Contrato> Contratos { get; set; }
    }
}
