using System;

namespace Contratos.Domain.Entities
{
    public class Contrato
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int TipoId { get; set; }
        public int ArquivoId { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public DateTime MesAno { get; set; }
        public int Duracao { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual TipoContrato Tipo { get; set; }
        public virtual Arquivo Arquivo { get; set; }
    }
}
