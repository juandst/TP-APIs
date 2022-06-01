using Microsoft.AspNetCore.Mvc;
using TP_APIs.Models;

namespace TP_APIs.Controllers
{
    [ApiController]
    [Route("api/peliculas/{idPelicula}/valoraciones")]
    public class ValoracionController : ControllerBase
    {


            [HttpGet]
            public ActionResult<IEnumerable<ValoracionDto>> GetValoraciones(int idPelicula)
            {
                var pelicula = PeliculasData.InstanciaActual.Peliculas.FirstOrDefault(x => x.Id == idPelicula);
                if (pelicula == null) return NotFound();
                return Ok(pelicula.Valoracion);
            }

            [HttpGet("{idValoracion}", Name = "GetValoraciones")]
            public ActionResult<ValoracionDto> GetValoraciones(int idPelicula, int idValoracion)
            {
                var pelicula = PeliculasData.InstanciaActual.Peliculas.FirstOrDefault(x => x.Id == idPelicula);
                if (pelicula == null) return NotFound();
                var valoracion = pelicula.Valoracion.FirstOrDefault(x => x.Id == idValoracion);
                if (valoracion == null) return NotFound();
                return Ok(valoracion);
            }
            [HttpPost]
            public ActionResult<ValoracionDto> CrearValoracion(int idPelicula, ValoracionCrearDto valoracion)
            {
                var pelicula = PeliculasData.InstanciaActual.Peliculas.FirstOrDefault(x => x.Id == idPelicula);
                if (pelicula is null) return NotFound();
                var idMaxValoraciones = PeliculasData.InstanciaActual.Peliculas.SelectMany(x => x.Valoracion).Max(x => x.Id);

                var nuevaValoracion = new ValoracionDto
                {
                    Id = ++idMaxValoraciones,
                    Review = valoracion.Review,
                    Score = valoracion.Score,
                };

                pelicula.Valoracion.Add(nuevaValoracion);

                return CreatedAtRoute("GetValoracion",
                    new
                    {
                        idPelicula,
                        idValoracion = nuevaValoracion.Id

                    },
                    nuevaValoracion);
            }

            [HttpPut("{idValoracion}")]
            public ActionResult UpdateValoracion(int idPelicula, int idValoracion, ValoracionUpdateDto valoracion)
            {
                var pelicula = PeliculasData.InstanciaActual.Peliculas.FirstOrDefault(x => x.Id == idPelicula);
                if (pelicula == null) return NotFound();
                var valoracionLocationDB = pelicula.Valoracion.FirstOrDefault(x => x.Id == idValoracion);
                if (valoracionLocationDB == null) return NotFound();

                valoracionLocationDB.Review = valoracion.Review;
                valoracionLocationDB.Score = valoracion.Score;

                return NoContent();

            }

            [HttpDelete("{idValoracion}")]
            public ActionResult DeleteValoracion (int idPelicula, int idValoracion)
            {
                var pelicula = PeliculasData.InstanciaActual.Peliculas.FirstOrDefault(x => x.Id == idPelicula);
                if (pelicula == null) return NotFound();
                var valoracionEliminar = pelicula.Valoracion.FirstOrDefault(x=> x.Id == idValoracion);
                if (valoracionEliminar is null) return NotFound();

                pelicula.Valoracion.Remove(valoracionEliminar);

                return NoContent();
            }
    }
}
