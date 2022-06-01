namespace TP_APIs.Models
{
    public class PeliculaDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        public ICollection<ValoracionDto> Valoracion { get; set; } = new List<ValoracionDto>();

        public int CantidadValoracion
        {
            get { return Valoracion.Count; }
        }
    }
}
