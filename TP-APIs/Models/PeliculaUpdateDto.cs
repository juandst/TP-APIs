using System.ComponentModel.DataAnnotations;
namespace TP_APIs.Models
{
    public class PeliculaUpdateDto
    {
        [Required(ErrorMessage = "Ingrese el titulo de una pelicula")]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Ingrese una descripción")]
        [MaxLength(600)]
        public string? Description { get; set; }

    }
}
