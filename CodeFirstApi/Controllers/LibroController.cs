using DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Globalization;

namespace CodeFirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
       
        private TiendaLibroContext _context;
        private IConfiguration _configuration;
        public LibroController(TiendaLibroContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Libro> Get() => _context.Libros.ToList();
        
        [HttpPost]
        public IActionResult Post([FromBody] Libro nuevoLibro)
        {
            if (nuevoLibro == null)
            {
                return BadRequest("El libro no puede ser nulo");
            }

            try
            {
                _context.Libros.Add(nuevoLibro);
                _context.SaveChanges();

                return CreatedAtRoute("GetLibro", new { id = nuevoLibro.LibroId }, nuevoLibro);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }


    }
}
