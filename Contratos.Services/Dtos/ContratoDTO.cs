using System;

namespace Contratos.Services.Dtos
{
    public class ContratoDTO
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string Tipo { get; set; }
        public string NomeArquivo { get; set; }
        public byte[] Arquivo { get; set; }
        public decimal Valor { get; set; }
        public DateTime MesAno { get; set; }
        public int Duracao { get; set; }
        public int Quantidade { get; set; }

        public ClienteDTO Cliente { get; set; }
    }
}
