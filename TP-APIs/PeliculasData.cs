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
                },
                new PeliculaDto()
                {
                    Id = 1,
                    Name = "Pulp Fiction",
                    Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits " +
                    "intertwine in four tales of violence and redemption.",
                    Valoracion = new List<ValoracionDto>()
                    {
                        new ValoracionDto()
                        {
                            Id = 2,
                            Review = "This is Tarantino's masterpiece, there's no other way to say it. It has arguably one of the smartest scripts " + 
                            "I've ever seen. The story, which is non-linear, is so well constructed it takes several viewings to grasp it all.",                            
                            Score = 8,
                        },
                        new ValoracionDto()
                        {
                            Id = 3,
                            Review = "Possibly the most influential movie made in history since the first movie ever made. Even after 25 years and a " +
                            "countless number of copy cats this movie absolutely holds up and feels fresh.",
                            Score = 9,
                        }
                    }
                },
                new PeliculaDto()
                {
                    Id = 2,
                    Name = "Goodfellas",
                    Description = "The lowly, blue-collar side of New York's Italian mafia is explored in this crime biopic of wiseguy Henry Hill. " +
                    "As he makes his way from strapping young petty criminal, to big-time thief, to middle-aged cocaine addict and dealer, the film " +
                    "explores in detail the rules and traditions of organized crime. ",
                    Valoracion = new List<ValoracionDto>()
                    {
                        new ValoracionDto()
                        {
                            Id = 4,
                            Review = "For its swaggering energy, the heart-in-your-throat pacing and for some of the most memorable, most imitated " +
                            "scenes in mafia movie history, this must rank as one of Scorsese's finest films, if not the best.",
                            Score = 8,
                        },
                        new ValoracionDto()
                        {
                            Id = 5,
                            Review = "Hard-hitting and stylish, GoodFellas is a gangster classic and arguably the high point of Martin Scorsese's career ",
                            Score = 9,
                        }
                    }
                }
            };
        }
    }
}
