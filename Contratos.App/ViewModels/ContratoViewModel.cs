using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Contratos.App.ViewModels
{
    public class ContratoViewModel
    {
        public int ClienteId { get; set; }
        
        [DisplayName("Tipo do Contrato (Compra e Venda)")]
        public string Tipo { get; set; }
        public int ArquivoId { get; set; }

        [DisplayName("Quantidade Negociada")]
        public int Quantidade { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal),"0","999999999")]
        [Required(ErrorMessage ="Informe o valor")]
        [DisplayName("Valor Negociado")]
        public decimal Valor { get; set; }

        [DisplayName("Mês/Ano do início do contrato")]
        public DateTime MesAno { get; set; }

        [DisplayName("Duração em meses do contrato")]
        public int Duracao { get; set; }

        public virtual ClienteViewModel Clientes { get; set; }

    }
}