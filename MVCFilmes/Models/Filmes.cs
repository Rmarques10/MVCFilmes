using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCFilmes.Models
{
    public class Filmes
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name ="Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório"), 
            StringLength(20),
            RegularExpression(@"^[A-Z]+[a-zA-z\s]*$")]
        public string? Genero { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        [Range(0,5)]
        public int? Pontos { get; set; }
    }
}
