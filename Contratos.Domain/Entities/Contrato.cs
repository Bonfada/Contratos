using System;

namespace Contratos.Domain.Entities
{
    public class Contrato
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string Tipo { get; set; }
        public string NomeArquivo { get; set; }
        public byte[] Arquivo { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public DateTime MesAno { get; set; }
        public int Duracao { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
