using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreWebApp.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [DisplayName("Data de nascimento")]
        [DataType(DataType.Date, ErrorMessage = "O campo {0} deve conter uma data válida.")]
        public DateTime DataNascimento { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(11, ErrorMessage = "O campo {0} deve conter no máximo {1} caracteres.")]
        [RegularExpression(@"[0-9]{11}$", ErrorMessage = "O campo {0} deve ser preenchido com 11 dígitos numéricos.")]
        [UIHint("_CustomCPF")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [DisplayName("E-mail")]
        [EmailAddress(ErrorMessage = "O campo {0} deve conter um endereço de e-mail válido.")]
        public string? Email { get; set; }
    }
}
