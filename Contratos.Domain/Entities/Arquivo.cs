using System.Collections.Generic;

namespace Contratos.Domain.Entities
{
    public class Arquivo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public byte[] Conteudo { get; set; }
        public virtual IEnumerable<Contrato> Contratos { get; set; }
    }
}
