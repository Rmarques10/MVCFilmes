using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCFilmes.Models
{
    public class Filmes
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }

        [Display(Name ="Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }
        public string? Genero { get; set; }

        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        [Range(0,5)]
        public int? Pontos { get; set; }
    }
}
