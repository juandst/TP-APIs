using System.ComponentModel.DataAnnotations;

namespace TP_APIs.Models
{
    public class ValoracionCrearDto
    {
        [Required(ErrorMessage = "Escribí una review")]
        [MinLength(10, ErrorMessage = "Longitud minima: 10 caracteres")]
        [MaxLength(600, ErrorMessage = "Longitud máxima: 600 caracteres")]
        public string Review { get; set; } = string.Empty;
        [Required(ErrorMessage = "Escribi un puntaje")]
        [Range(0, 10, ErrorMessage = "La puntuacion debe ser entre 0 y 10")]
        public int Score { get; set; }
    }
}
