using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Contratos.App.ViewModels
{
    public class ClienteViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o nome.")]
        [MinLength(6, ErrorMessage = "O nome deve ter no mínimo 5 carácteres")]
        [MaxLength(50, ErrorMessage = "O nome deve ter no máximo 50 carácteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o E-mail.")]
        [MaxLength(50, ErrorMessage = "O E-mail deve ter no máximo 50 carácteres")]
        [EmailAddress(ErrorMessage = "Informe um E-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }
    }
}