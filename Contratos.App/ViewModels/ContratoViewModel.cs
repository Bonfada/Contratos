using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Contratos.App.ViewModels
{
    public class ContratoViewModel
    {
        [DisplayName("Cliente")]
        public int ClienteId { get; set; }
        
        [DisplayName("Tipo")]
        public string Tipo { get; set; }
        public string NomeArquivo { get; set; }
        public string Arquivo { get; set; }

        [DisplayName("Quantidade")]
        public int Quantidade { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal),"0","999999999")]
        [Required(ErrorMessage ="Informe o valor")]
        [DisplayName("Valor Negociado")]
        public decimal Valor { get; set; }

        [DisplayName("Mês/Ano")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime MesAno { get; set; }

        [DisplayName("Duração")]
        public int Duracao { get; set; }

        public virtual ClienteViewModel Cliente { get; set; }

    }
}