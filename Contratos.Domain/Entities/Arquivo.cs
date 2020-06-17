using System.Data;
using System.Net.NetworkInformation;
using System.Security.Permissions;

namespace Contratos.Domain.Entities
{
    public class Arquivo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public byte[] Conteudo { get; set; }
    }
}
