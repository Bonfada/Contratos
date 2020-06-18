using System.ComponentModel.DataAnnotations;

namespace Contratos.App.ViewModels
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe seu nome.")]
        [MaxLength(50, ErrorMessage = "O nome deve ter no máximo 50 carácteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe seu login")]
        [MaxLength(15, ErrorMessage = "O login deve ter no máximo 15 carácteres")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Informe sua senha")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "A senha deve ter no mínimo 6 caracteres")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Confirme sua senha.")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "A senha deve ter no mínimo 6 caracteres")]
        [Compare(nameof(Senha), ErrorMessage = "As senhas devem ser iguais")]
        [Display(Name = "Confirme a senha")]
        public string ConfirmarSenha { get; set; }
    }
}