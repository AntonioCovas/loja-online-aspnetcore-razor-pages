using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreWebApp.Models
{
    public class Produto
    {
        [Key]
        [Display(Name = "Código")]
        [DisplayFormat(DataFormatString = "{0:D60,}")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O campo \"{0}\" pode ter até {1} caracteres.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(1000, ErrorMessage = "O campo \"{0}\" pode ter até {1} caracteres.")]
        [Display(Name = "Descrição")]
        public string? Descricao { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public int Estoque { get; set; }
    }
}
