using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Titulo is empty!")]
        public string Titulo { get; set; }
        [Required]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage ="Genero reached size limit!")]
        public string Genero { get; set; }
        [Range(1, 600)]
        public int Duracao { get; set; }
    }
}
 