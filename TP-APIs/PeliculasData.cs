using TP_APIs.Models;
namespace TP_APIs
{
    public class PeliculasData
    {
        public List<PeliculaDto> Peliculas { get; set; }
        public static PeliculasData InstanciaActual { get; } = new PeliculasData();

        public PeliculasData()
        {
            Peliculas = new List<PeliculaDto>()
            {
                new PeliculaDto()
                {
                    Id = 0,
                    Name = "Fight Club",
                    Description = "An insomniac office worker and a devil-may-care soap maker form an underground fight " +
                    "club that evolves into much more. A nameless first person narrator (Edward Norton) attends support groups " +
                    "in attempt to subdue his emotional state and relieve his insomniac state.",
                    Valoracion = new List<ValoracionDto>()
                    {
                        new ValoracionDto()
                        {
                            Id = 0,
                            Review = "Perhaps a little too long, but Fight Club is just a very well-made, brilliantly written and superlatively performed film.",
                            Score = 9,
                        },
                        new ValoracionDto()
                        {
                            Id = 1,
                            Review = "HOW THIS IS NOT EVERYONE'S FAVORITE MOVIE IS BESIDE ME",
                            Score = 10,
                        }
                    }
                }
            };
        }
    }
}
