using System.ComponentModel.DataAnnotations;

namespace MVCFilmes.Models
{
    public class Filmes
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }
        public string? Genero { get; set; }
        public decimal Preco { get; set; }
    }
}
