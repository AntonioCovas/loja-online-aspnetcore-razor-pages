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
        [RegularExpression(@"[0-9]{11}$", ErrorMessage = "O campo {0} deve ser preenchido com 11 dígitos numéricos.")]
        [MaxLength(11, ErrorMessage = "O campo {0} deve conter no máximo {1} caracteres.")]
        [MinLength(11, ErrorMessage = "O campo {0} deve conter no mínimo {1} caracteres.")]
        [UIHint("_CPFTemplate")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [RegularExpression(@"[0-9]{11}$", ErrorMessage = "O campo {0} deve ser preenchido com 11 dígitos numéricos.")]
        [MaxLength(11, ErrorMessage = "O campo {0} deve conter no máximo {1} caracteres.")]
        [MinLength(11, ErrorMessage = "O campo {0} deve conter no mínimo {1} caracteres.")]
        [UIHint("_TelefoneTemplate")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [DisplayName("E-mail")]
        [MaxLength(50, ErrorMessage = "O campo {0} deve conter no máximo {1} caracteres.")]
        [EmailAddress(ErrorMessage = "O campo {0} deve conter um endereço de e-mail válido.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [DisplayName("Situação")]
        public SituacaoCliente Situacao { get; set; }

        public Endereco? Endereco { get;set; }

        public List<Pedido> Pedidos { get; set; }

        public enum SituacaoCliente
        {
            Bloqueado,
            Cadastrado,
            Aprovado,
            Especial
        }
    }
}
