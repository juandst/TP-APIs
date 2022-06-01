using Microsoft.AspNetCore.Mvc;
using TP_APIs.Models;

namespace TP_APIs.Controllers
{
    [ApiController]
    [Route("api/peliculas")]

    public class PeliculasController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<PeliculaDto>> GetPeliculas()
        {
            return Ok(PeliculasData.InstanciaActual.Peliculas);
        }

        [HttpGet("{id:int}")]
        public ActionResult<PeliculaDto> GetPelicula(int id)
        {
            var result = PeliculasData.InstanciaActual.Peliculas.FirstOrDefault(x => x.Id == id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public ActionResult<PeliculaDto> CreatePelicula(PeliculaCrearDto pelicula)
        {
            var peliculas = PeliculasData.InstanciaActual.Peliculas;
            var lastId = PeliculasData.InstanciaActual.Peliculas.Max(x => x.Id);
            var nuevaPelicula = new PeliculaDto
            {
                Id = ++lastId,
                Name = pelicula.Name,
                Description = pelicula.Description,

            };
            peliculas.Add(nuevaPelicula);

            return CreatedAtRoute("GetPelicula", nuevaPelicula);
        }

        [HttpPut("{id:int}")]
        public ActionResult UpdatePelicula(int id, PeliculaUpdateDto pelicula)
        {
            var peliculaLocationDB = PeliculasData.InstanciaActual.Peliculas.FirstOrDefault(x => x.Id == id);
            if (peliculaLocationDB == null) return NotFound();

            peliculaLocationDB.Name = pelicula.Name;
            peliculaLocationDB.Description = pelicula.Description;
            peliculaLocationDB.Valoracion = new List<ValoracionDto>();

            return NoContent();

        }

        [HttpDelete("{id:int}")]
        public ActionResult DeletePelicula(int id)
        {
            var peliculas = PeliculasData.InstanciaActual.Peliculas;
            var peliculaDelete = PeliculasData.InstanciaActual.Peliculas.FirstOrDefault(x => x.Id == id);
            if(peliculaDelete == null) return NotFound();
            peliculas.Remove(peliculas.Where(x => x.Id == id).First());

            return NoContent();
        }

    }
}
